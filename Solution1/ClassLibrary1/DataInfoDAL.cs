using MyBooks;
using MyEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DataInfoDAL
    {
        public List<DataInfoEntity> SelectAll(string diviceName)
        {
            string sql = string.Format($"SELECT * from datainfo da join diviceinfo di ON di.diviceTypeId = da.diviceId where diviceName = '{diviceName}'");
            List<DataInfoEntity> list = new List<DataInfoEntity>();
            DataTable dt = DBHelper.GetDateTable(sql);
            foreach (DataRow item in dt.Rows)
            {
                DataInfoEntity entity = new DataInfoEntity();

                entity.id = Convert.ToInt32(item["id"]);
                entity.humidity = Convert.ToInt32(item["humidity"]);
                entity.temperature = Convert.ToDouble(item["temperature"]);
                entity.pressure = Convert.ToDouble(item["pressure"]);
                entity.diviceId = Convert.ToInt32(item["diviceId"]);
                entity.CollectionTime = Convert.ToDateTime(item["CollectionTime"]);
                entity.diviceName = item["diviceName"].ToString();

                list.Add(entity);
            }
            return list;
        }
        
        /// <summary>
        /// 最高气温
        /// </summary>
        /// <param name="diviceId"></param>
        /// <returns></returns>
        public double MaxTemperature(int diviceId)
        {
            string sql = string.Format($"SELECT MAX(temperature) FROM datainfo WHERE diviceId = '{diviceId}'");

            return Convert.ToDouble(DBHelper.GetScalar(sql));
        }

        /// <summary>
        /// 最低气温
        /// </summary>
        /// <param name="diviceId"></param>
        /// <returns></returns>
        public double MinTemperature(int diviceId)
        {
            string sql = string.Format($"SELECT MIN(temperature) FROM datainfo WHERE diviceId = '{diviceId}'");

            return Convert.ToDouble(DBHelper.GetScalar(sql));
        }

        /// <summary>
        /// 最高湿度
        /// </summary>
        /// <param name="diviceId"></param>
        /// <returns></returns>
        public int MaxHumidity(int diviceId)
        {
            string sql = string.Format($"SELECT MAX(humidity) FROM datainfo WHERE diviceId = '{diviceId}'");

            return Convert.ToInt32(DBHelper.GetScalar(sql));
        }

        /// <summary>
        /// 最低湿度
        /// </summary>
        /// <param name="diviceId"></param>
        /// <returns></returns>
        public int MinHumidity(int diviceId)
        {
            string sql = string.Format($"SELECT MIN(humidity) FROM datainfo WHERE diviceId = '{diviceId}'");

            return Convert.ToInt32(DBHelper.GetScalar(sql));
        }

        /// <summary>
        /// 最高气压
        /// </summary>
        /// <param name="diviceId"></param>
        /// <returns></returns>
        public double MaxPressure(int diviceId)
        {
            string sql = string.Format($"SELECT MAX(pressure) FROM datainfo WHERE diviceId = '{diviceId}'");

            return Convert.ToDouble(DBHelper.GetScalar(sql));
        }

        /// <summary>
        /// 最低气压
        /// </summary>
        /// <param name="diviceId"></param>
        /// <returns></returns>
        public double MinPressure(int diviceId)
        {
            string sql = string.Format($"SELECT MIN(pressure) FROM datainfo WHERE diviceId = '{diviceId}'");

            return Convert.ToDouble(DBHelper.GetScalar(sql));
        }

        /// <summary>
        /// 当前温度
        /// </summary>
        /// <param name="diviceId"></param>
        /// <returns></returns>
        public double CurrentTemperature(int diviceId)
        {
            string sql = string.Format($"SELECT temperature FROM datainfo WHERE diviceId = '{diviceId}' ORDER BY id ASC LIMIT 1");
            return Convert.ToDouble(DBHelper.GetScalar(sql));
        }

        /// <summary>
        /// 当前湿度
        /// </summary>
        /// <param name="diviceId"></param>
        /// <returns></returns>
        public int CurrentHumidity(int diviceId)
        {
            string sql = string.Format($"SELECT humidity FROM datainfo WHERE diviceId = '{diviceId}' ORDER BY id ASC LIMIT 1");
            return Convert.ToInt32(DBHelper.GetScalar(sql));
        }

        /// <summary>
        /// 当前气压
        /// </summary>
        /// <param name="diviceId"></param>
        /// <returns></returns>
        public double CurrentPressure(int diviceId)
        {
            string sql = string.Format($"SELECT pressure FROM datainfo WHERE diviceId = '{diviceId}' ORDER BY id ASC LIMIT 1");
            return Convert.ToDouble(DBHelper.GetScalar(sql));
        }
    }
}
