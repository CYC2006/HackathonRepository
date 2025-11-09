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
            new Row("四季", 0, 80, 0, 4, 2, 5, ""),
            new Row("四季", 1, -100, 4, 3, 4, 6, ""),
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
