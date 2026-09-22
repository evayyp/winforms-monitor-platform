namespace MyUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btn_register = new Sunny.UI.UIButton();
            this.btn_login = new Sunny.UI.UIButton();
            this.uitxt_password = new Sunny.UI.UITextBox();
            this.uitxt_username = new Sunny.UI.UITextBox();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Controls.Add(this.btn_register);
            this.uiPanel1.Controls.Add(this.btn_login);
            this.uiPanel1.Controls.Add(this.uitxt_password);
            this.uiPanel1.Controls.Add(this.uitxt_username);
            this.uiPanel1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(50, 53);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Opacity = ((byte)(80));
            this.uiPanel1.Size = new System.Drawing.Size(444, 349);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_register
            // 
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.FillColor = System.Drawing.Color.Orange;
            this.btn_register.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(269, 263);
            this.btn_register.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(79, 30);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "注册";
            this.btn_register.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(96, 263);
            this.btn_login.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(79, 30);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "登录";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // uitxt_password
            // 
            this.uitxt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitxt_password.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uitxt_password.Location = new System.Drawing.Point(96, 148);
            this.uitxt_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitxt_password.MinimumSize = new System.Drawing.Size(1, 16);
            this.uitxt_password.Name = "uitxt_password";
            this.uitxt_password.Padding = new System.Windows.Forms.Padding(5);
            this.uitxt_password.PasswordChar = '*';
            this.uitxt_password.ShowText = false;
            this.uitxt_password.Size = new System.Drawing.Size(252, 36);
            this.uitxt_password.Symbol = 61475;
            this.uitxt_password.TabIndex = 1;
            this.uitxt_password.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uitxt_password.Watermark = "请输入密码";
            // 
            // uitxt_username
            // 
            this.uitxt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitxt_username.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uitxt_username.Location = new System.Drawing.Point(96, 65);
            this.uitxt_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitxt_username.MinimumSize = new System.Drawing.Size(1, 16);
            this.uitxt_username.Name = "uitxt_username";
            this.uitxt_username.Padding = new System.Windows.Forms.Padding(5);
            this.uitxt_username.ShowText = false;
            this.uitxt_username.Size = new System.Drawing.Size(252, 35);
            this.uitxt_username.Symbol = 61447;
            this.uitxt_username.TabIndex = 0;
            this.uitxt_username.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uitxt_username.Watermark = "请输入用户名";
            // 
            // LoginForm
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(542, 452);
            this.Controls.Add(this.uiPanel1);
            this.KeyPreview = true;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Text = "LoginForm";
            this.ZoomScaleRect = new System.Drawing.Rectangle(30, 30, 800, 450);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITextBox uitxt_password;
        private Sunny.UI.UITextBox uitxt_username;
        private Sunny.UI.UIButton btn_register;
        private Sunny.UI.UIButton btn_login;
    }
}