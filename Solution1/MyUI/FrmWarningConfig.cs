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
    public partial class FrmWarningConfig : UserControl
    {
        public FrmWarningConfig()
        {
            InitializeComponent();
            LoadConfig();
        }

        private void FrmWarningConfig_Load(object sender, EventArgs e)
        {
            //LoadConfig();
        }

        /// <summary>
        ///  加载配置数据
        /// </summary>
        public void LoadConfig()
        {
            try
            {
                string sql = "SELECT * FROM alarmrules WHERE isEnabled = 1";
                DataTable dt = DBHelper.GetDateTable(sql);

                if (dt == null || dt.Rows.Count == 0)
                {
                    SetDefaultValues();
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    string paramName = row["parameterName"].ToString();
                    string ruleName = row["ruleName"].ToString();
                    double threshold = Convert.ToDouble(row["thresholdValue"]);
                    int condition = Convert.ToInt32(row["condition"]);

                    if (paramName == "Temperature")
                    {
                        // 根据条件判断是低、正常还是高
                        if (condition == 2) // 低值
                        {
                            this.txtTempLow.Text = ruleName;
                            this.numTempMin.Value = (decimal)threshold;
                        }
                        else if (condition == 1) // 高值
                        {
                            this.txtTempHigh.Text = ruleName;
                            this.numTempMax.Value = (decimal)threshold;
                        }
                        // 正常等级需要从数据库中读取中间值
                    }
                    else if (paramName == "Humidity")
                    {
                        if (condition == 2)
                        {
                            this.txtHumidLow.Text = ruleName;
                            this.numHumidMin.Value = (decimal)threshold;
                        }
                        else if (condition == 1)
                        {
                            this.txtHumidHigh.Text = ruleName;
                            this.numHumidMax.Value = (decimal)threshold;
                        }
                    }
                    else if (paramName == "Pressure")
                    {
                        if (condition == 2)
                        {
                            this.txtPressLow.Text = ruleName;
                            this.numPressMin.Value = (decimal)threshold;
                        }
                        else if (condition == 1)
                        {
                            this.txtPressHigh.Text = ruleName;
                            this.numPressMax.Value = (decimal)threshold;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载配置失败：{ex.Message}");
            }
        }

        private void SetDefaultValues()
        {
            // 设置默认值
            this.numTempMin.Value = 0;
            this.numTempMax.Value = 30;
            this.numHumidMin.Value = 10;
            this.numHumidMax.Value = 80;
            this.numPressMin.Value = 0;
            this.numPressMax.Value = 1;
            this.txtTempLow.Text = "低温";
            this.txtTempNormal.Text = "正常";
            this.txtTempHigh.Text = "高温";
            this.txtHumidLow.Text = "低湿";
            this.txtHumidNormal.Text = "正常";
            this.txtHumidHigh.Text = "高湿";
            this.txtPressLow.Text = "低压";
            this.txtPressNormal.Text = "正常";
            this.txtPressHigh.Text = "高压";

        }

        /// <summary>
        /// 确定按钮点击事件
        /// </summary>
        private void uiButton1_Click(object sender, EventArgs e)
        {
            int successCount = 0;

            // 保存温度配置
            if (SaveParamConfig("温度",
                this.txtTempLow.Text.Trim(),
                this.txtTempNormal.Text.Trim(),
                this.txtTempHigh.Text.Trim(),
                (double)this.numTempMin.Value,
                (double)this.numTempMax.Value))
            {
                successCount++;
            }

            // 保存湿度配置
            if (SaveParamConfig("湿度",
                this.txtHumidLow.Text.Trim(),
                this.txtHumidNormal.Text.Trim(),
                this.txtHumidHigh.Text.Trim(),
                (double)this.numHumidMin.Value,
                (double)this.numHumidMax.Value))
            {
                successCount++;
            }

            // 保存压力配置
            if (SaveParamConfig("压力",
                this.txtPressLow.Text.Trim(),
                this.txtPressNormal.Text.Trim(),
                this.txtPressHigh.Text.Trim(),
                (double)this.numPressMin.Value,
                (double)this.numPressMax.Value))
            {
                successCount++;
            }

            if (successCount > 0)
            {
                MessageBox.Show($"保存成功！共保存 {successCount} 条配置。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadConfig();
            }
            else
            {
                MessageBox.Show("请至少填写一条完整的配置（阈值范围 + 等级名称）！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool SaveParamConfig(string paramName, string lowLevel, string normalLevel, string highLevel, double minVal, double maxVal)
        {
            // 检查是否至少填了一个等级名称
            if (string.IsNullOrEmpty(lowLevel) && string.IsNullOrEmpty(normalLevel) && string.IsNullOrEmpty(highLevel))
            {
                return false;
            }

            // 检查阈值是否有效
            if (minVal >= maxVal)
            {
                MessageBox.Show($"{paramName} 的最小值不能大于或等于最大值！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string paramEnglish = GetParamEnglish(paramName);

            // 禁用该参数的旧配置
            string deleteSql = $"UPDATE alarmrules SET isEnabled = 0 WHERE parameterName = '{paramEnglish}'";
            DBHelper.CUD(deleteSql);

            int insertedCount = 0;

            // 低值规则
            if (!string.IsNullOrEmpty(lowLevel) && minVal > 0)
            {
                string sql = $@"INSERT INTO alarmrules (ruleName, parameterName, `condition`, thresholdValue, checkInterval, isEnabled) 
                            VALUES ('{lowLevel}', '{paramEnglish}', 2, {minVal}, 30, 1)";
                DBHelper.CUD(sql);
                insertedCount++;
            }

            // 正常值规则（不插入数据库，只显示用）
            // 正常值不需要报警规则

            // 高值规则
            if (!string.IsNullOrEmpty(highLevel) && maxVal > 0)
            {
                string sql = $@"INSERT INTO alarmrules (ruleName, parameterName, `condition`, thresholdValue, checkInterval, isEnabled) 
                            VALUES ('{highLevel}', '{paramEnglish}', 1, {maxVal}, 30, 1)";
                DBHelper.CUD(sql);
                insertedCount++;
            }

            return insertedCount > 0;
        }


        /// <summary>
        /// 中文参数名转英文
        /// </summary>
        /// <param name="paramName"></param>
        /// <returns></returns>
        private string GetParamEnglish(string paramName)
        {
            if (paramName == "温度") return "Temperature";
            if (paramName == "湿度") return "Humidity";
            if (paramName == "压力") return "Pressure";
            return paramName;
        }


        /// <summary>
        /// 刷新配置（给父窗体调用）
        /// </summary>
        public void RefreshConfig()
        {
            LoadConfig();
        }
    }
}
