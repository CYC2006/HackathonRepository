using System.Collections.Generic;
using Microsoft.AspNetCore.Components.Web;

namespace Hackathon.Data
{
    public class EventCardInfo
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public int MoneyChange { get; set; }
        public int EcoChange { get; set; }
        public int SocialChange { get; set; }
        public int StartMonth { get; set; }
        public int EndMonth { get; set; }
        public string? ImagePath { get; set; } = null;
        public string Type { get; set; } = "";

        public EventCardInfo Clone()
        {
            return new EventCardInfo
            {
                Title = this.Title,
                Description = this.Description,
                MoneyChange = this.MoneyChange,
                EcoChange = this.EcoChange,
                SocialChange = this.SocialChange,
                StartMonth = this.StartMonth,
                EndMonth = this.EndMonth,
                ImagePath = this.ImagePath,
                Type = this.Type,
            };
        }
    }
    
    public static class EventCardData
    {
        public record Row(string Type, int Index, int Money, int Eco, int Social, int Start, int End, string ImagePath);

        private static readonly Row[] Rows = new Row[]
        {
            new Row("四季", 0, 50, 1, 3, 2, 5, ""),
            new Row("四季", 1, -20, 6, 2, 4, 6, ""),
            new Row("四季", 2, 60, -4, 1, 6, 9, ""),
            new Row("四季", 3, 20, 3, 3, 10, 12, ""),
            new Row("四季", 4, 70, -2, 2, 11, 2, ""),
            new Row("四季", 5, -10, 7, 4, 2, 5, ""),
            new Row("四季", 6, 60, -5, 1, 6, 10, ""),
            new Row("四季", 7, 40, 6, 5, 9, 11, ""),
            new Row("四季", 8, -40, 5, 1, 12, 2, ""),
            new Row("四季", 9, 10, 8, 5, 6, 8, ""),
            new Row("四季", 10, 40, -4, 2, 9, 11, ""),
            new Row("四季", 11, 30, 6, 4, 12, 2, ""),
            new Row("四季", 12, 60, -2, 3, 2, 3, ""),
            new Row("四季", 13, 10, 8, 5, 3, 5, ""),
            new Row("四季", 14, -20, 5, 2, 7, 9, ""),

            new Row("天災", 0, -70, -5, -4, 7, 12, ""),
            new Row("天災", 1, -90, -6, -5, 1, 12, ""),
            new Row("天災", 2, -40, -2, -3, 5, 8, ""),
            new Row("天災", 3, -80, -4, -4, 6, 10, ""),
            new Row("天災", 4, -60, -5, -5, 1, 4, ""),
            new Row("天災", 5, -30, -3, -2, 1, 3, ""),
            new Row("天災", 6, -50, -2, -4, 9, 10, ""),
            new Row("天災", 7, -80, -7, -6, 10, 11, ""),
            new Row("天災", 8, -60, -1, -4, 11, 12, ""),
            new Row("天災", 9, -70, -4, -5, 5, 7, ""),
            new Row("天災", 10, -30, -4, -3, 7, 9, ""),
            new Row("天災", 11, -90, -8, -5, 9, 11, ""),
            new Row("天災", 12, -100, -7, -6, 11, 1, ""),
            new Row("天災", 13, -40, -2, -2, 2, 4, ""),
            new Row("天災", 14, -50, -4, -3, 9, 11, ""),
            new Row("天災", 15, -70, -3, -5, 10, 3, ""),
            new Row("天災", 16, -60, -3, -4, 7, 9, ""),
            new Row("天災", 17, -80, 2, -6, 10, 12, ""),
            new Row("天災", 18, -700, -30, -60, 1, 12, ""),
            new Row("天災", 19, -900, -60, -40, 1, 12, ""),
            new Row("天災", 20, -900, -40, -30, 1, 12, ""),
            new Row("天災", 21, -500, -70, -40, 1, 12, ""),
            new Row("天災", 22, -800, -30, -70, 1, 12, ""),

            new Row("政策", 0, 50, 7, 4, 1, 12, ""),
            new Row("政策", 1, -30, 8, 3, 1, 12, ""),
            new Row("政策", 2, 30, 6, 4, 1, 12, ""),
            new Row("政策", 3, 60, 7, 5, 1, 12, ""),
            new Row("政策", 4, 40, 2, 3, 1, 12, ""),
            new Row("政策", 5, -20, 8, 4, 1, 12, ""),
            new Row("政策", 6, 20, 5, 3, 1, 12, ""),
            new Row("政策", 7, -10, 7, 5, 1, 12, ""),
            new Row("政策", 8, 60, 5, 4, 1, 12, ""),
            new Row("政策", 9, -40, 9, 6, 1, 12, ""),
            new Row("政策", 10, 50, 4, 4, 1, 12, ""),
            new Row("政策", 11, 30, 3, 3, 1, 12, ""),
            new Row("政策", 12, -10, 6, 4, 1, 12, ""),
            new Row("政策", 13, 70, 5, 4, 1, 12, ""),
            new Row("政策", 14, 30, 4, 3, 1, 12, ""),
            new Row("政策", 15, 40, 7, 5, 1, 12, ""),
            new Row("政策", 16, -30, 9, 6, 1, 12, ""),
            new Row("政策", 17, -40, 3, 4, 1, 12, ""),
            new Row("政策", 18, -600, -10, -80, 1, 12, ""),
            new Row("政策", 19, -700, -20, -40, 1, 12, ""),
            new Row("政策", 20, 200, 10, -80, 1, 12, ""),
            new Row("政策", 21, -700, 30, -60, 1, 12, ""),

            new Row("經濟", 0, 80, -4, 2, 1, 12, ""),
            new Row("經濟", 1, 50, -2, 3, 1, 12, ""),
            new Row("經濟", 2, 70, -5, 2, 1, 12, ""),
            new Row("經濟", 3, 70, -3, 2, 1, 12, ""),
            new Row("經濟", 4, 40, 4, 3, 1, 12, ""),
            new Row("經濟", 5, 30, 7, 4, 1, 12, ""),
            new Row("經濟", 6, 60, -5, 1, 1, 12, ""),
            new Row("經濟", 7, 40, 6, 4, 1, 12, ""),
            new Row("經濟", 8, 60, -3, 3, 1, 12, ""),
            new Row("經濟", 9, 70, -2, 3, 1, 12, ""),
            new Row("經濟", 10, 50, 5, 4, 1, 12, ""),
            new Row("經濟", 11, 30, 8, 5, 1, 12, ""),
            new Row("經濟", 12, 60, -2, 3, 1, 12, ""),
            new Row("經濟", 13, 80, -3, 2, 1, 12, ""),
            new Row("經濟", 14, 70, -4, 3, 1, 12, ""),
            new Row("經濟", 15, -800, -20, -50, 1, 12, ""),
            new Row("經濟", 16, -500, -10, -70, 1, 12, ""),
            new Row("經濟", 17, -1000, 10, -60, 1, 12, ""),
            new Row("經濟", 18, -600, -30, -50, 1, 12, ""),
            new Row("經濟", 19, -800, 10, -50, 1, 12, ""),
            new Row("經濟", 20, 900, 100, 80, 1, 12, ""),
            new Row("經濟", 21, -600, 80, -50, 1, 12, ""),

            new Row("環境", 0, 10, 8, 5, 1, 12, ""),
            new Row("環境", 1, 20, -2, 3, 1, 12, ""),
            new Row("環境", 2, 0, 9, 6, 1, 12, ""),
            new Row("環境", 3, 30, 6, 5, 1, 12, ""),
            new Row("環境", 4, 10, 8, 5, 1, 12, ""),
            new Row("環境", 5, 40, 7, 5, 1, 12, ""),
            new Row("環境", 6, 20, 6, 4, 1, 12, ""),
            new Row("環境", 7, 10, 3, 3, 1, 12, ""),
            new Row("環境", 8, -20, -3, 2, 1, 12, ""),
            new Row("環境", 9, 30, 9, 6, 1, 12, ""),
            new Row("環境", 10, 20, 7, 5, 1, 12, ""),
            new Row("環境", 11, 50, -3, 3, 1, 12, ""),
            new Row("環境", 12, 20, 9, 6, 1, 12, ""),
            new Row("環境", 13, 10, 7, 4, 1, 12, ""),
            new Row("環境", 14, 0, 5, 3, 1, 12, ""),
            new Row("環境", 15, -30, 9, 6, 1, 12, ""),
            new Row("環境", 16, 0, 6, 5, 1, 12, ""),
            new Row("環境", 17, -700, -20, -50, 1, 12, ""),
            new Row("環境", 18, -800, -100, -90, 1, 12, ""),
            new Row("環境", 19, -700, -90, -60, 1, 12, ""),
            new Row("環境", 20, -600, -40, -30, 1, 12, ""),

            new Row("社會", 0, 50, 1, 6, 1, 12, ""),
            new Row("社會", 1, 30, 0, 5, 1, 12, ""),
            new Row("社會", 2, 0, 8, 7, 1, 12, ""),
            new Row("社會", 3, 70, -2, 5, 1, 12, ""),
            new Row("社會", 4, 10, 8, 6, 1, 12, ""),
            new Row("社會", 5, 40, 5, 5, 1, 12, ""),
            new Row("社會", 6, 30, 4, 7, 1, 12, ""),
            new Row("社會", 7, 20, 7, 5, 1, 12, ""),
            new Row("社會", 8, 40, 3, 4, 1, 12, ""),
            new Row("社會", 9, 60, -2, 4, 1, 12, ""),
            new Row("社會", 10, 20, 7, 8, 1, 12, ""),
            new Row("社會", 11, 0, 9, 7, 1, 12, ""),
            new Row("社會", 12, 40, -1, 5, 1, 12, ""),
            new Row("社會", 13, 50, 3, 7, 1, 12, ""),
            new Row("社會", 14, 20, 4, 6, 1, 12, ""),
            new Row("社會", 15, 10, 7, 7, 1, 12, "")

        };

        public static List<EventCardInfo> GetAllEventCards(string type)
        {
            var result = new List<EventCardInfo>();

            string CityToFolder(string c) => c switch
            {
                "四季" => "season",
                "天災" => "disaster",
                "政策" => "policy",
                "經濟" => "economics",
                "環境" => "environments",
                "社會" => "social",
                _ => c
            };

            foreach (var row in Rows)
            {
                if (row.Type == type)
                {
                    var folder = CityToFolder(type);
                    var img = $"/images/events/{folder}/{folder}{row.Index}.png";

                    var card = new EventCardInfo
                    {
                        Title = EventCardDESC.Title[type][row.Index],
                        Description = EventCardDESC.Desc[type][row.Index],
                        MoneyChange = row.Money,
                        EcoChange = row.Eco,
                        SocialChange = row.Social,
                        StartMonth = row.Start,
                        EndMonth = row.End,
                        ImagePath = img,
                        Type = type
                    };

                    result.Add(card);
                }
            }

            return result;
        }
    }
}
