using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyBLL;
using MyEntity;

namespace MyUI
{
    public partial class FrmDeviceMonitor : UserControl
    {
        DiviceInfoBLL bll = new DiviceInfoBLL();
        DataInfoBLL dtbll = new DataInfoBLL();
        public FrmDeviceMonitor()
        {
            InitializeComponent();
            this.uiDataGridView1.AutoGenerateColumns = false;
        }

        private void uiTitlePanel1_Click(object sender, EventArgs e)
        {

        }

        private void diviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uiLabel3_Click(object sender, EventArgs e)
        {

        }

        private void uiDigitalLabel1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void uiLabel7_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 窗体默认加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDeviceMonitor_Load(object sender, EventArgs e)
        {
            List<DiviceinfoEntity> list = bll.QueryRunningDivices();
            //查询结果放入下拉列表
            this.diviceComboBox.DataSource = list;

            //指定显示列名
            this.diviceComboBox.DisplayMember = "DiviceName";
            this.diviceComboBox.ValueMember = "diviceTypeId";
        }

        private void uiTitlePanel3_Click(object sender, EventArgs e)
        {

        }

        private void uiSwitch1_ValueChanged(object sender, bool value)
        {

        }

        private void uiTurnSwitch1_ValueChanged(object sender, bool value)
        {

        }

        private void uiTurnSwitch2_ValueChanged(object sender, bool value)
        {

        }

        private void uiTurnSwitch3_ValueChanged(object sender, bool value)
        {

        }

        private void uiDigitalLabel2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void uiDigitalLabel3_ValueChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 链接按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void connectionBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.diviceComboBox.SelectedValue.ToString());

            //获取下拉列表里面的值
            string diviceName = this.diviceComboBox.Text;

            //获取下拉列表里设备对应的id
            int diviceId = Convert.ToInt32(this.diviceComboBox.SelectedValue);

            if (this.connectionBtn.Text == "连接设备")
            {
                this.connectionBtn.Text = "断开设备";
                //显示所有数据
                List<DataInfoEntity> list = dtbll.SelectAll(diviceName);

                this.uiDataGridView1.DataSource = list;

                //显示当前最高温度
                this.uilabMaxtemperature.Text = dtbll.MaxTemperature(diviceId).ToString();

                //显示当前最低温度
                this.uilabMintemperature.Text = dtbll.MinTemperature(diviceId).ToString();

                //显示当前最高湿度
                this.uilabMaxhumidity.Text = dtbll.MaxHumidity(diviceId).ToString();

                //显示当前最高湿度
                this.uilabMinhumidity.Text = dtbll.MinHumidity(diviceId).ToString();

                //显示当前最高温度
                this.uilabMaxpressure.Text = dtbll.MaxPressure(diviceId).ToString();

                //显示当前最低温度
                this.uilabMinpressure.Text = dtbll.MinPressure(diviceId).ToString();

                //显示当前温度
                this.uiLabCurrentTemperature.Text = dtbll.CurrentTemperature(diviceId).ToString();

                //显示当前湿度
                this.uiLabCurrentHumidity.Text = dtbll.CurrentHumidity(diviceId).ToString();

                //显示当前气压
                this.uiLabCurrentPressure.Text = dtbll.CurrentPressure(diviceId).ToString();

                //显示仪表盘温度
                double temp = dtbll.CurrentTemperature(diviceId);
                this.uiLabCurrentTemperature.Text = temp.ToString();
                this.temperatureMeter.Value = (float)temp;

                //显示仪表盘湿度
                int humidity = dtbll.CurrentHumidity(diviceId);
                this.uiLabCurrentHumidity.Text = humidity.ToString();
                this.humidityMeter.Value = humidity;

                //显示仪表盘气压
                double pressure = dtbll.CurrentPressure(diviceId);
                this.uiLabCurrentPressure.Text = pressure.ToString();
                this.pressureMeter.Value = (float)pressure;
            }
            else
            {
                this.connectionBtn.Text = "连接设备";
            }
        }

        private void uiTitlePanel2_Click(object sender, EventArgs e)
        {

        }

        private void uiTitlePanel5_Click(object sender, EventArgs e)
        {

        }

        private void uiMeter1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void uiTableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiLabel25_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel22_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel28_Click(object sender, EventArgs e)
        {

        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
