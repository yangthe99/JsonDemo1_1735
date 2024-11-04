using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo1_1735
{
    /// <summary>
    /// 公告類別
    /// </summary>
    public class Board
    {
        /// <summary>
        /// 公告類別名稱
        /// </summary>
        public string BoardName {  get; set; }
        /// <summary>
        /// 類別項下的公告清單
        /// </summary>
        public List<Notice>? Notices { get; set; }
    }
}
