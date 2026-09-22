using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEntity
{
    /// <summary>
    /// 设备信息表
    /// </summary>
    public class DiviceinfoEntity
    {
        public int id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string diviceName{get; set;}
        /// <summary>
        /// 状态
        /// </summary>
        public sbyte status{get; set;}
        /// <summary>
        /// 位置
        /// </summary>
        public string location{get; set;}
        /// <summary>
        /// 制造商
        /// </summary>
        public string manufacturer { get; set; }
        /// <summary>
        /// 购买日期
        /// </summary>
        public DateTime purchaseDate { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public int diviceTypeId { get; set; }
    }
}
