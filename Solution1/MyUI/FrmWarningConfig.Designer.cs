namespace MyUI
{
    partial class FrmWarningConfig
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
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiLabel22 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.txtTempLow = new Sunny.UI.UITextBox();
            this.numTempMin = new System.Windows.Forms.NumericUpDown();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.numTempMax = new System.Windows.Forms.NumericUpDown();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.numHumidMin = new System.Windows.Forms.NumericUpDown();
            this.numHumidMax = new System.Windows.Forms.NumericUpDown();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.uiLabel13 = new Sunny.UI.UILabel();
            this.numPressMin = new System.Windows.Forms.NumericUpDown();
            this.numPressMax = new System.Windows.Forms.NumericUpDown();
            this.txtTempNormal = new Sunny.UI.UITextBox();
            this.txtTempHigh = new Sunny.UI.UITextBox();
            this.txtHumidLow = new Sunny.UI.UITextBox();
            this.txtHumidNormal = new Sunny.UI.UITextBox();
            this.txtHumidHigh = new Sunny.UI.UITextBox();
            this.txtPressLow = new Sunny.UI.UITextBox();
            this.txtPressNormal = new Sunny.UI.UITextBox();
            this.txtPressHigh = new Sunny.UI.UITextBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.numTempMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHumidMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHumidMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPressMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPressMax)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(0, 3);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Size = new System.Drawing.Size(139, 29);
            this.uiSymbolLabel1.Symbol = 61518;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.TabIndex = 0;
            this.uiSymbolLabel1.Text = "预警配置";
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine1.LineColor = System.Drawing.Color.Gray;
            this.uiLine1.Location = new System.Drawing.Point(0, 30);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(800, 14);
            this.uiLine1.TabIndex = 7;
            // 
            // uiLabel22
            // 
            this.uiLabel22.AutoSize = true;
            this.uiLabel22.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel22.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel22.ForeColor = System.Drawing.Color.Silver;
            this.uiLabel22.Location = new System.Drawing.Point(48, 56);
            this.uiLabel22.Name = "uiLabel22";
            this.uiLabel22.Size = new System.Drawing.Size(128, 17);
            this.uiLabel22.TabIndex = 8;
            this.uiLabel22.Text = "实时数据预警范围设置";
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(93, 88);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(83, 17);
            this.uiLabel1.TabIndex = 9;
            this.uiLabel1.Text = "温度阈值范围:";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.White;
            this.uiLabel2.Location = new System.Drawing.Point(93, 122);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(83, 17);
            this.uiLabel2.TabIndex = 9;
            this.uiLabel2.Text = "湿度阈值范围:";
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.White;
            this.uiLabel3.Location = new System.Drawing.Point(93, 159);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(83, 17);
            this.uiLabel3.TabIndex = 9;
            this.uiLabel3.Text = "压力阈值范围:";
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.ForeColor = System.Drawing.Color.Silver;
            this.uiLabel4.Location = new System.Drawing.Point(48, 201);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(80, 17);
            this.uiLabel4.TabIndex = 8;
            this.uiLabel4.Text = "等级名称设置";
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.ForeColor = System.Drawing.Color.White;
            this.uiLabel5.Location = new System.Drawing.Point(117, 235);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(59, 17);
            this.uiLabel5.TabIndex = 9;
            this.uiLabel5.Text = "温度等级:";
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.ForeColor = System.Drawing.Color.White;
            this.uiLabel6.Location = new System.Drawing.Point(117, 271);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(59, 17);
            this.uiLabel6.TabIndex = 9;
            this.uiLabel6.Text = "湿度等级:";
            // 
            // uiLabel7
            // 
            this.uiLabel7.AutoSize = true;
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel7.ForeColor = System.Drawing.Color.White;
            this.uiLabel7.Location = new System.Drawing.Point(117, 308);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(59, 17);
            this.uiLabel7.TabIndex = 9;
            this.uiLabel7.Text = "压力等级:";
            // 
            // txtTempLow
            // 
            this.txtTempLow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTempLow.Font = new System.Drawing.Font("宋体", 12F);
            this.txtTempLow.Location = new System.Drawing.Point(192, 230);
            this.txtTempLow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTempLow.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTempLow.Name = "txtTempLow";
            this.txtTempLow.Padding = new System.Windows.Forms.Padding(5);
            this.txtTempLow.RectColor = System.Drawing.Color.Transparent;
            this.txtTempLow.ShowText = false;
            this.txtTempLow.Size = new System.Drawing.Size(62, 22);
            this.txtTempLow.TabIndex = 10;
            this.txtTempLow.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTempLow.Watermark = "";
            // 
            // numTempMin
            // 
            this.numTempMin.Location = new System.Drawing.Point(192, 84);
            this.numTempMin.Name = "numTempMin";
            this.numTempMin.Size = new System.Drawing.Size(62, 21);
            this.numTempMin.TabIndex = 3;
            // 
            // uiLabel8
            // 
            this.uiLabel8.AutoSize = true;
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel8.ForeColor = System.Drawing.Color.White;
            this.uiLabel8.Location = new System.Drawing.Point(260, 86);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(17, 17);
            this.uiLabel8.TabIndex = 9;
            this.uiLabel8.Text = "~";
            // 
            // numTempMax
            // 
            this.numTempMax.Location = new System.Drawing.Point(283, 84);
            this.numTempMax.Name = "numTempMax";
            this.numTempMax.Size = new System.Drawing.Size(62, 21);
            this.numTempMax.TabIndex = 3;
            // 
            // uiLabel9
            // 
            this.uiLabel9.AutoSize = true;
            this.uiLabel9.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel9.ForeColor = System.Drawing.Color.White;
            this.uiLabel9.Location = new System.Drawing.Point(351, 86);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(20, 17);
            this.uiLabel9.TabIndex = 9;
            this.uiLabel9.Text = "℃";
            // 
            // uiLabel10
            // 
            this.uiLabel10.AutoSize = true;
            this.uiLabel10.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel10.ForeColor = System.Drawing.Color.White;
            this.uiLabel10.Location = new System.Drawing.Point(260, 120);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(17, 17);
            this.uiLabel10.TabIndex = 9;
            this.uiLabel10.Text = "~";
            // 
            // uiLabel11
            // 
            this.uiLabel11.AutoSize = true;
            this.uiLabel11.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel11.ForeColor = System.Drawing.Color.White;
            this.uiLabel11.Location = new System.Drawing.Point(351, 120);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(19, 17);
            this.uiLabel11.TabIndex = 9;
            this.uiLabel11.Text = "%";
            // 
            // numHumidMin
            // 
            this.numHumidMin.Location = new System.Drawing.Point(192, 118);
            this.numHumidMin.Name = "numHumidMin";
            this.numHumidMin.Size = new System.Drawing.Size(62, 21);
            this.numHumidMin.TabIndex = 3;
            // 
            // numHumidMax
            // 
            this.numHumidMax.Location = new System.Drawing.Point(283, 118);
            this.numHumidMax.Name = "numHumidMax";
            this.numHumidMax.Size = new System.Drawing.Size(62, 21);
            this.numHumidMax.TabIndex = 3;
            // 
            // uiLabel12
            // 
            this.uiLabel12.AutoSize = true;
            this.uiLabel12.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel12.ForeColor = System.Drawing.Color.White;
            this.uiLabel12.Location = new System.Drawing.Point(260, 157);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(17, 17);
            this.uiLabel12.TabIndex = 9;
            this.uiLabel12.Text = "~";
            // 
            // uiLabel13
            // 
            this.uiLabel13.AutoSize = true;
            this.uiLabel13.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel13.ForeColor = System.Drawing.Color.White;
            this.uiLabel13.Location = new System.Drawing.Point(351, 157);
            this.uiLabel13.Name = "uiLabel13";
            this.uiLabel13.Size = new System.Drawing.Size(34, 17);
            this.uiLabel13.TabIndex = 9;
            this.uiLabel13.Text = "MPa";
            // 
            // numPressMin
            // 
            this.numPressMin.Location = new System.Drawing.Point(192, 155);
            this.numPressMin.Name = "numPressMin";
            this.numPressMin.Size = new System.Drawing.Size(62, 21);
            this.numPressMin.TabIndex = 3;
            // 
            // numPressMax
            // 
            this.numPressMax.Location = new System.Drawing.Point(283, 155);
            this.numPressMax.Name = "numPressMax";
            this.numPressMax.Size = new System.Drawing.Size(62, 21);
            this.numPressMax.TabIndex = 3;
            // 
            // txtTempNormal
            // 
            this.txtTempNormal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTempNormal.Font = new System.Drawing.Font("宋体", 12F);
            this.txtTempNormal.Location = new System.Drawing.Point(283, 230);
            this.txtTempNormal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTempNormal.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTempNormal.Name = "txtTempNormal";
            this.txtTempNormal.Padding = new System.Windows.Forms.Padding(5);
            this.txtTempNormal.RectColor = System.Drawing.Color.Transparent;
            this.txtTempNormal.ShowText = false;
            this.txtTempNormal.Size = new System.Drawing.Size(62, 22);
            this.txtTempNormal.TabIndex = 10;
            this.txtTempNormal.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTempNormal.Watermark = "";
            // 
            // txtTempHigh
            // 
            this.txtTempHigh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTempHigh.Font = new System.Drawing.Font("宋体", 12F);
            this.txtTempHigh.Location = new System.Drawing.Point(372, 230);
            this.txtTempHigh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTempHigh.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTempHigh.Name = "txtTempHigh";
            this.txtTempHigh.Padding = new System.Windows.Forms.Padding(5);
            this.txtTempHigh.RectColor = System.Drawing.Color.Transparent;
            this.txtTempHigh.ShowText = false;
            this.txtTempHigh.Size = new System.Drawing.Size(62, 22);
            this.txtTempHigh.TabIndex = 10;
            this.txtTempHigh.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTempHigh.Watermark = "";
            // 
            // txtHumidLow
            // 
            this.txtHumidLow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHumidLow.Font = new System.Drawing.Font("宋体", 12F);
            this.txtHumidLow.Location = new System.Drawing.Point(192, 266);
            this.txtHumidLow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHumidLow.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtHumidLow.Name = "txtHumidLow";
            this.txtHumidLow.Padding = new System.Windows.Forms.Padding(5);
            this.txtHumidLow.RectColor = System.Drawing.Color.Transparent;
            this.txtHumidLow.ShowText = false;
            this.txtHumidLow.Size = new System.Drawing.Size(62, 22);
            this.txtHumidLow.TabIndex = 10;
            this.txtHumidLow.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtHumidLow.Watermark = "";
            // 
            // txtHumidNormal
            // 
            this.txtHumidNormal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHumidNormal.Font = new System.Drawing.Font("宋体", 12F);
            this.txtHumidNormal.Location = new System.Drawing.Point(283, 266);
            this.txtHumidNormal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHumidNormal.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtHumidNormal.Name = "txtHumidNormal";
            this.txtHumidNormal.Padding = new System.Windows.Forms.Padding(5);
            this.txtHumidNormal.RectColor = System.Drawing.Color.Transparent;
            this.txtHumidNormal.ShowText = false;
            this.txtHumidNormal.Size = new System.Drawing.Size(62, 22);
            this.txtHumidNormal.TabIndex = 10;
            this.txtHumidNormal.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtHumidNormal.Watermark = "";
            // 
            // txtHumidHigh
            // 
            this.txtHumidHigh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHumidHigh.Font = new System.Drawing.Font("宋体", 12F);
            this.txtHumidHigh.Location = new System.Drawing.Point(372, 266);
            this.txtHumidHigh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHumidHigh.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtHumidHigh.Name = "txtHumidHigh";
            this.txtHumidHigh.Padding = new System.Windows.Forms.Padding(5);
            this.txtHumidHigh.RectColor = System.Drawing.Color.Transparent;
            this.txtHumidHigh.ShowText = false;
            this.txtHumidHigh.Size = new System.Drawing.Size(62, 22);
            this.txtHumidHigh.TabIndex = 10;
            this.txtHumidHigh.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtHumidHigh.Watermark = "";
            // 
            // txtPressLow
            // 
            this.txtPressLow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPressLow.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPressLow.Location = new System.Drawing.Point(192, 303);
            this.txtPressLow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPressLow.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPressLow.Name = "txtPressLow";
            this.txtPressLow.Padding = new System.Windows.Forms.Padding(5);
            this.txtPressLow.RectColor = System.Drawing.Color.Transparent;
            this.txtPressLow.ShowText = false;
            this.txtPressLow.Size = new System.Drawing.Size(62, 22);
            this.txtPressLow.TabIndex = 10;
            this.txtPressLow.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPressLow.Watermark = "";
            // 
            // txtPressNormal
            // 
            this.txtPressNormal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPressNormal.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPressNormal.Location = new System.Drawing.Point(283, 303);
            this.txtPressNormal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPressNormal.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPressNormal.Name = "txtPressNormal";
            this.txtPressNormal.Padding = new System.Windows.Forms.Padding(5);
            this.txtPressNormal.RectColor = System.Drawing.Color.Transparent;
            this.txtPressNormal.ShowText = false;
            this.txtPressNormal.Size = new System.Drawing.Size(62, 22);
            this.txtPressNormal.TabIndex = 10;
            this.txtPressNormal.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPressNormal.Watermark = "";
            // 
            // txtPressHigh
            // 
            this.txtPressHigh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPressHigh.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPressHigh.Location = new System.Drawing.Point(372, 303);
            this.txtPressHigh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPressHigh.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPressHigh.Name = "txtPressHigh";
            this.txtPressHigh.Padding = new System.Windows.Forms.Padding(5);
            this.txtPressHigh.RectColor = System.Drawing.Color.Transparent;
            this.txtPressHigh.ShowText = false;
            this.txtPressHigh.Size = new System.Drawing.Size(62, 22);
            this.txtPressHigh.TabIndex = 10;
            this.txtPressHigh.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPressHigh.Watermark = "";
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton1.Location = new System.Drawing.Point(120, 352);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(75, 29);
            this.uiButton1.TabIndex = 11;
            this.uiButton1.Text = "确定";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // FrmWarningConfig
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(55)))), ((int)(((byte)(88)))));
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.numPressMax);
            this.Controls.Add(this.numHumidMax);
            this.Controls.Add(this.numTempMax);
            this.Controls.Add(this.numPressMin);
            this.Controls.Add(this.numHumidMin);
            this.Controls.Add(this.numTempMin);
            this.Controls.Add(this.txtPressHigh);
            this.Controls.Add(this.txtHumidHigh);
            this.Controls.Add(this.txtTempHigh);
            this.Controls.Add(this.txtPressNormal);
            this.Controls.Add(this.txtHumidNormal);
            this.Controls.Add(this.txtTempNormal);
            this.Controls.Add(this.txtPressLow);
            this.Controls.Add(this.txtHumidLow);
            this.Controls.Add(this.txtTempLow);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel13);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel11);
            this.Controls.Add(this.uiLabel12);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel10);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel22);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmWarningConfig";
            this.Size = new System.Drawing.Size(800, 410);
            this.Load += new System.EventHandler(this.FrmWarningConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTempMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHumidMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHumidMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPressMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPressMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILabel uiLabel22;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox txtTempLow;
        private System.Windows.Forms.NumericUpDown numTempMin;
        private Sunny.UI.UILabel uiLabel8;
        private System.Windows.Forms.NumericUpDown numTempMax;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel11;
        private System.Windows.Forms.NumericUpDown numHumidMin;
        private System.Windows.Forms.NumericUpDown numHumidMax;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UILabel uiLabel13;
        private System.Windows.Forms.NumericUpDown numPressMin;
        private System.Windows.Forms.NumericUpDown numPressMax;
        private Sunny.UI.UITextBox txtTempNormal;
        private Sunny.UI.UITextBox txtTempHigh;
        private Sunny.UI.UITextBox txtHumidLow;
        private Sunny.UI.UITextBox txtHumidNormal;
        private Sunny.UI.UITextBox txtHumidHigh;
        private Sunny.UI.UITextBox txtPressLow;
        private Sunny.UI.UITextBox txtPressNormal;
        private Sunny.UI.UITextBox txtPressHigh;
        private Sunny.UI.UIButton uiButton1;
    }
}
