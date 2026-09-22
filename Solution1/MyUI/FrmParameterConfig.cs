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
    public partial class FrmParameterConfig : UserControl
    {
        public FrmParameterConfig()
        {
            InitializeComponent();
        }

        private void FrmParameterConfig_Load(object sender, EventArgs e)
        {
            LoadDeviceComboBox();
            LoadConfig();
        }

        /// <summary>
        /// 加载设备下拉列表
        /// </summary>
        private void LoadDeviceComboBox()
        {
            string sql = "SELECT id, diviceName FROM diviceinfo";
            DataTable dt = DBHelper.GetDateTable(sql);

            // 添加"请选择设备"
            DataRow row = dt.NewRow();
            row["id"] = 0;
            row["diviceName"] = "请选择设备";
            dt.Rows.InsertAt(row, 0);

            this.cmbDevice.DataSource = dt;
            this.cmbDevice.DisplayMember = "diviceName";
            this.cmbDevice.ValueMember = "id";
            this.cmbDevice.SelectedIndex = 0;
        }

        /// <summary>
        /// 切换设备时加载配置
        /// </summary>
        private void cmbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDevice.SelectedIndex > 0)
            {
                LoadConfig();
            }
        }

        /// <summary>
        /// 加载配置数据
        /// </summary>
        private void LoadConfig()
        {
            int deviceId = Convert.ToInt32(this.cmbDevice.SelectedValue);
            if (deviceId == 0) return;

            string sql = $"SELECT * FROM param_config WHERE device_id = {deviceId} ORDER BY id DESC LIMIT 1";
            DataTable dt = DBHelper.GetDateTable(sql);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                this.txtModel.Text = row["device_model"].ToString();
                this.txtCode.Text = row["device_code"].ToString();
                this.numCollectInterval.Value = Convert.ToDecimal(row["collect_interval"]);
                this.numUploadInterval.Value = Convert.ToDecimal(row["upload_interval"]);
            }
            else
            {
                SetDefaultValues();
            }
        }

        /// <summary>
        /// 设置默认值
        /// </summary>
        private void SetDefaultValues()
        {
            this.txtModel.Text = "";
            this.txtCode.Text = "";
            this.numCollectInterval.Value = 10;
            this.numUploadInterval.Value = 30;
        }

        /// <summary>
        /// 清空所有字段
        /// </summary>
        private void ClearFields()
        {
            this.txtModel.Text = "";
            this.txtCode.Text = "";
            this.numCollectInterval.Value = 10;
            this.numUploadInterval.Value = 30;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbDevice.SelectedIndex == 0)
            {
                MessageBox.Show("请选择设备");
                return;
            }

            if (string.IsNullOrEmpty(txtModel.Text))
            {
                MessageBox.Show("请输入型号");
                return;
            }

            if (string.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("请输入编号");
                return;
            }

            // 2. 保存
            int deviceId = Convert.ToInt32(cmbDevice.SelectedValue);
            string sql = $@"INSERT INTO param_config (device_id, device_model, device_code, collect_interval, upload_interval, update_time) 
                     VALUES ({deviceId}, '{txtModel.Text}', '{txtCode.Text}', {numCollectInterval.Value}, {numUploadInterval.Value}, NOW())";

            int result = DBHelper.CUD(sql);

            // 3. 提示
            MessageBox.Show(result > 0 ? "保存成功！" : "保存失败！");
        }
    }
}
