using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo1_1735
{
    /// <summary>
    /// 公告
    /// </summary>
    public class Notice
    {
        /// <summary>
        /// 公告序號(#)
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 公告發布時間(日期)
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// 公告標題
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 公告發布人
        /// </summary>
        public string Issuer { get; set; }
    }
}
