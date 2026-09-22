namespace MyUI
{
    partial class FrmCommunicationConfig
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.cmbProtocol = new Sunny.UI.UIComboBox();
            this.txtIPAddress = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.numRetry = new System.Windows.Forms.NumericUpDown();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.numCollectInterval = new System.Windows.Forms.NumericUpDown();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.numTimeout = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRetry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCollectInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(102, 299);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(94, 97);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(59, 17);
            this.uiLabel1.TabIndex = 31;
            this.uiLabel1.Text = "通信协议:";
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
            this.uiLine1.TabIndex = 19;
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
            this.uiSymbolLabel1.TabIndex = 12;
            this.uiSymbolLabel1.Text = "通信配置";
            // 
            // cmbProtocol
            // 
            this.cmbProtocol.DataSource = null;
            this.cmbProtocol.FillColor = System.Drawing.Color.White;
            this.cmbProtocol.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProtocol.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cmbProtocol.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cmbProtocol.Location = new System.Drawing.Point(192, 89);
            this.cmbProtocol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProtocol.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbProtocol.Name = "cmbProtocol";
            this.cmbProtocol.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbProtocol.Size = new System.Drawing.Size(128, 25);
            this.cmbProtocol.SymbolSize = 24;
            this.cmbProtocol.TabIndex = 3;
            this.cmbProtocol.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbProtocol.Watermark = "请选择通信协议";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIPAddress.Font = new System.Drawing.Font("宋体", 12F);
            this.txtIPAddress.Location = new System.Drawing.Point(499, 92);
            this.txtIPAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIPAddress.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Padding = new System.Windows.Forms.Padding(5);
            this.txtIPAddress.RectColor = System.Drawing.Color.Transparent;
            this.txtIPAddress.ShowText = false;
            this.txtIPAddress.Size = new System.Drawing.Size(128, 22);
            this.txtIPAddress.TabIndex = 36;
            this.txtIPAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtIPAddress.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.White;
            this.uiLabel2.Location = new System.Drawing.Point(401, 92);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(46, 17);
            this.uiLabel2.TabIndex = 31;
            this.uiLabel2.Text = "IP地址:";
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.White;
            this.uiLabel3.Location = new System.Drawing.Point(99, 159);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(47, 17);
            this.uiLabel3.TabIndex = 31;
            this.uiLabel3.Text = "端口号:";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(198, 160);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(62, 21);
            this.numPort.TabIndex = 44;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.ForeColor = System.Drawing.Color.White;
            this.uiLabel4.Location = new System.Drawing.Point(93, 218);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(59, 17);
            this.uiLabel4.TabIndex = 31;
            this.uiLabel4.Text = "重试次数:";
            // 
            // numRetry
            // 
            this.numRetry.Location = new System.Drawing.Point(192, 219);
            this.numRetry.Name = "numRetry";
            this.numRetry.Size = new System.Drawing.Size(62, 21);
            this.numRetry.TabIndex = 44;
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.ForeColor = System.Drawing.Color.White;
            this.uiLabel6.Location = new System.Drawing.Point(401, 223);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(83, 17);
            this.uiLabel6.TabIndex = 31;
            this.uiLabel6.Text = "数据采集间隔:";
            // 
            // numCollectInterval
            // 
            this.numCollectInterval.Location = new System.Drawing.Point(500, 224);
            this.numCollectInterval.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numCollectInterval.Name = "numCollectInterval";
            this.numCollectInterval.Size = new System.Drawing.Size(62, 21);
            this.numCollectInterval.TabIndex = 44;
            // 
            // uiLabel8
            // 
            this.uiLabel8.AutoSize = true;
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel8.ForeColor = System.Drawing.Color.White;
            this.uiLabel8.Location = new System.Drawing.Point(401, 159);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(59, 17);
            this.uiLabel8.TabIndex = 31;
            this.uiLabel8.Text = "超时时间:";
            // 
            // numTimeout
            // 
            this.numTimeout.Location = new System.Drawing.Point(500, 160);
            this.numTimeout.Name = "numTimeout";
            this.numTimeout.Size = new System.Drawing.Size(62, 21);
            this.numTimeout.TabIndex = 44;
            // 
            // FrmCommunicationConfig
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(55)))), ((int)(((byte)(88)))));
            this.Controls.Add(this.numTimeout);
            this.Controls.Add(this.numCollectInterval);
            this.Controls.Add(this.numRetry);
            this.Controls.Add(this.numPort);
            this.Controls.Add(this.cmbProtocol);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCommunicationConfig";
            this.Size = new System.Drawing.Size(800, 410);
            this.Load += new System.EventHandler(this.FrmCommunicationConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRetry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCollectInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UIComboBox cmbProtocol;
        private Sunny.UI.UITextBox txtIPAddress;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private System.Windows.Forms.NumericUpDown numPort;
        private Sunny.UI.UILabel uiLabel4;
        private System.Windows.Forms.NumericUpDown numRetry;
        private Sunny.UI.UILabel uiLabel6;
        private System.Windows.Forms.NumericUpDown numCollectInterval;
        private Sunny.UI.UILabel uiLabel8;
        private System.Windows.Forms.NumericUpDown numTimeout;
    }
}
