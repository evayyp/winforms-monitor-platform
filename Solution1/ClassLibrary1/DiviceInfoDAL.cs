using MyBooks;
using MyEntity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClassLibrary1
{
    /// <summary>
    /// 设备信息
    /// </summary>
    public class DiviceInfoDAL
    {
        public List<DiviceinfoEntity> FindByStatus(int status) { 
            string sql = string.Format($"select * from DiviceInfo where status=@status");
            List<MySqlParameter> parameters = new List<MySqlParameter>()
            {
            new MySqlParameter("@status",status)
            };
            List<DiviceinfoEntity> list = new List<DiviceinfoEntity>();
            DataTable dt = DBHelper.GetDateTable(sql, parameters);
            foreach (DataRow item in dt.Rows)
            {
                DiviceinfoEntity entity = new DiviceinfoEntity();
                entity.id =Convert.ToInt32( item["id"]);
                entity.diviceName = item["diviceName"].ToString();
                entity.status = Convert.ToSByte(item["status"]);
                entity.location = item["location"].ToString();
                entity.purchaseDate = Convert.ToDateTime(item["purchaseDate"]);
                entity.diviceTypeId = Convert.ToInt32(item["diviceTypeId"]);

                list.Add(entity);
            }


            return list;
        }  
    }
}
