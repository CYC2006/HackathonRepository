using System.Reflection.Metadata.Ecma335;

namespace Hackathon.Data
{
    public class GameState
    {
        // Basic Variables
        public int Money { get; set; } = 1000;
        public int EcoScore { get; set; } = 0;
        public int SocialScore { get; set; } = 0;
        public int Week { get; set; } = 1;
        public int PlayerIndex { get; set; } = 0;


        // Sustain Cards
        public class Effect
        {
            public string Title { get; set; } = ""; // card name
            public string TargetVar { get; set; } = ""; // type: Money, EcoScore, SocialScore
            public int MinChange { get; set; } // min of change
            public int MaxChange { get; set; } // max of change
            public int Duration { get; set; } // week duration
        }
        public List<Effect> OngoingEffects { get; set; } = new();


        // Weekly Record System
        public class WeeklyRecord
        {
            public int Money { get; set; }
            public int EcoScore { get; set; }
            public int SocialScore { get; set; }
        }
        public List<WeeklyRecord> History { get; set; } = new();


        // Game Initialize
        public GameState() { RecordWeek(); }


        // Record when end of week
        public void RecordWeek()
        {
            History.Add(new WeeklyRecord
            {
                Money = Money,
                EcoScore = EcoScore,
                SocialScore = SocialScore
            });
        }


        // Reset
        public void Reset()
        {
            Money = 1000;
            EcoScore = 0;
            SocialScore = 0;
            Week = 1;

            History.Clear();
            RecordWeek();
        }


        // Card Collection System
        public List<CardInfo> CollectedCards { get; set; } = new();

        public bool HasCard(CardInfo card)
        {
            return CollectedCards.Exists(c => c.Title == card.Title && c.Description == card.Description);
        }

        public void AddCard(CardInfo card)
        {
            if (!HasCard(card))
                CollectedCards.Add(card);
        }

        // Sustain Card Collection System
        public void AddOngoingEffect(string source, string target, int min, int max, int duration)
        {
            int endWeek = (duration == -1) ? 48 : Week + duration;
            OngoingEffects.Add(new Effect
            {
                Title = source,
                TargetVar = target,
                MinChange = min,
                MaxChange = max,
                Duration = duration // -1 means permanent
            });
        }

        // Event Card Record System
        public List<EventCardInfo> TriggeredEvents { get; set; } = new();

        public bool HasEvent(EventCardInfo e)
        {
            return TriggeredEvents.Exists(ev =>
                ev.Description == e.Description && ev.Type == e.Type);
        }

        public void AddEvent(EventCardInfo e)
        {
            if (!HasEvent(e))
                TriggeredEvents.Add(e.Clone());
        }

        public void ApplyWeeklyEffects()
        {
            var rand = new Random();
            var expired = new List<Effect>(); // for store Cards that duration = 0

            foreach (var e in OngoingEffects)
            {
                int delta = rand.Next(e.MinChange, e.MaxChange + 1);

                switch (e.TargetVar)
                {
                    case "Money": Money += delta; break;
                    case "EcoScore": EcoScore += delta; break;
                    case "SocialScore": SocialScore += delta; break;
                }

                if (e.Duration > 0)
                {
                    e.Duration--;
                    if (e.Duration == 0) expired.Add(e);
                }
            }

            foreach (var e in expired) OngoingEffects.Remove(e);
        }

        public void ClearEffects() => OngoingEffects.Clear();   
    }
}