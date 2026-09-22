using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MyBooks
{
    /// <summary>
    /// 数据库辅助类
    /// </summary>
    public class DBHelper
    {
        //获取数据库连接字符串
        static string ConStr = ConfigurationManager.ConnectionStrings["dmwcmdb"].ToString();


        #region 增、删、改（普通的SQL语句）
        /// <summary>
        /// 增、删、改（普通的SQL语句）
        /// </summary>
        /// <param name="sql">普通的SQL语句</param>
        /// <returns>返回的受影响的行数/returns>
        public static int CUD(string sql)
        {
            
            MySqlConnection con = null;
            try
            {
                //创建数据库连接对象
                con = new MySqlConnection(ConStr);
                //打开数据库连接
                con.Open();
                //创建命令对象
                MySqlCommand com = new MySqlCommand(sql, con);
                int index = com.ExecuteNonQuery();
                return index;

            }
            catch (Exception ex)
            {

                return -1;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion



        #region 增、删、改（参数化SQL语句）
        /// <summary>
        /// 增、删、改（参数化SQL语句）
        /// </summary>
        /// <param name="sql">参数化SQL语句</param>
        /// <returns>返回的受影响的行数/returns>
        public static int CUD(string sql, List<MySqlParameter> sqlParams)
        {
            MySqlConnection con = null;
            try
            {
                //创建数据库连接对象
                con = new MySqlConnection(ConStr);
                //打开数据库连接
                con.Open();
                //创建命令对象
                MySqlCommand com = new MySqlCommand(sql, con);
                //ToArray()用于将集合转换为数组
                com.Parameters.AddRange(sqlParams.ToArray());
                int index = com.ExecuteNonQuery();
                return index;

            }
            catch (Exception ex)
            {

                return -1;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region  执行查询操作，返回MySqlDataReader对象
        /// <summary>
        /// 执行查询操作，返回MySqlDataReader对象
        /// </summary>
        /// <param name="sql">普通的SQL语句</param>
        /// <returns>返回的MySqlDataReader对象</returns>

        public static MySqlDataReader GetRead(string sql)
        {
            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection(ConStr);
                con.Open();
                MySqlCommand com = new MySqlCommand(sql, con);
                //CommandBehavior.CloseConnection用于设置当MySqlDataReader关闭时会自动关闭连接
                MySqlDataReader dr = com.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;

            }
            catch (Exception ex)
            {

                return null;
            }
            //finally
            //{
            //    con.Close();
            //}


        }
        #endregion


        #region  执行查询操作，返回MySqlDataReader对象(参数化SQL语句)
        /// <summary>
        /// 执行查询操作，返回MySqlDataReader对象(参数化SQL语句)
        /// </summary>
        /// <param name="sql">参数化SQL语句</param>
        /// <returns>返回的MySqlDataReader对象</returns>

        public static MySqlDataReader GetRead(string sql,List<MySqlParameter> parameters)
        {
            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection(ConStr);
                con.Open();
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddRange(parameters.ToArray());
                //CommandBehavior.CloseConnection用于设置当MySqlDataReader关闭时会自动关闭连接
                MySqlDataReader dr = com.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;

            }
            catch (Exception ex)
            {

                return null;
            }
         /*   finally
            {
                con.Close();
            }*/


        }
        #endregion


        #region 执行查询操作，返回DataTable对象(普通SQL语句)
        /// <summary>
        /// 执行查询操作，返回DataTable对象(普通SQL语句)
        /// </summary>
        /// <param name="sql">普通sql语句</param>
        /// <returns>返回DataTable</returns>
        public static DataTable GetDateTable(string sql) {
            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection(ConStr);
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;


            }
            catch (Exception ex)
            {

                return null;
            }
            finally {
                con.Close();
            }

        }
        #endregion


        #region 执行查询操作，返回DataTable对象(参数化SQL语句)
        /// <summary>
        /// 执行查询操作，返回DataTable对象(参数化SQL语句)
        /// </summary>
        /// <param name="sql">带@参数化SQL语句</param>
        /// <returns>返回DataTable</returns>
        public static DataTable GetDateTable(string sql,List<MySqlParameter> parameters)
        {
            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection(ConStr);
                con.Open();
                MySqlCommand com = new MySqlCommand(sql,con);
                com.Parameters.AddRange(parameters.ToArray());         
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = com;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;


            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                con.Close();
            }

        }
        #endregion


        #region 执行查询语句，返回第一行第一个单元格中的数据(普通SQL语句)
        /// <summary>
        /// 执行查询语句，返回第一行第一个单元格中的数据
        /// </summary>
        /// <param name="sql">普通的SQL语句</param>
        /// <returns>返回第一行第一个单元格中的数据</returns>
        public static object GetScalar(string sql) {

            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection(ConStr);
                con.Open();
                MySqlCommand com = new MySqlCommand(sql, con);
                object result = com.ExecuteScalar();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally {
                con.Close();
            }
        }
        #endregion


        #region 执行查询语句，返回第一行第一个单元格中的数据(参数化SQL语句)
        /// <summary>
        /// 执行查询语句，返回第一行第一个单元格中的数据(参数化SQL语句)
        /// </summary>
        /// <param name="sql">参数化SQL语句</param>
        /// <returns>返回第一行第一个单元格中的数据</returns>
        public static object GetScalar(string sql,List<MySqlParameter> parameters)
        {

            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection(ConStr);
                con.Open();
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddRange(parameters.ToArray());
                object result = com.ExecuteScalar();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
    }
}
