using MySql.Data.MySqlClient;
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
using MyDAL;
using MyBooks;

namespace MyUI
{
    public partial class FrmAlertQuery : UIForm
    {
        private DataTable allData;        // 存储所有数据
        private int currentPage = 1;      // 当前页码
        private int pageSize = 10;         // 每页显示条数

        public FrmAlertQuery()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体默认加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAlertQuery_Load(object sender, EventArgs e)
        {
            // 设置为 2026-01-01 到 今天
            this.dtpStart.Value = new DateTime(2026, 1, 1);
            this.dtpEnd.Value = DateTime.Now;

            // 绑定警报来源下拉列表
            LoadAlertSourceComboBox();

            LoadAlertData();

            //绑定分页事件
            this.uiPagination1.PageChanged += uiPagination1_PageChanged;
        }

        private void LoadAlertSourceComboBox()
        {
            string sql = "SELECT id, diviceName FROM diviceinfo";
            DataTable dt = DBHelper.GetDateTable(sql);

            // 添加"全部"选项
            DataRow row = dt.NewRow();
            row["id"] = 0;
            row["diviceName"] = "全部";
            dt.Rows.InsertAt(row, 0);

            this.cmbSource.DataSource = dt;
            this.cmbSource.DisplayMember = "diviceName";
            this.cmbSource.ValueMember = "id";
        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

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

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            FrmWarning frm = new FrmWarning();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// 查询按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton1_Click(object sender, EventArgs e)
        {
            LoadAlertData();
        }

        private void LoadAlertData()
        {
            //获取选中的警报状态
            List<int> selectedStates = new List<int>();

            if (this.chkHigh.Checked) selectedStates.Add(1);      // 高值异常
            if (this.chkLow.Checked) selectedStates.Add(2);       // 低值异常
            if (this.chkCancelHigh.Checked) selectedStates.Add(0); // 取消高值异常
            if (this.chkCancelLow.Checked) selectedStates.Add(0);  // 取消低值异常


            //构建 SQL
            string sql = @"SELECT a.id, a.alarmTime, d.diviceName AS infoType, 
                          a.alarmType, a.alarmValue, a.alarmNote, a.alarmState
                   FROM alarmloginfos a
                   LEFT JOIN diviceinfo d ON a.infoType = d.id
                   WHERE a.alarmTime BETWEEN @startTime AND @endTime";

            //添加状态筛选
            if (selectedStates.Count > 0)
            {
                string stateCondition = string.Join(",", selectedStates);
                sql += $" AND alarmState IN ({stateCondition})";
            }

            //添加来源筛选
            int sourceId = Convert.ToInt32(this.cmbSource.SelectedValue);
            if (sourceId > 0)
            {
                sql += " AND infoType = @sourceId";
            }

            sql += " ORDER BY alarmTime DESC";


            //参数
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("@startTime", this.dtpStart.Value));
            parameters.Add(new MySqlParameter("@endTime", this.dtpEnd.Value));

            if (sourceId > 0)
            {
                parameters.Add(new MySqlParameter("@sourceId", sourceId));
            }


            //执行查询并绑定
            //DataTable dt = DBHelper.GetDateTable(sql, parameters);
            //this.uiDataGridView1.DataSource = dt;
            allData = DBHelper.GetDateTable(sql, parameters);

            // ★ 检查数据是否为空
            if (allData == null || allData.Rows.Count == 0)
            {
                this.uiDataGridView1.DataSource = null;
                this.uiPagination1.TotalCount = 0;
                return;
            }

            // 设置分页控件
            this.uiPagination1.TotalCount = allData.Rows.Count;
            this.uiPagination1.PageSize = pageSize;
            this.uiPagination1.ActivePage = 1;
            currentPage = 1;

            // 显示第一页
            ShowPageData();
        }

        /// <summary>
        /// 显示当前页数据
        /// </summary>
        private void ShowPageData()
        {
            if (allData == null || allData.Rows.Count == 0)
            {
                this.uiDataGridView1.DataSource = null;
                return;
            }

            // 计算起止行
            int startRow = (currentPage - 1) * pageSize;
            int endRow = Math.Min(startRow + pageSize, allData.Rows.Count);

            // 复制当前页数据
            DataTable pageData = allData.Clone();
            for (int i = startRow; i < endRow; i++)
            {
                pageData.ImportRow(allData.Rows[i]);
            }

            this.uiDataGridView1.DataSource = pageData;
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uiPagination1_Click(object sender, object pageIndex)
        {
            
        }
        
        private void uiPagination1_ParentChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="pagingSource"></param>
        /// <param name="pageIndex"></param>
        /// <param name="count"></param>
        private void uiPagination1_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            currentPage = this.uiPagination1.ActivePage;
            ShowPageData();
        }
    }
}
