using System.Xml;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace JsonDemo1_1735
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Index index = new Index
            {
                Boards = new List<Board>
                {
                    new Board
                    {
                        BoardName = "行政公告",
                        Notices = new List<Notice>{ }
                    },
                    new Board
                    {
                        BoardName = "生活花絮",
                        Notices = new List<Notice>{ }
                    },
                    new Board
                    {
                        BoardName = "資安公告",
                        Notices = new List<Notice>
                        {
                          new Notice
                          {
                              ID = 1,
                              Date = "2024-10-09",
                              Title="[軟體授權宣導] Xmind 品牌軟體的授權需知",
                              Issuer="許琮棋"
                          }
                        }
                    },
                    new Board
                    {
                        BoardName = "內部推薦",
                        Notices = new List<Notice>{ }
                    },
                    new Board
                    {
                        BoardName = "BU1 宣導",
                        Notices = new List<Notice>{ }
                    }
                },

                LoginInfo = new LoginInfo
                {
                    UserName = "楊婷翔",
                    TodayLogin = "08:30 ~ 08:30",
                    LastLogin = "查無紀錄"
                },

                Leave = new Leave
                {
                    UserName="楊婷翔",
                    Hours = 12,
                    Unscheduled = 12,
                    Scheduled = 0,
                    Token = 0,
                    RemainingPercent= "100%"
                }
            };

            // JsonConvert.SerializeObject：將物件序列化為JSON格式的字串。
            // Formatting.Indented參數讓輸出的JSON更具可讀性（縮排格式）。
            string jsonString = JsonConvert.SerializeObject(index, Formatting.Indented);

            Console.WriteLine(jsonString);
        }
    }
}
