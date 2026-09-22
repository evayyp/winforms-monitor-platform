namespace MyUI
{
    partial class FrmStorageConfig
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.numSaveDays = new System.Windows.Forms.NumericUpDown();
            this.chkAutoClean = new Sunny.UI.UICheckBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.timeClean = new Sunny.UI.UITimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numSaveDays)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(101, 299);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "确定";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.White;
            this.uiLabel2.Location = new System.Drawing.Point(93, 159);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(59, 17);
            this.uiLabel2.TabIndex = 54;
            this.uiLabel2.Text = "自动清理:";
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(93, 101);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(59, 17);
            this.uiLabel1.TabIndex = 56;
            this.uiLabel1.Text = "保存天数:";
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine1.LineColor = System.Drawing.Color.Gray;
            this.uiLine1.Location = new System.Drawing.Point(0, 43);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(800, 14);
            this.uiLine1.TabIndex = 49;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(0, 16);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Size = new System.Drawing.Size(139, 29);
            this.uiSymbolLabel1.Symbol = 61518;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.TabIndex = 48;
            this.uiSymbolLabel1.Text = "存储配置";
            // 
            // numSaveDays
            // 
            this.numSaveDays.Location = new System.Drawing.Point(192, 97);
            this.numSaveDays.Name = "numSaveDays";
            this.numSaveDays.Size = new System.Drawing.Size(120, 21);
            this.numSaveDays.TabIndex = 65;
            // 
            // chkAutoClean
            // 
            this.chkAutoClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAutoClean.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoClean.ForeColor = System.Drawing.Color.White;
            this.chkAutoClean.Location = new System.Drawing.Point(192, 151);
            this.chkAutoClean.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkAutoClean.Name = "chkAutoClean";
            this.chkAutoClean.Size = new System.Drawing.Size(120, 29);
            this.chkAutoClean.TabIndex = 66;
            this.chkAutoClean.Text = "启用";
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.White;
            this.uiLabel3.Location = new System.Drawing.Point(93, 226);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(59, 17);
            this.uiLabel3.TabIndex = 55;
            this.uiLabel3.Text = "清理时间:";
            // 
            // timeClean
            // 
            this.timeClean.FillColor = System.Drawing.Color.White;
            this.timeClean.Font = new System.Drawing.Font("宋体", 12F);
            this.timeClean.Location = new System.Drawing.Point(192, 216);
            this.timeClean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeClean.MaxLength = 8;
            this.timeClean.MinimumSize = new System.Drawing.Size(63, 0);
            this.timeClean.Name = "timeClean";
            this.timeClean.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.timeClean.Size = new System.Drawing.Size(120, 27);
            this.timeClean.SymbolDropDown = 61555;
            this.timeClean.SymbolNormal = 61555;
            this.timeClean.SymbolSize = 24;
            this.timeClean.TabIndex = 67;
            this.timeClean.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.timeClean.TimeCultureInfo = new System.Globalization.CultureInfo("zh-CN");
            this.timeClean.Value = new System.DateTime(2026, 7, 27, 15, 46, 7, 760);
            this.timeClean.Watermark = "";
            // 
            // FrmStorageConfig
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(55)))), ((int)(((byte)(88)))));
            this.Controls.Add(this.timeClean);
            this.Controls.Add(this.chkAutoClean);
            this.Controls.Add(this.numSaveDays);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmStorageConfig";
            this.Size = new System.Drawing.Size(800, 410);
            this.Load += new System.EventHandler(this.FrmStorageConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSaveDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private System.Windows.Forms.NumericUpDown numSaveDays;
        private Sunny.UI.UICheckBox chkAutoClean;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITimePicker timeClean;
    }
}
