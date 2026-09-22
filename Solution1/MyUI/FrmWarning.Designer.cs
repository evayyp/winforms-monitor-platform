namespace MyUI
{
    partial class FrmWarning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWarning));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.buttonLayoutPanel = new Sunny.UI.UITableLayoutPanel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.closeLabel = new Sunny.UI.UISymbolLabel();
            this.minLabel = new Sunny.UI.UISymbolLabel();
            this.nowDateLabel = new Sunny.UI.UILabel();
            this.timeLabel = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.topPanel = new Sunny.UI.UIPanel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiLine2 = new Sunny.UI.UILine();
            this.mainPanel = new Sunny.UI.UIPanel();
            this.btnWarning = new Sunny.UI.UIButton();
            this.btnCommunication = new Sunny.UI.UIButton();
            this.btnParameter = new Sunny.UI.UIButton();
            this.btnStorage = new Sunny.UI.UIButton();
            this.btnSystem = new Sunny.UI.UIButton();
            this.uiPanel1.SuspendLayout();
            this.buttonLayoutPanel.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.uiSymbolButton3.Click += new System.EventHandler(this.uiSymbolButton3_Click);
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
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Location = new System.Drawing.Point(327, 9);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(165, 24);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "实训2班智能设备监控平台";
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
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine1.LineColor = System.Drawing.Color.Gray;
            this.uiLine1.Location = new System.Drawing.Point(0, 53);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(800, 14);
            this.uiLine1.TabIndex = 6;
            // 
            // uiLine2
            // 
            this.uiLine2.BackColor = System.Drawing.Color.Transparent;
            this.uiLine2.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine2.LineColor = System.Drawing.Color.Gray;
            this.uiLine2.Location = new System.Drawing.Point(4, 109);
            this.uiLine2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(800, 14);
            this.uiLine2.TabIndex = 6;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.FillColor = System.Drawing.Color.Transparent;
            this.mainPanel.Font = new System.Drawing.Font("宋体", 12F);
            this.mainPanel.Location = new System.Drawing.Point(0, 131);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 410);
            this.mainPanel.TabIndex = 7;
            this.mainPanel.Text = null;
            this.mainPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainPanel.Click += new System.EventHandler(this.mainPanel_Click);
            // 
            // btnWarning
            // 
            this.btnWarning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWarning.FillColor = System.Drawing.Color.Silver;
            this.btnWarning.FillColor2 = System.Drawing.Color.Gray;
            this.btnWarning.FillColorGradient = true;
            this.btnWarning.FillColorGradientDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.btnWarning.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnWarning.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnWarning.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWarning.Location = new System.Drawing.Point(112, 71);
            this.btnWarning.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnWarning.Name = "btnWarning";
            this.btnWarning.RectColor = System.Drawing.Color.Gray;
            this.btnWarning.Size = new System.Drawing.Size(100, 35);
            this.btnWarning.TabIndex = 0;
            this.btnWarning.Text = "预警配置";
            this.btnWarning.TipsFont = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWarning.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // btnCommunication
            // 
            this.btnCommunication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCommunication.FillColor = System.Drawing.Color.Silver;
            this.btnCommunication.FillColor2 = System.Drawing.Color.Gray;
            this.btnCommunication.FillColorGradient = true;
            this.btnCommunication.FillColorGradientDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.btnCommunication.FillDisableColor = System.Drawing.Color.Gray;
            this.btnCommunication.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnCommunication.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnCommunication.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommunication.Location = new System.Drawing.Point(241, 71);
            this.btnCommunication.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCommunication.Name = "btnCommunication";
            this.btnCommunication.RectColor = System.Drawing.Color.Gray;
            this.btnCommunication.Size = new System.Drawing.Size(100, 35);
            this.btnCommunication.TabIndex = 0;
            this.btnCommunication.Text = "通信配置";
            this.btnCommunication.TipsFont = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommunication.Click += new System.EventHandler(this.btnCommunication_Click);
            // 
            // btnParameter
            // 
            this.btnParameter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParameter.FillColor = System.Drawing.Color.Silver;
            this.btnParameter.FillColor2 = System.Drawing.Color.Gray;
            this.btnParameter.FillColorGradient = true;
            this.btnParameter.FillColorGradientDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.btnParameter.FillDisableColor = System.Drawing.Color.Gray;
            this.btnParameter.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnParameter.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnParameter.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParameter.Location = new System.Drawing.Point(367, 71);
            this.btnParameter.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnParameter.Name = "btnParameter";
            this.btnParameter.RectColor = System.Drawing.Color.Gray;
            this.btnParameter.Size = new System.Drawing.Size(100, 35);
            this.btnParameter.TabIndex = 0;
            this.btnParameter.Text = "参数配置";
            this.btnParameter.TipsFont = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParameter.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // btnStorage
            // 
            this.btnStorage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStorage.FillColor = System.Drawing.Color.Silver;
            this.btnStorage.FillColor2 = System.Drawing.Color.Gray;
            this.btnStorage.FillColorGradient = true;
            this.btnStorage.FillColorGradientDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.btnStorage.FillDisableColor = System.Drawing.Color.Gray;
            this.btnStorage.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnStorage.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnStorage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorage.Location = new System.Drawing.Point(493, 71);
            this.btnStorage.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.RectColor = System.Drawing.Color.Gray;
            this.btnStorage.Size = new System.Drawing.Size(100, 35);
            this.btnStorage.TabIndex = 0;
            this.btnStorage.Text = "存储配置";
            this.btnStorage.TipsFont = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorage.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // btnSystem
            // 
            this.btnSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSystem.FillColor = System.Drawing.Color.Silver;
            this.btnSystem.FillColor2 = System.Drawing.Color.Gray;
            this.btnSystem.FillColorGradient = true;
            this.btnSystem.FillColorGradientDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.btnSystem.FillDisableColor = System.Drawing.Color.Gray;
            this.btnSystem.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnSystem.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnSystem.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystem.Location = new System.Drawing.Point(619, 71);
            this.btnSystem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.RectColor = System.Drawing.Color.Gray;
            this.btnSystem.Size = new System.Drawing.Size(100, 35);
            this.btnSystem.TabIndex = 0;
            this.btnSystem.Text = "系统配置";
            this.btnSystem.TipsFont = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystem.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // FrmWarning
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(55)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnSystem);
            this.Controls.Add(this.btnStorage);
            this.Controls.Add(this.btnParameter);
            this.Controls.Add(this.btnCommunication);
            this.Controls.Add(this.btnWarning);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.buttonLayoutPanel);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.uiLine2);
            this.Name = "FrmWarning";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.RectColor = System.Drawing.Color.Transparent;
            this.ShowTitle = false;
            this.Text = "FrmWarningConfig";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 784, 561);
            this.Load += new System.EventHandler(this.FrmWarningConfig_Load);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            this.buttonLayoutPanel.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel2.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITableLayoutPanel buttonLayoutPanel;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UISymbolLabel closeLabel;
        private Sunny.UI.UISymbolLabel minLabel;
        private Sunny.UI.UILabel nowDateLabel;
        private Sunny.UI.UILabel timeLabel;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIPanel topPanel;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UIPanel mainPanel;
        private Sunny.UI.UIButton btnWarning;
        private Sunny.UI.UIButton btnCommunication;
        private Sunny.UI.UIButton btnParameter;
        private Sunny.UI.UIButton btnStorage;
        private Sunny.UI.UIButton btnSystem;
    }
}