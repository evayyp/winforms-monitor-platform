using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEntity;
using MyDAL;

namespace MyBLL
{
    public class UserBLL
    {
        UserDAL dal = new UserDAL();
        /// <summary>
        /// 查询用户信息
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool SelectUsers(UserEntity entity)
        {
            UserEntity userEntity = dal.SelectUsers(entity);
            if (userEntity.username != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
