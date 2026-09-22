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


namespace MyUI
{
    public partial class FrmWarning : UIForm
    {
        private UIButton currentSelectedButton;

        public FrmWarning()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体默认加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmWarningConfig_Load(object sender, EventArgs e)
        {
            // 绑定导航按钮事件
            this.btnWarning.Click += NavButton_Click;
            this.btnCommunication.Click += NavButton_Click;
            this.btnParameter.Click += NavButton_Click;
            this.btnStorage.Click += NavButton_Click;
            this.btnSystem.Click += NavButton_Click;

            // 默认选中"预警配置"
            this.btnWarning.Selected = true;
            currentSelectedButton = btnWarning;

            // ★ 默认加载预警配置
            FrmWarningConfig f = new FrmWarningConfig();
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
        }

        private void NavButton_Click(object sender, EventArgs e)
        {
            UIButton btn = sender as UIButton;
            if (btn == null) return;

            // 取消上一个按钮的高亮
            if (currentSelectedButton != null && currentSelectedButton != btn)
            {
                currentSelectedButton.Selected = false;
            }

            // 高亮当前按钮
            btn.Selected = true;
            currentSelectedButton = btn;

            // 清空主面板
            this.mainPanel.Controls.Clear();

            // 根据按钮名称打开对应的窗体
            if (btn.Name == "btnWarning")
            {
                FrmWarningConfig f = new FrmWarningConfig();
                f.Dock = DockStyle.Fill;
                this.mainPanel.Controls.Add(f);
            }
            else if (btn.Name == "btnCommunication")
            {
                FrmCommunicationConfig fc = new FrmCommunicationConfig();
                fc.Dock = DockStyle.Fill;
                this.mainPanel.Controls.Add(fc);
            }
            else if (btn.Name == "btnParameter")
            {
                FrmParameterConfig f = new FrmParameterConfig();
                f.Dock = DockStyle.Fill;
                this.mainPanel.Controls.Add(f);
            }
            else if (btn.Name == "btnStorage")
            {
                FrmStorageConfig f = new FrmStorageConfig();
                f.Dock = DockStyle.Fill;
                this.mainPanel.Controls.Add(f);
            }
            else if (btn.Name == "btnSystem")
            {
                FrmSystemConfig f = new FrmSystemConfig();
                f.Dock = DockStyle.Fill;
                this.mainPanel.Controls.Add(f);
            }
        }



        private void mainPanel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 预警配置按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton1_Click(object sender, EventArgs e)
        {
            //FrmWarningConfig f = new FrmWarningConfig();
            //f.Dock = DockStyle.Fill;
            //this.mainPanel.Controls.Add(f);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 更新日期
            this.nowDateLabel.Text = DateTime.Now.ToString("yyyy-MM-dd dddd");

            // 更新时间
            this.timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            FrmMain f = new FrmMain();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void uiSymbolButton3_Click(object sender, EventArgs e)
        {
            FrmAlertQuery frm = new FrmAlertQuery();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// 通信配置按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommunication_Click(object sender, EventArgs e)
        {
            //FrmCommunicationConfig fc = new FrmCommunicationConfig();
            //fc.Dock = DockStyle.Fill;
            //this.mainPanel.Controls.Add(fc);
        }
    }
}
