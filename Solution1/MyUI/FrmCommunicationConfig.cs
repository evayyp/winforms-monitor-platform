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
    public partial class FrmCommunicationConfig : UserControl
    {
        public FrmCommunicationConfig()
        {
            InitializeComponent();
        }

        private void FrmCommunicationConfig_Load(object sender, EventArgs e)
        {
            // 添加通信协议选项
            this.cmbProtocol.Items.Clear();
            this.cmbProtocol.Items.Add("Modbus");
            this.cmbProtocol.Items.Add("OPC UA");
            this.cmbProtocol.Items.Add("MQTT");
            this.cmbProtocol.Items.Add("HTTP");
            this.cmbProtocol.Items.Add("TCP/IP");
            this.cmbProtocol.Items.Add("串口");

            LoadConfig();
        }

        private void LoadConfig()
        {
            string sql = "SELECT * FROM communication_config ORDER BY id DESC LIMIT 1";
            DataTable dt = DBHelper.GetDateTable(sql);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                this.cmbProtocol.Text = row["protocol"].ToString();
                this.txtIPAddress.Text = row["ip_address"].ToString();
                this.numPort.Value = Convert.ToDecimal(row["port"]);
                this.numTimeout.Value = Convert.ToDecimal(row["timeout"]);
                this.numRetry.Value = Convert.ToDecimal(row["retry_count"]);
                this.numCollectInterval.Value = Convert.ToDecimal(row["collect_interval"]);
            }
            else
            {
                // 设置默认值
                this.cmbProtocol.Text = "Modbus";
                this.txtIPAddress.Text = "127.0.0.1";
                this.numPort.Value = 502;
                this.numTimeout.Value = 5;
                this.numRetry.Value = 3;
                this.numCollectInterval.Value = 10;
            }
        }

        /// <summary>
        /// 保存按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = $@"INSERT INTO communication_config 
                     (protocol, ip_address, port, timeout, retry_count, collect_interval, update_time) 
                     VALUES 
                     ('{cmbProtocol.Text}', '{txtIPAddress.Text}', {numPort.Value}, {numTimeout.Value}, {numRetry.Value}, {numCollectInterval.Value}, NOW())";

            int result = DBHelper.CUD(sql);

            if (result > 0)
            {
                MessageBox.Show("通信配置保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("保存失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
