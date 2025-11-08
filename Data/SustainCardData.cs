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
        };

        public static SustainEffect? GetEffect(string title)
        {
            return Effects.Find(e => e.Til == title);
        }
    }
}