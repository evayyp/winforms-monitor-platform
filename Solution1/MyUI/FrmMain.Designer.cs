namespace MyUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.topPanel = new Sunny.UI.UIPanel();
            this.closeLabel = new Sunny.UI.UISymbolLabel();
            this.minLabel = new Sunny.UI.UISymbolLabel();
            this.nowDateLabel = new Sunny.UI.UILabel();
            this.timeLabel = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.buttonLayoutPanel = new Sunny.UI.UITableLayoutPanel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.mainPanel = new Sunny.UI.UIPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.topPanel.SuspendLayout();
            this.buttonLayoutPanel.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.topPanel.TabIndex = 0;
            this.topPanel.Text = null;
            this.topPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.topPanel.Click += new System.EventHandler(this.topPanel_Click);
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
            this.minLabel.Click += new System.EventHandler(this.minLabel_Click);
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
            this.nowDateLabel.Click += new System.EventHandler(this.nowDateLabel_Click);
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
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
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
            this.uiLabel1.Click += new System.EventHandler(this.uiLabel1_Click);
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
            this.buttonLayoutPanel.Size = new System.Drawing.Size(800, 59);
            this.buttonLayoutPanel.TabIndex = 1;
            this.buttonLayoutPanel.TagString = null;
            this.buttonLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonLayoutPanel_Paint);
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
            this.uiPanel2.Click += new System.EventHandler(this.uiPanel2_Click);
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
            this.uiLabel5.Click += new System.EventHandler(this.uiLabel5_Click);
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
            this.uiLabel6.Click += new System.EventHandler(this.uiLabel6_Click);
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
            this.uiSymbolButton2.Click += new System.EventHandler(this.uiSymbolButton2_Click);
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
            this.uiPanel1.Click += new System.EventHandler(this.uiPanel1_Click);
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
            this.uiLabel4.Click += new System.EventHandler(this.uiLabel4_Click);
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
            this.uiLabel3.Click += new System.EventHandler(this.uiLabel3_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FillColor = System.Drawing.Color.Transparent;
            this.mainPanel.Font = new System.Drawing.Font("宋体", 12F);
            this.mainPanel.Location = new System.Drawing.Point(0, 58);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 483);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Text = null;
            this.mainPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainPanel.Click += new System.EventHandler(this.mainPanel_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMain
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(55)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.buttonLayoutPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Text = "FrmMain";
            this.ZoomScaleRect = new System.Drawing.Rectangle(30, 30, 800, 450);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.topPanel.ResumeLayout(false);
            this.buttonLayoutPanel.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel2.PerformLayout();
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel topPanel;
        private Sunny.UI.UILabel nowDateLabel;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel timeLabel;
        private Sunny.UI.UISymbolLabel closeLabel;
        private Sunny.UI.UISymbolLabel minLabel;
        private Sunny.UI.UITableLayoutPanel buttonLayoutPanel;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIPanel mainPanel;
        private System.Windows.Forms.Timer timer1;
    }
}