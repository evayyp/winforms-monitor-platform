using MyBooks;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUI
{
    public partial class Register : UIForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 注册按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_register_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text.Trim();
            string password = this.txtPassword.Text.Trim();
            string confirmPwd = this.txtConfirmPwd.Text.Trim();

            // 检查为空
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("请输入用户名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("请输入密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPassword.Focus();
                return;
            }

            if (string.IsNullOrEmpty(confirmPwd))
            {
                MessageBox.Show("请确认密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtConfirmPwd.Focus();
                return;
            }

            // 检查密码是否一致
            if (password != confirmPwd)
            {
                MessageBox.Show("两次输入的密码不一致！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPassword.Text = "";
                this.txtConfirmPwd.Text = "";
                this.txtPassword.Focus();
                return;
            }

            // 检查密码长度
            if (password.Length < 3)
            {
                MessageBox.Show("密码长度不能少于3位！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ★ 检查用户名是否已存在（用 GetDateTable）
            string checkSql = $"SELECT * FROM tb_user WHERE username = '{username}'";
            DataTable dt = DBHelper.GetDateTable(checkSql);

            if (dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show("用户名已存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUsername.Text = "";
                this.txtUsername.Focus();
                return;
            }

            // 插入新用户
            string insertSql = $"INSERT INTO tb_user (username, password) VALUES ('{username}', '{password}')";
            int insertResult = DBHelper.CUD(insertSql);

            if (insertResult > 0)
            {
                MessageBox.Show("注册成功！请返回登录。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtUsername.Text = "";
                this.txtPassword.Text = "";
                this.txtConfirmPwd.Text = "";
            }
            else
            {
                MessageBox.Show("注册失败，请重试！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_backlogin_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
            this.Close();
        }
    }
}
