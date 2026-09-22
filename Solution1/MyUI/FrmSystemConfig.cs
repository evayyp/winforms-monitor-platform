using MyBooks;
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
    public partial class FrmSystemConfig : UserControl
    {
        public FrmSystemConfig()
        {
            InitializeComponent();
        }

        private void FrmSystemConfig_Load(object sender, EventArgs e)
        {
            // 加载语言下拉
            this.cmbLanguage.Items.Clear();
            this.cmbLanguage.Items.Add("中文");
            this.cmbLanguage.Items.Add("英文");
            this.cmbLanguage.SelectedIndex = 0;

            // 加载日志级别下拉
            this.cmbLogLevel.Items.Clear();
            this.cmbLogLevel.Items.Add("调试");
            this.cmbLogLevel.Items.Add("正常");
            this.cmbLogLevel.Items.Add("警告");
            this.cmbLogLevel.Items.Add("错误");
            this.cmbLogLevel.SelectedIndex = 1;

            LoadConfig();
        }

        private void LoadConfig()
        {
            try
            {
                string sql = "SELECT * FROM system_config ORDER BY id DESC LIMIT 1";
                DataTable dt = DBHelper.GetDateTable(sql);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    this.txtSystemName.Text = row["system_name"].ToString();
                    this.cmbLanguage.Text = row["system_language"].ToString();
                    this.chkAutoLogin.Checked = Convert.ToInt32(row["auto_login"]) == 1;
                    this.cmbLogLevel.Text = row["log_level"].ToString();
                }
                else
                {
                    this.txtSystemName.Text = "智能设备监控平台";
                    this.cmbLanguage.SelectedIndex = 0;
                    this.chkAutoLogin.Checked = false;
                    this.cmbLogLevel.SelectedIndex = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载配置失败：{ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string systemName = this.txtSystemName.Text.Trim();
            if (string.IsNullOrEmpty(systemName))
            {
                MessageBox.Show("请输入系统名称！");
                return;
            }

            string language = this.cmbLanguage.Text;
            int autoLogin = this.chkAutoLogin.Checked ? 1 : 0;
            string logLevel = this.cmbLogLevel.Text;

            string sql = $@"INSERT INTO system_config 
                             (system_name, system_language, auto_login, log_level, update_time) 
                           VALUES 
                             ('{systemName}', '{language}', {autoLogin}, '{logLevel}', NOW())";

            int result = DBHelper.CUD(sql);

            MessageBox.Show(result > 0 ? "保存成功！" : "保存失败！");
        }
    }
}
