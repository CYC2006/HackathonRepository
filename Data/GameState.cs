namespace Hackathon.Data
{
    public class GameState
    {
        public int Money { get; set; } = 1000;
        public int EcoScore { get; set; } = 0;
        public int SocialScore { get; set; } = 0;
        public int Week { get; set; } = 1;
        public int PlayerIndex { get; set; } = 0;

        public void Reset()
        {
            Money = 1000;
            EcoScore = 0;
            SocialScore = 0;
            Week = 1;
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
    }
}