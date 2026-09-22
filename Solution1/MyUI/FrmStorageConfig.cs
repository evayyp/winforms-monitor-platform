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
    public partial class FrmStorageConfig : UserControl
    {
        public FrmStorageConfig()
        {
            InitializeComponent();
        }

        private void FrmStorageConfig_Load(object sender, EventArgs e)
        {
            // 设置范围
            this.numSaveDays.Maximum = 365;
            this.numSaveDays.Minimum = 1;
            this.numSaveDays.Value = 30;

            LoadConfig();
        }

        /// <summary>
        /// 加载配置
        /// </summary>
        private void LoadConfig()
        {
            string sql = "SELECT * FROM storage_config ORDER BY id DESC LIMIT 1";
            DataTable dt = DBHelper.GetDateTable(sql);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                this.numSaveDays.Value = Convert.ToDecimal(row["save_days"]);
                this.chkAutoClean.Checked = Convert.ToInt32(row["auto_clean"]) == 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int saveDays = (int)this.numSaveDays.Value;
            int autoClean = this.chkAutoClean.Checked ? 1 : 0;

            string sql = $@"INSERT INTO storage_config (save_days, auto_clean, update_time) 
                           VALUES ({saveDays}, {autoClean}, NOW())";

            int result = DBHelper.CUD(sql);

            MessageBox.Show(result > 0 ? "保存成功！" : "保存失败！");
        }
    }
}
