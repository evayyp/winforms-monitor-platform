namespace MyUI
{
    partial class FrmAlertQuery
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlertQuery));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.timeLabel = new Sunny.UI.UILabel();
            this.nowDateLabel = new Sunny.UI.UILabel();
            this.minLabel = new Sunny.UI.UISymbolLabel();
            this.closeLabel = new Sunny.UI.UISymbolLabel();
            this.topPanel = new Sunny.UI.UIPanel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.buttonLayoutPanel = new Sunny.UI.UITableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiRadioButton1 = new Sunny.UI.UIRadioButton();
            this.uiRadioButton2 = new Sunny.UI.UIRadioButton();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.chkHigh = new Sunny.UI.UICheckBox();
            this.chkLow = new Sunny.UI.UICheckBox();
            this.chkCancelHigh = new Sunny.UI.UICheckBox();
            this.chkCancelLow = new Sunny.UI.UICheckBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.cmbSource = new Sunny.UI.UIComboBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.dtpStart = new Sunny.UI.UIDatetimePicker();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.dtpEnd = new Sunny.UI.UIDatetimePicker();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiPagination1 = new Sunny.UI.UIPagination();
            this.topPanel.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.buttonLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Location = new System.Drawing.Point(326, 9);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(165, 24);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "实训2班智能设备监控平台";
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.timeLabel.Location = new System.Drawing.Point(638, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(56, 24);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "14：12";
            // 
            // nowDateLabel
            // 
            this.nowDateLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nowDateLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.nowDateLabel.Location = new System.Drawing.Point(12, 9);
            this.nowDateLabel.Name = "nowDateLabel";
            this.nowDateLabel.Size = new System.Drawing.Size(131, 24);
            this.nowDateLabel.TabIndex = 0;
            this.nowDateLabel.Text = "2026-01-05 星期五";
            // 
            // minLabel
            // 
            this.minLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.minLabel.Location = new System.Drawing.Point(700, 3);
            this.minLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(32, 29);
            this.minLabel.Symbol = 61544;
            this.minLabel.SymbolColor = System.Drawing.SystemColors.ActiveCaption;
            this.minLabel.TabIndex = 1;
            // 
            // closeLabel
            // 
            this.closeLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.closeLabel.Location = new System.Drawing.Point(756, 4);
            this.closeLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(32, 29);
            this.closeLabel.Symbol = 61453;
            this.closeLabel.SymbolColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeLabel.TabIndex = 3;
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topPanel.BackgroundImage")));
            this.topPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topPanel.Controls.Add(this.closeLabel);
            this.topPanel.Controls.Add(this.minLabel);
            this.topPanel.Controls.Add(this.nowDateLabel);
            this.topPanel.Controls.Add(this.timeLabel);
            this.topPanel.Controls.Add(this.uiLabel1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Font = new System.Drawing.Font("宋体", 12F);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.topPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.topPanel.Name = "topPanel";
            this.topPanel.RectColor = System.Drawing.Color.Transparent;
            this.topPanel.Size = new System.Drawing.Size(800, 58);
            this.topPanel.TabIndex = 3;
            this.topPanel.Text = null;
            this.topPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Controls.Add(this.uiLabel4);
            this.uiPanel1.Controls.Add(this.uiLabel3);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(4, 5);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Size = new System.Drawing.Size(152, 49);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.ForeColor = System.Drawing.Color.Red;
            this.uiLabel4.Location = new System.Drawing.Point(86, 16);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(44, 17);
            this.uiLabel4.TabIndex = 3;
            this.uiLabel4.Text = "未连接";
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.uiLabel3.Location = new System.Drawing.Point(16, 16);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(35, 17);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "状态:";
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(96)))), ((int)(((byte)(133)))));
            this.uiSymbolButton1.Font = new System.Drawing.Font("宋体", 9.5F);
            this.uiSymbolButton1.ForeHoverColor = System.Drawing.Color.Orange;
            this.uiSymbolButton1.Location = new System.Drawing.Point(163, 3);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(154, 53);
            this.uiSymbolButton1.Symbol = 61819;
            this.uiSymbolButton1.SymbolDisableColor = System.Drawing.Color.Orange;
            this.uiSymbolButton1.TabIndex = 2;
            this.uiSymbolButton1.Text = "设备监控";
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSymbolButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(96)))), ((int)(((byte)(133)))));
            this.uiSymbolButton2.Font = new System.Drawing.Font("宋体", 9.5F);
            this.uiSymbolButton2.ForeHoverColor = System.Drawing.Color.Orange;
            this.uiSymbolButton2.Location = new System.Drawing.Point(323, 3);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Size = new System.Drawing.Size(154, 53);
            this.uiSymbolButton2.Symbol = 61459;
            this.uiSymbolButton2.SymbolDisableColor = System.Drawing.Color.Orange;
            this.uiSymbolButton2.TabIndex = 3;
            this.uiSymbolButton2.Text = "系统设置";
            this.uiSymbolButton2.Click += new System.EventHandler(this.uiSymbolButton2_Click);
            // 
            // uiSymbolButton3
            // 
            this.uiSymbolButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSymbolButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(96)))), ((int)(((byte)(133)))));
            this.uiSymbolButton3.Font = new System.Drawing.Font("宋体", 9.5F);
            this.uiSymbolButton3.ForeHoverColor = System.Drawing.Color.Orange;
            this.uiSymbolButton3.Location = new System.Drawing.Point(483, 3);
            this.uiSymbolButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton3.Name = "uiSymbolButton3";
            this.uiSymbolButton3.Size = new System.Drawing.Size(154, 53);
            this.uiSymbolButton3.Symbol = 557347;
            this.uiSymbolButton3.SymbolDisableColor = System.Drawing.Color.Orange;
            this.uiSymbolButton3.TabIndex = 4;
            this.uiSymbolButton3.Text = "预警管理";
            // 
            // uiPanel2
            // 
            this.uiPanel2.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel2.Controls.Add(this.uiLabel5);
            this.uiPanel2.Controls.Add(this.uiLabel6);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel2.Font = new System.Drawing.Font("宋体", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(644, 5);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel2.Size = new System.Drawing.Size(152, 49);
            this.uiPanel2.TabIndex = 5;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.ForeColor = System.Drawing.Color.Yellow;
            this.uiLabel5.Location = new System.Drawing.Point(86, 16);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(47, 17);
            this.uiLabel5.TabIndex = 3;
            this.uiLabel5.Text = "admin";
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLabel6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.uiLabel6.Location = new System.Drawing.Point(16, 16);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(35, 17);
            this.uiLabel6.TabIndex = 2;
            this.uiLabel6.Text = "用户:";
            // 
            // buttonLayoutPanel
            // 
            this.buttonLayoutPanel.ColumnCount = 5;
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonLayoutPanel.Controls.Add(this.uiPanel2, 4, 0);
            this.buttonLayoutPanel.Controls.Add(this.uiSymbolButton3, 3, 0);
            this.buttonLayoutPanel.Controls.Add(this.uiSymbolButton2, 2, 0);
            this.buttonLayoutPanel.Controls.Add(this.uiSymbolButton1, 1, 0);
            this.buttonLayoutPanel.Controls.Add(this.uiPanel1, 0, 0);
            this.buttonLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLayoutPanel.Location = new System.Drawing.Point(0, 541);
            this.buttonLayoutPanel.Name = "buttonLayoutPanel";
            this.buttonLayoutPanel.RowCount = 1;
            this.buttonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonLayoutPanel.Size = new System.Drawing.Size(800, 59);
            this.buttonLayoutPanel.TabIndex = 4;
            this.buttonLayoutPanel.TagString = null;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(90)))));
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.SkyBlue;
            this.uiLabel2.Location = new System.Drawing.Point(1, 56);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(796, 24);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "警报查询条件";
            this.uiLabel2.Click += new System.EventHandler(this.uiLabel2_Click);
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel7.ForeColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Location = new System.Drawing.Point(31, 98);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(64, 24);
            this.uiLabel7.TabIndex = 1;
            this.uiLabel7.Text = "警报类型:";
            // 
            // uiRadioButton1
            // 
            this.uiRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiRadioButton1.ForeColor = System.Drawing.Color.White;
            this.uiRadioButton1.Location = new System.Drawing.Point(93, 93);
            this.uiRadioButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton1.Name = "uiRadioButton1";
            this.uiRadioButton1.Size = new System.Drawing.Size(82, 29);
            this.uiRadioButton1.TabIndex = 5;
            this.uiRadioButton1.Text = "实时警报";
            // 
            // uiRadioButton2
            // 
            this.uiRadioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiRadioButton2.ForeColor = System.Drawing.Color.White;
            this.uiRadioButton2.Location = new System.Drawing.Point(181, 93);
            this.uiRadioButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton2.Name = "uiRadioButton2";
            this.uiRadioButton2.Size = new System.Drawing.Size(82, 29);
            this.uiRadioButton2.TabIndex = 5;
            this.uiRadioButton2.Text = "历史警报";
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel8.ForeColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Location = new System.Drawing.Point(306, 98);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(68, 24);
            this.uiLabel8.TabIndex = 1;
            this.uiLabel8.Text = "警报类型:";
            // 
            // chkHigh
            // 
            this.chkHigh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHigh.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHigh.ForeColor = System.Drawing.Color.White;
            this.chkHigh.Location = new System.Drawing.Point(376, 93);
            this.chkHigh.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkHigh.Name = "chkHigh";
            this.chkHigh.Size = new System.Drawing.Size(81, 29);
            this.chkHigh.TabIndex = 6;
            this.chkHigh.Text = "高值异常";
            // 
            // chkLow
            // 
            this.chkLow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkLow.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLow.ForeColor = System.Drawing.Color.White;
            this.chkLow.Location = new System.Drawing.Point(463, 93);
            this.chkLow.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkLow.Name = "chkLow";
            this.chkLow.Size = new System.Drawing.Size(81, 29);
            this.chkLow.TabIndex = 6;
            this.chkLow.Text = "低值异常";
            // 
            // chkCancelHigh
            // 
            this.chkCancelHigh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkCancelHigh.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCancelHigh.ForeColor = System.Drawing.Color.White;
            this.chkCancelHigh.Location = new System.Drawing.Point(550, 93);
            this.chkCancelHigh.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkCancelHigh.Name = "chkCancelHigh";
            this.chkCancelHigh.Size = new System.Drawing.Size(102, 29);
            this.chkCancelHigh.TabIndex = 6;
            this.chkCancelHigh.Text = "取消高值异常";
            // 
            // chkCancelLow
            // 
            this.chkCancelLow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkCancelLow.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCancelLow.ForeColor = System.Drawing.Color.White;
            this.chkCancelLow.Location = new System.Drawing.Point(657, 93);
            this.chkCancelLow.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkCancelLow.Name = "chkCancelLow";
            this.chkCancelLow.Size = new System.Drawing.Size(111, 29);
            this.chkCancelLow.TabIndex = 6;
            this.chkCancelLow.Text = "取消低值异常";
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel9.ForeColor = System.Drawing.Color.Transparent;
            this.uiLabel9.Location = new System.Drawing.Point(31, 146);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(64, 24);
            this.uiLabel9.TabIndex = 1;
            this.uiLabel9.Text = "警报来源:";
            // 
            // cmbSource
            // 
            this.cmbSource.DataSource = null;
            this.cmbSource.FillColor = System.Drawing.Color.White;
            this.cmbSource.Font = new System.Drawing.Font("宋体", 12F);
            this.cmbSource.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cmbSource.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cmbSource.Location = new System.Drawing.Point(102, 142);
            this.cmbSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSource.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbSource.Size = new System.Drawing.Size(120, 24);
            this.cmbSource.SymbolSize = 24;
            this.cmbSource.TabIndex = 7;
            this.cmbSource.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbSource.Watermark = "";
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel10.ForeColor = System.Drawing.Color.Transparent;
            this.uiLabel10.Location = new System.Drawing.Point(306, 146);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(64, 24);
            this.uiLabel10.TabIndex = 1;
            this.uiLabel10.Text = "查询时间:";
            // 
            // dtpStart
            // 
            this.dtpStart.DateCultureInfo = new System.Globalization.CultureInfo("zh-CN");
            this.dtpStart.FillColor = System.Drawing.Color.White;
            this.dtpStart.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Location = new System.Drawing.Point(377, 142);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpStart.MaxLength = 19;
            this.dtpStart.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpStart.Size = new System.Drawing.Size(141, 24);
            this.dtpStart.SymbolDropDown = 61555;
            this.dtpStart.SymbolNormal = 61555;
            this.dtpStart.SymbolSize = 24;
            this.dtpStart.TabIndex = 8;
            this.dtpStart.Text = "2026-07-24 11:09:16";
            this.dtpStart.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpStart.Value = new System.DateTime(2026, 7, 24, 11, 9, 16, 418);
            this.dtpStart.Watermark = "";
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel11.ForeColor = System.Drawing.Color.Transparent;
            this.uiLabel11.Location = new System.Drawing.Point(525, 142);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(19, 24);
            this.uiLabel11.TabIndex = 1;
            this.uiLabel11.Text = "-";
            // 
            // dtpEnd
            // 
            this.dtpEnd.DateCultureInfo = new System.Globalization.CultureInfo("zh-CN");
            this.dtpEnd.FillColor = System.Drawing.Color.White;
            this.dtpEnd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Location = new System.Drawing.Point(550, 142);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpEnd.MaxLength = 19;
            this.dtpEnd.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpEnd.Size = new System.Drawing.Size(141, 24);
            this.dtpEnd.SymbolDropDown = 61555;
            this.dtpEnd.SymbolNormal = 61555;
            this.dtpEnd.SymbolSize = 24;
            this.dtpEnd.TabIndex = 8;
            this.dtpEnd.Text = "2026-07-24 11:09:16";
            this.dtpEnd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpEnd.Value = new System.DateTime(2026, 7, 24, 11, 9, 16, 418);
            this.dtpEnd.Watermark = "";
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiButton1.Location = new System.Drawing.Point(702, 142);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(55, 25);
            this.uiButton1.TabIndex = 1;
            this.uiButton1.Text = "查询";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiLabel12
            // 
            this.uiLabel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(90)))));
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel12.ForeColor = System.Drawing.Color.SkyBlue;
            this.uiLabel12.Location = new System.Drawing.Point(1, 178);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(796, 24);
            this.uiLabel12.TabIndex = 1;
            this.uiLabel12.Text = "实时数据";
            this.uiLabel12.Click += new System.EventHandler(this.uiLabel2_Click);
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(98)))), ((int)(((byte)(133)))));
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView1.ColumnHeadersHeight = 32;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.alarmTime,
            this.infoType,
            this.alarmType,
            this.alarmState,
            this.alarmValue,
            this.alarmNote});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(0, 205);
            this.uiDataGridView1.Name = "uiDataGridView1";
            this.uiDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F);
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uiDataGridView1.RowTemplate.Height = 23;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.Size = new System.Drawing.Size(800, 287);
            this.uiDataGridView1.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.TabIndex = 9;
            this.uiDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "编号";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // alarmTime
            // 
            this.alarmTime.DataPropertyName = "alarmTime";
            this.alarmTime.HeaderText = "警报时间";
            this.alarmTime.Name = "alarmTime";
            // 
            // infoType
            // 
            this.infoType.DataPropertyName = "infoType";
            this.infoType.HeaderText = "警报来源";
            this.infoType.Name = "infoType";
            this.infoType.Width = 110;
            // 
            // alarmType
            // 
            this.alarmType.DataPropertyName = "alarmType";
            this.alarmType.HeaderText = "警报类型";
            this.alarmType.Name = "alarmType";
            // 
            // alarmState
            // 
            this.alarmState.DataPropertyName = "alarmState";
            this.alarmState.HeaderText = "警报状态";
            this.alarmState.Name = "alarmState";
            // 
            // alarmValue
            // 
            this.alarmValue.DataPropertyName = "alarmValue";
            this.alarmValue.HeaderText = "警报值";
            this.alarmValue.Name = "alarmValue";
            // 
            // alarmNote
            // 
            this.alarmNote.DataPropertyName = "alarmNote";
            this.alarmNote.HeaderText = "警报描述";
            this.alarmNote.Name = "alarmNote";
            this.alarmNote.Width = 200;
            // 
            // uiPagination1
            // 
            this.uiPagination1.ButtonFillColor = System.Drawing.Color.SteelBlue;
            this.uiPagination1.ButtonFillSelectedColor = System.Drawing.Color.LightSeaGreen;
            this.uiPagination1.ButtonStyleInherited = false;
            this.uiPagination1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(55)))), ((int)(((byte)(88)))));
            this.uiPagination1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(55)))), ((int)(((byte)(88)))));
            this.uiPagination1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPagination1.Location = new System.Drawing.Point(5, 500);
            this.uiPagination1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPagination1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPagination1.Name = "uiPagination1";
            this.uiPagination1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPagination1.ShowText = false;
            this.uiPagination1.Size = new System.Drawing.Size(583, 36);
            this.uiPagination1.TabIndex = 10;
            this.uiPagination1.Text = "uiPagination1";
            this.uiPagination1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPagination1.PageChanged += new Sunny.UI.UIPagination.OnPageChangeEventHandler(this.uiPagination1_PageChanged);
            this.uiPagination1.Click += new System.EventHandler(this.uiPagination1_Click);
            this.uiPagination1.ParentChanged += new System.EventHandler(this.uiPagination1_ParentChanged);
            // 
            // FrmAlertQuery
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(55)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.uiPagination1);
            this.Controls.Add(this.uiDataGridView1);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.cmbSource);
            this.Controls.Add(this.chkCancelLow);
            this.Controls.Add(this.chkCancelHigh);
            this.Controls.Add(this.chkLow);
            this.Controls.Add(this.chkHigh);
            this.Controls.Add(this.uiRadioButton2);
            this.Controls.Add(this.uiRadioButton1);
            this.Controls.Add(this.buttonLayoutPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.uiLabel12);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiLabel11);
            this.Controls.Add(this.uiLabel10);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.uiLabel7);
            this.Name = "FrmAlertQuery";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Text = "FrmAlertQuery";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.FrmAlertQuery_Load);
            this.topPanel.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel2.PerformLayout();
            this.buttonLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel timeLabel;
        private Sunny.UI.UILabel nowDateLabel;
        private Sunny.UI.UISymbolLabel minLabel;
        private Sunny.UI.UISymbolLabel closeLabel;
        private Sunny.UI.UIPanel topPanel;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITableLayoutPanel buttonLayoutPanel;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIRadioButton uiRadioButton1;
        private Sunny.UI.UIRadioButton uiRadioButton2;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UICheckBox chkHigh;
        private Sunny.UI.UICheckBox chkLow;
        private Sunny.UI.UICheckBox chkCancelHigh;
        private Sunny.UI.UICheckBox chkCancelLow;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UIComboBox cmbSource;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UIDatetimePicker dtpStart;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UIDatetimePicker dtpEnd;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UIPagination uiPagination1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoType;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmState;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmNote;
    }
}