namespace MyUI
{
    partial class FrmParameterConfig
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
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel22 = new Sunny.UI.UILabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.cmbDevice = new Sunny.UI.UIComboBox();
            this.txtCode = new Sunny.UI.UITextBox();
            this.txtModel = new Sunny.UI.UITextBox();
            this.numCollectInterval = new System.Windows.Forms.NumericUpDown();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.numUploadInterval = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numCollectInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUploadInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(120, 365);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "确定";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.ForeColor = System.Drawing.Color.White;
            this.uiLabel6.Location = new System.Drawing.Point(117, 298);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(59, 17);
            this.uiLabel6.TabIndex = 24;
            this.uiLabel6.Text = "上传间隔:";
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.ForeColor = System.Drawing.Color.White;
            this.uiLabel5.Location = new System.Drawing.Point(117, 258);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(59, 17);
            this.uiLabel5.TabIndex = 23;
            this.uiLabel5.Text = "采集间隔:";
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.White;
            this.uiLabel3.Location = new System.Drawing.Point(93, 184);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(59, 17);
            this.uiLabel3.TabIndex = 30;
            this.uiLabel3.Text = "设备编号:";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.White;
            this.uiLabel2.Location = new System.Drawing.Point(93, 146);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(59, 17);
            this.uiLabel2.TabIndex = 27;
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
            this.uiLabel1.TabIndex = 31;
            this.uiLabel1.Text = "设备名称:";
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.ForeColor = System.Drawing.Color.Silver;
            this.uiLabel4.Location = new System.Drawing.Point(48, 223);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(56, 17);
            this.uiLabel4.TabIndex = 21;
            this.uiLabel4.Text = "采集参数";
            // 
            // uiLabel22
            // 
            this.uiLabel22.AutoSize = true;
            this.uiLabel22.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel22.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel22.ForeColor = System.Drawing.Color.Silver;
            this.uiLabel22.Location = new System.Drawing.Point(48, 69);
            this.uiLabel22.Name = "uiLabel22";
            this.uiLabel22.Size = new System.Drawing.Size(56, 17);
            this.uiLabel22.TabIndex = 20;
            this.uiLabel22.Text = "设备信息";
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
            this.uiSymbolLabel1.Text = "参数配置";
            // 
            // cmbDevice
            // 
            this.cmbDevice.DataSource = null;
            this.cmbDevice.FillColor = System.Drawing.Color.White;
            this.cmbDevice.Font = new System.Drawing.Font("宋体", 12F);
            this.cmbDevice.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cmbDevice.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cmbDevice.Location = new System.Drawing.Point(192, 94);
            this.cmbDevice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDevice.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbDevice.Size = new System.Drawing.Size(129, 24);
            this.cmbDevice.SymbolSize = 24;
            this.cmbDevice.TabIndex = 44;
            this.cmbDevice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbDevice.Watermark = "请选择设备";
            // 
            // txtCode
            // 
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.Font = new System.Drawing.Font("宋体", 12F);
            this.txtCode.Location = new System.Drawing.Point(192, 179);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCode.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtCode.Name = "txtCode";
            this.txtCode.Padding = new System.Windows.Forms.Padding(5);
            this.txtCode.RectColor = System.Drawing.Color.Transparent;
            this.txtCode.ShowText = false;
            this.txtCode.Size = new System.Drawing.Size(62, 22);
            this.txtCode.TabIndex = 34;
            this.txtCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtCode.Watermark = "";
            // 
            // txtModel
            // 
            this.txtModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModel.Font = new System.Drawing.Font("宋体", 12F);
            this.txtModel.Location = new System.Drawing.Point(192, 139);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModel.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModel.Name = "txtModel";
            this.txtModel.Padding = new System.Windows.Forms.Padding(5);
            this.txtModel.RectColor = System.Drawing.Color.Transparent;
            this.txtModel.ShowText = false;
            this.txtModel.Size = new System.Drawing.Size(62, 22);
            this.txtModel.TabIndex = 34;
            this.txtModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModel.Watermark = "";
            // 
            // numCollectInterval
            // 
            this.numCollectInterval.Location = new System.Drawing.Point(192, 254);
            this.numCollectInterval.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numCollectInterval.Name = "numCollectInterval";
            this.numCollectInterval.Size = new System.Drawing.Size(62, 21);
            this.numCollectInterval.TabIndex = 46;
            // 
            // uiLabel9
            // 
            this.uiLabel9.AutoSize = true;
            this.uiLabel9.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel9.ForeColor = System.Drawing.Color.White;
            this.uiLabel9.Location = new System.Drawing.Point(260, 258);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(14, 17);
            this.uiLabel9.TabIndex = 47;
            this.uiLabel9.Text = "s";
            // 
            // uiLabel10
            // 
            this.uiLabel10.AutoSize = true;
            this.uiLabel10.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel10.ForeColor = System.Drawing.Color.White;
            this.uiLabel10.Location = new System.Drawing.Point(260, 298);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(14, 17);
            this.uiLabel10.TabIndex = 47;
            this.uiLabel10.Text = "s";
            // 
            // numUploadInterval
            // 
            this.numUploadInterval.Location = new System.Drawing.Point(192, 294);
            this.numUploadInterval.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numUploadInterval.Name = "numUploadInterval";
            this.numUploadInterval.Size = new System.Drawing.Size(62, 21);
            this.numUploadInterval.TabIndex = 46;
            // 
            // FrmParameterConfig
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(55)))), ((int)(((byte)(88)))));
            this.Controls.Add(this.numUploadInterval);
            this.Controls.Add(this.uiLabel10);
            this.Controls.Add(this.numCollectInterval);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.cmbDevice);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel22);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmParameterConfig";
            this.Size = new System.Drawing.Size(800, 410);
            this.Load += new System.EventHandler(this.FrmParameterConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCollectInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUploadInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel22;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UIComboBox cmbDevice;
        private Sunny.UI.UITextBox txtCode;
        private Sunny.UI.UITextBox txtModel;
        private System.Windows.Forms.NumericUpDown numCollectInterval;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel10;
        private System.Windows.Forms.NumericUpDown numUploadInterval;
    }
}
