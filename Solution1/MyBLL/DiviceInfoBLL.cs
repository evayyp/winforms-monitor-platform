using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEntity;
using MyDAL;
using ClassLibrary1;

namespace MyBLL
{
    /// <summary>
    /// 设备业务类
    /// </summary>
    public class DiviceInfoBLL
    {
        DiviceInfoDAL dal = new DiviceInfoDAL();
        /// <summary>
        /// 查询运行设备名
        /// </summary>
        /// <returns></returns>
        public List<DiviceinfoEntity> QueryRunningDivices()
        {
            return dal.FindByStatus(0);
        }
    }
}
