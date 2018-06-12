namespace Plugin
{
    partial class SilhouetteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridMaterial = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangeCollar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCollar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridMaterial)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridMaterial
            // 
            this.GridMaterial.AllowUserToAddRows = false;
            this.GridMaterial.AllowUserToDeleteRows = false;
            this.GridMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtMaterial,
            this.txtCollar});
            this.GridMaterial.Location = new System.Drawing.Point(12, 27);
            this.GridMaterial.Name = "GridMaterial";
            this.GridMaterial.ReadOnly = true;
            this.GridMaterial.RowHeadersVisible = false;
            this.GridMaterial.RowTemplate.Height = 21;
            this.GridMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridMaterial.Size = new System.Drawing.Size(215, 451);
            this.GridMaterial.TabIndex = 0;
            this.GridMaterial.SelectionChanged += new System.EventHandler(this.GridMaterial_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.情報ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(415, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 情報ToolStripMenuItem
            // 
            this.情報ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョン情報ToolStripMenuItem});
            this.情報ToolStripMenuItem.Name = "情報ToolStripMenuItem";
            this.情報ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.情報ToolStripMenuItem.Text = "情報";
            // 
            // バージョン情報ToolStripMenuItem
            // 
            this.バージョン情報ToolStripMenuItem.Name = "バージョン情報ToolStripMenuItem";
            this.バージョン情報ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.バージョン情報ToolStripMenuItem.Text = "バージョン情報";
            this.バージョン情報ToolStripMenuItem.Click += new System.EventHandler(this.バージョン情報ToolStripMenuItem_Click);
            // 
            // btnChangeCollar
            // 
            this.btnChangeCollar.Enabled = false;
            this.btnChangeCollar.Location = new System.Drawing.Point(233, 130);
            this.btnChangeCollar.Name = "btnChangeCollar";
            this.btnChangeCollar.Size = new System.Drawing.Size(170, 48);
            this.btnChangeCollar.TabIndex = 2;
            this.btnChangeCollar.Text = "色を変更";
            this.btnChangeCollar.UseVisualStyleBackColor = true;
            this.btnChangeCollar.Click += new System.EventHandler(this.btnChangeCollar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(169, 96);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "簡易的な使用方法\r\n①色を変更したい材質を選択\r\n　（Shiftキー、Ctrlキーによる\r\n　　複数選択が可能）\r\n②「色を変更」ボタンをクリックし、\r\n　　適当" +
    "な色を選択\r\n③「確定」ボタンをクリック";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(234, 184);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(170, 48);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "確定";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtMaterial
            // 
            this.txtMaterial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.txtMaterial.HeaderText = "材質名";
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.ReadOnly = true;
            this.txtMaterial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.txtMaterial.Width = 120;
            // 
            // txtCollar
            // 
            this.txtCollar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.txtCollar.HeaderText = "カラー";
            this.txtCollar.Name = "txtCollar";
            this.txtCollar.ReadOnly = true;
            this.txtCollar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.txtCollar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.txtCollar.Width = 70;
            // 
            // SilhouetteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 490);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnChangeCollar);
            this.Controls.Add(this.GridMaterial);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SilhouetteForm";
            this.Text = "シルエット改変";
            this.Shown += new System.EventHandler(this.SilhouetteForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.GridMaterial)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridMaterial;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 情報ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報ToolStripMenuItem;
        private System.Windows.Forms.Button btnChangeCollar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCollar;
    }
}