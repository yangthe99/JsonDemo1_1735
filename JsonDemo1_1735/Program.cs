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

            // 將公司物件序列化為 JSON 字串
            string jsonString = JsonConvert.SerializeObject(index, Formatting.Indented);

            // 輸出 JSON 字串
            Console.WriteLine(jsonString);
        }
    }
}
