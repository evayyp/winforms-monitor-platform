using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEntity
{
    /// <summary>
    /// 实时数据采集表
    /// </summary>
    public class DataInfoEntity
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int id {get; set;}
        /// <summary>
        /// 采集时间
        /// </summary>
        public DateTime CollectionTime {get;set;}
        /// <summary>
        /// 温度
        /// </summary>
        public double temperature {get; set;}
        /// <summary>
        /// 湿度
        /// </summary>
        public int humidity {get; set;}
        /// <summary>
        /// 气压
        /// </summary>
        public double pressure {get; set;}
        /// <summary>
        /// 设备ID
        /// </summary>
        public int diviceId {get; set;}
        /// <summary>
        /// 设备名称
        /// </summary>
        public string diviceName {get; set;}
    }
}
