using System.Collections.Generic;

namespace Hackathon.Data
{
    // 單張卡片的資料結構
    public class CardInfo
    {
        public string Description { get; set; } = "";  // 敘述
        public int MoneyChange { get; set; }           // 金錢變動量
        public int EcoChange { get; set; }             // 環保評分變動量
        public int SocialChange { get; set; }          // 社會觀感變動量
    }

    public static class CardData
    {
        // 取得指定地區的卡片清單
        public static List<CardInfo> GetCardsForCity(string cityName)
        {
            return cityName switch
            {
                // ===== 台南 =====
                "台南" => new List<CardInfo>
                {
                    new CardInfo { Description = CardDescriptions.Descriptions["台南"][0], MoneyChange = -500, EcoChange = +10, SocialChange = +2 },
                    new CardInfo { Description = CardDescriptions.Descriptions["台南"][1], MoneyChange = -200, EcoChange = +3, SocialChange = +8 },
                    new CardInfo { Description = CardDescriptions.Descriptions["台南"][2], MoneyChange = -300, EcoChange = +7, SocialChange = +1 },
                    new CardInfo { Description = CardDescriptions.Descriptions["台南"][3], MoneyChange = +150, EcoChange = +4, SocialChange = +6 },
                    new CardInfo { Description = CardDescriptions.Descriptions["台南"][4], MoneyChange = -400, EcoChange = +5, SocialChange = +3 }
                },

                // ===== 台北 =====
                "台北" => new List<CardInfo>
                {
                    new CardInfo { Description = CardDescriptions.Descriptions["台南"][0], MoneyChange = -500, EcoChange = +10, SocialChange = +2 },
                    new CardInfo { Description = CardDescriptions.Descriptions["台南"][1], MoneyChange = -200, EcoChange = +3, SocialChange = +8 },
                    new CardInfo { Description = CardDescriptions.Descriptions["台南"][2], MoneyChange = -300, EcoChange = +7, SocialChange = +1 },
                    new CardInfo { Description = CardDescriptions.Descriptions["台南"][3], MoneyChange = +150, EcoChange = +4, SocialChange = +6 },
                    new CardInfo { Description = CardDescriptions.Descriptions["台南"][4], MoneyChange = -400, EcoChange = +5, SocialChange = +3 }
                },

                // ===== 高雄 =====
                "高雄" => new List<CardInfo>
                {
                    new CardInfo { Description = CardDescriptions.Descriptions["台南"][0], MoneyChange = -500, EcoChange = +10, SocialChange = +2 },
                    new CardInfo { Description = CardDescriptions.Descriptions["台南"][1], MoneyChange = -200, EcoChange = +3, SocialChange = +8 },
                    new CardInfo { Description = CardDescriptions.Descriptions["台南"][2], MoneyChange = -300, EcoChange = +7, SocialChange = +1 },
                    new CardInfo { Description = CardDescriptions.Descriptions["台南"][3], MoneyChange = +150, EcoChange = +4, SocialChange = +6 },
                    new CardInfo { Description = CardDescriptions.Descriptions["台南"][4], MoneyChange = -400, EcoChange = +5, SocialChange = +3 }
                },

                // ===== 預設：其他地區 =====
                _ => new List<CardInfo>
                {
                    new CardInfo { Description = $"{cityName} 卡 #1", MoneyChange = 0, EcoChange = 0, SocialChange = 0 },
                    new CardInfo { Description = $"{cityName} 卡 #2", MoneyChange = 0, EcoChange = 0, SocialChange = 0 },
                    new CardInfo { Description = $"{cityName} 卡 #3", MoneyChange = 0, EcoChange = 0, SocialChange = 0 },
                    new CardInfo { Description = $"{cityName} 卡 #4", MoneyChange = 0, EcoChange = 0, SocialChange = 0 },
                    new CardInfo { Description = $"{cityName} 卡 #5", MoneyChange = 0, EcoChange = 0, SocialChange = 0 }
                }
            };
        }
    }
}