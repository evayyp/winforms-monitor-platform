namespace MyUI
{
    partial class FrmSystemConfig
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
            this.cmbLanguage = new Sunny.UI.UIComboBox();
            this.btnSave = new Sunny.UI.UIButton();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.txtSystemName = new Sunny.UI.UITextBox();
            this.chkAutoLogin = new Sunny.UI.UICheckBox();
            this.cmbLogLevel = new Sunny.UI.UIComboBox();
            this.SuspendLayout();
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DataSource = null;
            this.cmbLanguage.FillColor = System.Drawing.Color.White;
            this.cmbLanguage.Font = new System.Drawing.Font("宋体", 12F);
            this.cmbLanguage.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cmbLanguage.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cmbLanguage.Location = new System.Drawing.Point(192, 146);
            this.cmbLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbLanguage.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbLanguage.Size = new System.Drawing.Size(153, 24);
            this.cmbLanguage.SymbolSize = 24;
            this.cmbLanguage.TabIndex = 60;
            this.cmbLanguage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbLanguage.Watermark = "请选择语言";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(96, 298);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "确定";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.ForeColor = System.Drawing.Color.White;
            this.uiLabel5.Location = new System.Drawing.Point(93, 249);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(59, 17);
            this.uiLabel5.TabIndex = 52;
            this.uiLabel5.Text = "采集间隔:";
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.White;
            this.uiLabel3.Location = new System.Drawing.Point(93, 197);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(59, 17);
            this.uiLabel3.TabIndex = 55;
            this.uiLabel3.Text = "自动登录:";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.White;
            this.uiLabel2.Location = new System.Drawing.Point(93, 149);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(59, 17);
            this.uiLabel2.TabIndex = 54;
            this.uiLabel2.Text = "设备型号:";
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
            this.uiLabel1.Text = "系统名称:";
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
            this.uiSymbolLabel1.Text = "系统配置";
            // 
            // txtSystemName
            // 
            this.txtSystemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSystemName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSystemName.Location = new System.Drawing.Point(192, 96);
            this.txtSystemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSystemName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSystemName.Name = "txtSystemName";
            this.txtSystemName.Padding = new System.Windows.Forms.Padding(5);
            this.txtSystemName.RectColor = System.Drawing.Color.Transparent;
            this.txtSystemName.ShowText = false;
            this.txtSystemName.Size = new System.Drawing.Size(153, 22);
            this.txtSystemName.TabIndex = 57;
            this.txtSystemName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSystemName.Watermark = "";
            // 
            // chkAutoLogin
            // 
            this.chkAutoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAutoLogin.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoLogin.ForeColor = System.Drawing.Color.White;
            this.chkAutoLogin.Location = new System.Drawing.Point(192, 190);
            this.chkAutoLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkAutoLogin.Name = "chkAutoLogin";
            this.chkAutoLogin.Size = new System.Drawing.Size(82, 29);
            this.chkAutoLogin.TabIndex = 67;
            this.chkAutoLogin.Text = "启用";
            // 
            // cmbLogLevel
            // 
            this.cmbLogLevel.DataSource = null;
            this.cmbLogLevel.FillColor = System.Drawing.Color.White;
            this.cmbLogLevel.Font = new System.Drawing.Font("宋体", 12F);
            this.cmbLogLevel.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cmbLogLevel.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cmbLogLevel.Location = new System.Drawing.Point(192, 242);
            this.cmbLogLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbLogLevel.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbLogLevel.Name = "cmbLogLevel";
            this.cmbLogLevel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbLogLevel.Size = new System.Drawing.Size(153, 24);
            this.cmbLogLevel.SymbolSize = 24;
            this.cmbLogLevel.TabIndex = 60;
            this.cmbLogLevel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbLogLevel.Watermark = "请选择语言";
            // 
            // FrmSystemConfig
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(55)))), ((int)(((byte)(88)))));
            this.Controls.Add(this.chkAutoLogin);
            this.Controls.Add(this.cmbLogLevel);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSystemName);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSystemConfig";
            this.Size = new System.Drawing.Size(800, 410);
            this.Load += new System.EventHandler(this.FrmSystemConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UIComboBox cmbLanguage;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UITextBox txtSystemName;
        private Sunny.UI.UICheckBox chkAutoLogin;
        private Sunny.UI.UIComboBox cmbLogLevel;
    }
}
