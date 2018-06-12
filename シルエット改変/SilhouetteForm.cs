using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PEPlugin;
using PEPlugin.View;

namespace Plugin
{
    public partial class SilhouetteForm : Form
    {
        #region メンバ変数
        ColorDialog colorDialog = new ColorDialog();
        #endregion

        #region プロパティ
        /// <summary>
        /// PMXデータ
        /// </summary>
        public IPERunArgs Args
        {
            set;
            get;
        }
        #endregion


        /// <summary>
        /// 初期化
        /// </summary>
        public SilhouetteForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Shonwイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SilhouetteForm_Shown(object sender, EventArgs e)
        {
            // 現在のPMXデータを複製取得
            PEPlugin.Pmx.IPXPmx pe = Args.Host.Connector.Pmx.GetCurrentState();

            // 材質数チェック
            if (pe.Material.Count == 0)
            {
                MessageBox.Show("モデルが読み込まれていないか、材質がありません。"
                    , "エラー"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Grid初期化
            GridMaterial.Rows.Clear();
            
            // GridMaterialの表示
            foreach (var Material in pe.Material)
            {
                // 行追加
                // 色はデフォルトで黒とする
                GridMaterial.Rows.Add(Material.Name, "");
                GridMaterial.Rows[GridMaterial.Rows.Count - 1].Cells[1].Style.BackColor = Color.Black;
                GridMaterial.Rows[GridMaterial.Rows.Count - 1].Cells[1].Style.SelectionBackColor = Color.FromArgb(0xFF0000);
                GridMaterial.Rows[GridMaterial.Rows.Count - 1].Resizable = DataGridViewTriState.False;
            }
            GridMaterial.Refresh();
        }


        /// <summary>
        /// 色を変更ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeCollar_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // 選択行のカラー列を変更
                foreach (DataGridViewRow SelRow in GridMaterial.SelectedRows)
                {
                    SelRow.Cells[1].Style.BackColor = colorDialog.Color;
                }
                GridMaterial.Refresh();
            }
        }


        /// <summary>
        /// 確定ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            // 最終確認
            if (MessageBox.Show("処理を実行します。よろしいですか？"
                ,"確認"
                ,MessageBoxButtons.OKCancel
                ,MessageBoxIcon.Asterisk) != DialogResult.OK)
            {
                return;
            }
            
            // 全材質に対しシルエット処理
            ///*
            
            // 現在のPMXデータを複製取得
            PEPlugin.Pmx.IPXPmx pe = Args.Host.Connector.Pmx.GetCurrentState();
            int rows = 0;
            foreach (var Material in pe.Material)
            {
                // エッジ off
                Material.Edge = false;
                // 反射強度 0
                Material.Power = 0;
                // セルフシャドウ off
                Material.SelfShadow = false;
                // セルフシャドウマップ off
                Material.SelfShadowMap = false;
                // 地面影 off
                Material.Shadow = false;
                // テクスチャ削除
                Material.Tex = "";
                // Toon削除
                Material.Toon = "";
                // スフィア削除
                Material.Sphere = "";
                // 拡散色 RGB 0
                Material.Diffuse.R = 0;
                Material.Diffuse.G = 0;
                Material.Diffuse.B = 0;
                // 非透過度が0のものは除外
#warning TODO：後で0を超える非透過度については非透過とするかそのままとするかチェックで選択できるようにする
                if (Material.Diffuse.A != 0)
                    Material.Diffuse.A = 1;
                // 反射色 RGB 0
                Material.Specular.R = 0;
                Material.Specular.G = 0;
                Material.Specular.B = 0;
                // 環境色 RGB 0    
                // Gridより色を取得する
                Color color = GridMaterial.Rows[rows].Cells[1].Style.BackColor;
                Material.Ambient.R = color.R / (float)255;
                Material.Ambient.G = color.G / (float)255;
                Material.Ambient.B = color.B / (float)255;

                rows++;
            }

            // 編集したモデル情報でPMXエディタ側を更新
            Args.Host.Connector.Pmx.Update(pe, PEPlugin.Pmx.PmxUpdateObject.Material, -1);

            // 表示更新
            Args.Host.Connector.Form.UpdateList(PEPlugin.Pmd.UpdateObject.Material);
            Args.Host.Connector.View.PmxView.UpdateModel();
            Args.Host.Connector.View.PmxView.UpdateView();

            // 終了
            MessageBox.Show("処理完了しました。"
                , "終了"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Asterisk);
            this.Close();
        }


        /// <summary>
        /// メニュー->バージョン情報押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plugin.VersionInfo versionInfo = new VersionInfo();
            versionInfo.ShowDialog();
        }
        
        /// <summary>
        /// 行選択イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridMaterial_SelectionChanged(object sender, EventArgs e)
        {
            // 1つ以上選択で「色を変更」ボタンを使用可
            btnChangeCollar.Enabled = GridMaterial.SelectedRows.Count >= 1;
        }
    }
}
