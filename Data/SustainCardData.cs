using System.Collections.Generic;

namespace Hackathon.Data
{
    public static class SustainCardData
    {
        public class SustainEffect
        {
            public string Til { get; set; } = ""; // card name
            public string Tar { get; set; } = ""; // type: Money, EcoScore, SocialScore
            public int Min { get; set; } // min of change
            public int Max { get; set; } // max of change
            public int Dur { get; set; } // week duration
        }

        // cannot show two variable changes in Card Page
        public static readonly List<SustainEffect> Effects = new()
        {
            new SustainEffect { Til = "台積電宣布設廠", Tar = "Money", Min = 100, Max = 200, Dur = -1 },
            new SustainEffect { Til = "中央山脈發現稀土礦脈", Tar = "Money", Min = 300, Max = 500, Dur = 4 },
            new SustainEffect { Til = "中央山脈發現稀土礦脈", Tar = "EcoScore", Min = -6, Max = -4, Dur = -4 },
            new SustainEffect { Til = "發現史前巨型遺址", Tar = "SocialScore", Min = 5, Max = 20, Dur = 8 },
            new SustainEffect { Til = "國際AI總部進駐", Tar = "Money", Min = 100, Max = 200, Dur = -1 },
            new SustainEffect { Til = "榮全球最佳宜居城", Tar = "SocialScore", Min = 5, Max = 30, Dur = -1 },
            new SustainEffect { Til = "桃機獲選全球最佳", Tar = "Money", Min = 100, Max = 150, Dur = -1 },
            new SustainEffect { Til = "設置離岸風力發電機", Tar = "EcoScore", Min = 4, Max = 5, Dur = -1 },
            new SustainEffect { Til = "國際精機大廠設總部", Tar = "Money", Min = 100, Max = 200, Dur = -1 },
            new SustainEffect { Til = "恆春核三廠爭議", Tar = "EcoScore", Min = -6, Max = 0, Dur = 6 },
            new SustainEffect { Til = "澎湖玄武岩獲世遺", Tar = "EcoScore", Min = 0, Max = 50, Dur = -1 },
            new SustainEffect { Til = "發現海底巨型油田", Tar = "Money", Min = 200, Max = 300, Dur = 6 }, 
            new SustainEffect { Til = "發現海底巨型油田", Tar = "EcoSocre", Min = -30, Max = -15, Dur = 6 },
        };

        public static SustainEffect? GetEffect(string title)
        {
            return Effects.Find(e => e.Til == title);
        }
    }
}