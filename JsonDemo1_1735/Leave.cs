using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo1_1735
{
    /// <summary>
    /// 同仁特休未執行時數
    /// </summary>
    public class Leave
    {
        /// <summary>
        /// 同仁姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 總時數
        /// </summary>
        public int Hours { get; set; }
        /// <summary>
        /// 未排
        /// </summary>
        public int Unscheduled { get; set; }
        /// <summary>
        /// 已排
        /// </summary>
        public int Scheduled { get; set; }
        /// <summary>
        /// 已修
        /// </summary>
        public int Token {  get; set; }
        /// <summary>
        /// 剩餘%
        /// </summary>
        public string RemainingPercent {  get; set; }
    }
}
