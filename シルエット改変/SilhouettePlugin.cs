using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEPlugin;
using Plugin;

namespace Plugin
{
    public class SilhouettePlugin : PEPluginClass
    {
        #region 定数
        /// <summary>
        /// プラグイン名
        /// </summary>
        const string PLUGIN_NAME = "シルエット改変";
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SilhouettePlugin() : base()
        {
            m_option = new PEPluginOption(false, true, PLUGIN_NAME);
        }
        #endregion

        #region プラグイン実行
        /// <summary>
        /// プラグイン実行
        /// </summary>
        /// <param name="args">PMXデータ</param>
        public override void Run(IPERunArgs args)
        {
            // フォーム側でプラグイン処理を行う
            SilhouetteForm sForm = new SilhouetteForm
            {
                Args = args
            };
            sForm.ShowDialog();
        }
        #endregion
    }
}
