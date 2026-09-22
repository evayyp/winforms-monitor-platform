namespace MyUI
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btn_register = new Sunny.UI.UIButton();
            this.btn_backlogin = new Sunny.UI.UIButton();
            this.txtPassword = new Sunny.UI.UITextBox();
            this.txtUsername = new Sunny.UI.UITextBox();
            this.txtConfirmPwd = new Sunny.UI.UITextBox();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Controls.Add(this.btn_register);
            this.uiPanel1.Controls.Add(this.btn_backlogin);
            this.uiPanel1.Controls.Add(this.txtConfirmPwd);
            this.uiPanel1.Controls.Add(this.txtPassword);
            this.uiPanel1.Controls.Add(this.txtUsername);
            this.uiPanel1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(46, 49);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Opacity = ((byte)(80));
            this.uiPanel1.Size = new System.Drawing.Size(444, 349);
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_register
            // 
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.FillColor = System.Drawing.Color.Orange;
            this.btn_register.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(96, 263);
            this.btn_register.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(79, 30);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "注册";
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_backlogin
            // 
            this.btn_backlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_backlogin.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backlogin.Location = new System.Drawing.Point(269, 263);
            this.btn_backlogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_backlogin.Name = "btn_backlogin";
            this.btn_backlogin.Size = new System.Drawing.Size(79, 30);
            this.btn_backlogin.TabIndex = 3;
            this.btn_backlogin.Text = "返回登录";
            this.btn_backlogin.Click += new System.EventHandler(this.btn_backlogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(96, 129);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ShowText = false;
            this.txtPassword.Size = new System.Drawing.Size(252, 36);
            this.txtPassword.Symbol = 61475;
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPassword.Watermark = "请输入密码";
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(96, 65);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(5);
            this.txtUsername.ShowText = false;
            this.txtUsername.Size = new System.Drawing.Size(252, 35);
            this.txtUsername.Symbol = 61447;
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtUsername.Watermark = "请输入用户名";
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPwd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPwd.Location = new System.Drawing.Point(96, 191);
            this.txtConfirmPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirmPwd.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.Padding = new System.Windows.Forms.Padding(5);
            this.txtConfirmPwd.PasswordChar = '*';
            this.txtConfirmPwd.ShowText = false;
            this.txtConfirmPwd.Size = new System.Drawing.Size(252, 36);
            this.txtConfirmPwd.Symbol = 61475;
            this.txtConfirmPwd.TabIndex = 1;
            this.txtConfirmPwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtConfirmPwd.Watermark = "请确认密码";
            // 
            // Register
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(542, 452);
            this.Controls.Add(this.uiPanel1);
            this.Name = "Register";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Text = "Register";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.Register_Load);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton btn_register;
        private Sunny.UI.UIButton btn_backlogin;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UITextBox txtUsername;
        private Sunny.UI.UITextBox txtConfirmPwd;
    }
}