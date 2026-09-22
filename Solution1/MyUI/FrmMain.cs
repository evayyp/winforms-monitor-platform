using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUI
{
    public partial class FrmMain : UIForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmDeviceMonitor f = new FrmDeviceMonitor();
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            //FrmDeviceMonitor f = new FrmDeviceMonitor();
            //f.TopLevel = false;
            //f.FormBorderStyle = FormBorderStyle.None;
            //f.Dock = DockStyle.Fill;
            //this.mainPanel.Controls.Add(f);
            //f.Show();
            
        }

        private void uiLabel4_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        /// <summary>
        /// 窗体最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void mainPanel_Click(object sender, EventArgs e)
        {

        }

        private void topPanel_Click(object sender, EventArgs e)
        {

        }

        private void timeLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void nowDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton3_Click(object sender, EventArgs e)
        {
            FrmAlertQuery frm = new FrmAlertQuery();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void uiPanel1_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel3_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            FrmWarning frm = new FrmWarning();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void buttonLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiPanel2_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel5_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel6_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 更新日期
            this.nowDateLabel.Text = DateTime.Now.ToString("yyyy-MM-dd dddd");

            // 更新时间
            this.timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
