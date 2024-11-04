using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo1_1735
{
    /// <summary>
    /// 登入資訊
    /// </summary>
    public class LoginInfo
    {
        /// <summary>
        /// 登入者名稱
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 本日簽到
        /// </summary>
        public string TodayLogin { get; set; }
        /// <summary>
        /// 上次登入
        /// </summary>
        public string LastLogin { get; set; }
    }
}
