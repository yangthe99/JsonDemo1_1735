using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo1_1735
{
    /// <summary>
    /// 資訊網首頁
    /// </summary>
    public class Index
    {
        /// <summary>
        /// 公告區
        /// </summary>
        public List<Board> Boards { get; set; }
        /// <summary>
        /// 登入資訊
        /// </summary>
        public LoginInfo LoginInfo { get; set; }
        /// <summary>
        /// 特休資訊
        /// </summary>
        public Leave Leave { get; set; }
    }
}
