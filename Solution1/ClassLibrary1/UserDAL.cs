using MyBooks;
using MyEntity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDAL
{
    public class UserDAL
    {
        /// <summary>
        /// 查询登录用户信息
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public UserEntity SelectUsers(UserEntity entity)
        {
            string sql = string.Format($"select * from tb_user where username=@username and password=@password");

            List<MySqlParameter> list = new List<MySqlParameter>();
            list.Add(new MySqlParameter("@username", entity.username));
            list.Add(new MySqlParameter("@password", entity.password));
            
            DataTable dt = DBHelper.GetDateTable(sql,list);
            UserEntity userEntity = new UserEntity();

            //MessageBox.Show($"查询到 {dt.Rows.Count} 条数据");

            foreach (DataRow item in dt.Rows)
            {
                userEntity.id = Convert.ToInt32(item["id"]);
                userEntity.username = item["username"].ToString();
                userEntity.password = item["password"].ToString();
            }

            return userEntity;

        }
    }
}
