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

        public static readonly List<SustainEffect> Effects = new()
        {
            new SustainEffect { Til = "台積電宣布設廠", Tar = "Money", Min = 100, Max = 200, Dur = -1 },
            new SustainEffect { Til = "中央山脈現稀土礦脈", Tar = "Money", Min = 300, Max = 500, Dur = 4 },
            new SustainEffect { Til = "中央山脈現稀土礦脈", Tar = "EcoScore", Min = -20, Max = -10, Dur = -4 },
            new SustainEffect { Til = "發現史前巨型遺址", Tar = "SocialScore", Min = 30, Max = 35, Dur = 8 },
            new SustainEffect { Til = "國際AI總部進駐", Tar = "Money", Min = 100, Max = 200, Dur = -1 },
        };

        public static SustainEffect? GetEffect(string title)
        {
            return Effects.Find(e => e.Til == title);
        }
    }
}