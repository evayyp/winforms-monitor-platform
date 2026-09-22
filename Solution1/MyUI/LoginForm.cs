using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using MyEntity;
using MyBLL;

namespace MyUI
{
    public partial class LoginForm : UIForm
    {
        UserBLL bll = new UserBLL();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 注册按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton2_Click(object sender, EventArgs e)
        {
            Register frm = new Register();
            frm.ShowDialog();
            this.Close();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                //关闭窗体
                this.Close();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            UserEntity entity = new UserEntity();
            entity.username = this.uitxt_username.Text;
            entity.password = this.uitxt_password.Text;
            


            if (bll.SelectUsers(entity))
            {
                //UIMessageBox.Show("登录成功！");
                //窗体跳转
                FrmMain f = new FrmMain();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                UIMessageBox.Show("登录失败！");
            }
        }
    }
}
