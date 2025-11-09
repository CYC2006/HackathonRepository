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
            new Row("四季", 0, 600, 0, 4, 2, 5, ""),
            new Row("四季", 1, -1000, 4, 3, 4, 6, ""),
            new Row("四季", 0, 300, 0, 2, 3, 5, ""),
            new Row("四季", 1, -200, 4, 3, 5, 6, ""),
            new Row("四季", 2, 400, -3, 2, 6, 8, ""),
            new Row("四季", 3, -100, 3, 2, 9, 11, ""),
            new Row("四季", 4, 500, -2, 2, 1, 2, ""),
            new Row("四季", 5, -200, 4, 1, 3, 5, ""),
            new Row("四季", 6, 400, -3, 3, 6, 8, ""),
            new Row("四季", 7, 200, 5, 4, 9, 11, ""),
            new Row("四季", 8, -300, 5, 2, 1, 2, ""),
            new Row("四季", 9, -200, 6, 3, 6, 8, ""),
            new Row("四季", 10, 200, -3, 2, 9, 11, ""),
            new Row("四季", 11, -100, 4, 2, 1, 2, ""),
            new Row("四季", 12, 500, -2, 3, 3, 5, ""),
            new Row("四季", 13, -300, 7, 4, 3, 5, ""),
            new Row("四季", 14, -200, 4, 3, 9, 11, ""),
            new Row("四季", 15, 300, -2, 2, 6, 8, ""),
            new Row("四季", 16, -100, 3, 2, 1, 2, ""),

            new Row("天災", 0, -400, -3, -2, 5, 10, ""),
            new Row("天災", 1, -600, -4, -3, 1, 12, ""),
            new Row("天災", 2, -200, -1, -1, 1, 12, ""),
            new Row("天災", 3, -500, -2, -3, 9, 11, ""),
            new Row("天災", 4, -300, -3, -2, 1, 5, ""),
            new Row("天災", 5, -200, -2, -1, 1, 2, ""),
            new Row("天災", 6, -300, -1, -2, 5, 10, ""),
            new Row("天災", 7, -400, -4, -4, 1, 12, ""),
            new Row("天災", 8, -300, 0, -2, 1, 2, ""),
            new Row("天災", 9, -400, -3, -1, 9, 11, ""),
            new Row("天災", 10, -100, -2, -2, 6, 8, ""),
            new Row("天災", 11, -500, -5, -3, 5, 10, ""),
            new Row("天災", 12, -600, -4, -3, 1, 12, ""),
            new Row("天災", 13, -200, -1, 0, 1, 12, ""),
            new Row("天災", 14, -300, -2, -1, 9, 11, ""),
            new Row("天災", 15, -500, -3, -2, 1, 12, ""),
            new Row("天災", 16, -400, -2, -3, 1, 12, ""),
            new Row("天災", 17, -300, -1, -2, 5, 10, ""),
            new Row("天災", 18, -600, 1, -3, 6, 9, ""),

            new Row("政策", 0, 300, 5, 3, 1, 12, ""),
            new Row("政策", 1, -200, 6, 4, 1, 12, ""),
            new Row("政策", 2, 200, 4, 3, 1, 12, ""),
            new Row("政策", 3, 400, 5, 4, 1, 12, ""),
            new Row("政策", 4, 300, 3, 2, 1, 12, ""),
            new Row("政策", 5, -300, 7, 3, 1, 12, ""),
            new Row("政策", 6, 200, 2, 3, 1, 12, ""),
            new Row("政策", 7, -100, 5, 4, 1, 12, ""),
            new Row("政策", 8, 500, 4, 3, 1, 12, ""),
            new Row("政策", 9, -400, 8, 5, 1, 12, ""),
            new Row("政策", 10, 300, 4, 4, 1, 12, ""),
            new Row("政策", 11, 100, 3, 2, 1, 12, ""),
            new Row("政策", 12, -200, 5, 3, 1, 12, ""),
            new Row("政策", 13, 600, 3, 3, 1, 12, ""),
            new Row("政策", 14, 200, 2, 2, 1, 12, ""),
            new Row("政策", 15, 300, 5, 4, 9, 11, ""),
            new Row("政策", 16, -300, 8, 5, 1, 12, ""),
            new Row("政策", 17, -200, 6, 4, 1, 12, ""),
            new Row("政策", 18, 400, 5, 3, 1, 12, ""),
            new Row("政策", 19, 200, 3, 3, 1, 12, ""),

            new Row("經濟", 0, 500, -3, 2, 1, 12, ""),
            new Row("經濟", 1, 400, -2, 3, 1, 12, ""),
            new Row("經濟", 2, 600, -4, 2, 1, 12, ""),
            new Row("經濟", 3, 300, 0, 2, 9, 11, ""),
            new Row("經濟", 4, 500, -3, 2, 1, 12, ""),
            new Row("經濟", 5, 200, 2, 1, 1, 12, ""),
            new Row("經濟", 6, -200, 6, 3, 1, 12, ""),
            new Row("經濟", 7, 300, -4, 1, 1, 12, ""),
            new Row("經濟", 8, -100, 5, 3, 1, 12, ""),
            new Row("經濟", 9, 400, -2, 2, 1, 12, ""),
            new Row("經濟", 10, 500, -3, 2, 1, 12, ""),
            new Row("經濟", 11, 200, 3, 1, 1, 12, ""),
            new Row("經濟", 12, 600, -2, 3, 1, 12, ""),
            new Row("經濟", 13, -300, 7, 4, 1, 12, ""),
            new Row("經濟", 14, 400, -2, 1, 1, 12, ""),
            new Row("經濟", 15, 600, -3, 2, 1, 12, ""),
            new Row("經濟", 16, 500, -4, 3, 1, 12, ""),
            new Row("經濟", 17, 300, -2, 2, 9, 11, ""),

            new Row("環境", 0, -200, 6, 3, 1, 12, ""),
            new Row("環境", 1, 200, -3, 2, 1, 12, ""),
            new Row("環境", 2, -300, 7, 4, 1, 12, ""),
            new Row("環境", 3, 100, 4, 3, 1, 12, ""),
            new Row("環境", 4, -400, 5, 2, 1, 12, ""),
            new Row("環境", 5, 300, 6, 4, 1, 12, ""),
            new Row("環境", 6, -200, 5, 2, 1, 12, ""),
            new Row("環境", 7, 400, -2, 3, 1, 12, ""),
            new Row("環境", 8, 200, -4, 1, 1, 12, ""),
            new Row("環境", 9, -400, 8, 4, 1, 12, ""),
            new Row("環境", 10, -100, 6, 3, 1, 12, ""),
            new Row("環境", 11, 300, -3, 2, 1, 12, ""),
            new Row("環境", 12, -300, 7, 4, 1, 12, ""),
            new Row("環境", 13, -200, 5, 2, 1, 12, ""),
            new Row("環境", 14, 200, -2, 3, 12, 2, ""),
            new Row("環境", 15, -400, 8, 4, 1, 12, ""),
            new Row("環境", 16, -200, 5, 3, 1, 12, ""),
            new Row("環境", 17, 100, 4, 3, 1, 12, ""),
            new Row("環境", 18, -300, 6, 4, 1, 12, ""),

            new Row("社會", 0, 200, 0, 5, 1, 12, ""),
            new Row("社會", 1, 300, -1, 4, 1, 12, ""),
            new Row("社會", 2, -100, 6, 5, 1, 12, ""),
            new Row("社會", 3, 400, -3, 2, 1, 12, ""),
            new Row("社會", 4, 500, -2, 3, 1, 12, ""),
            new Row("社會", 5, -200, 7, 4, 1, 12, ""),
            new Row("社會", 6, 300, -1, 4, 1, 12, ""),
            new Row("社會", 7, 200, 2, 5, 1, 12, ""),
            new Row("社會", 8, -300, 6, 4, 1, 12, ""),
            new Row("社會", 9, 200, 1, 3, 1, 12, ""),
            new Row("社會", 10, 400, -2, 3, 1, 12, ""),
            new Row("社會", 11, 100, 0, 4, 1, 12, ""),
            new Row("社會", 12, -200, 6, 5, 1, 12, ""),
            new Row("社會", 13, 300, -1, 3, 1, 12, ""),
            new Row("社會", 14, 200, 2, 4, 1, 12, ""),
            new Row("社會", 15, -100, 4, 3, 1, 12, ""),
            new Row("社會", 16, 400, -2, 3, 1, 12, ""),
            new Row("社會", 17, 300, -1, 4, 1, 12, ""),
            new Row("社會", 18, 200, 1, 3, 1, 12, "")
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
