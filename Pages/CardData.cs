using System.Collections.Generic;

namespace Hackathon.Data
{
    // 提供每個地區對應的卡片內容
    public static class CardData
    {
        // 取得指定地名的卡片清單
        public static List<string> GetCardsForCity(string cityName)
        {
            return cityName switch
            {
                // ===== 範例：每個地區 5 張卡 =====
                "台南" => new List<string>
                {
                    "台南卡 #1：綠能示範區建設",
                    "台南卡 #2：老城區文化保存",
                    "台南卡 #3：啟動智慧交通計畫",
                    "台南卡 #4：設立電動車充電站",
                    "台南卡 #5：推廣永續觀光"
                },
                "台北" => new List<string>
                {
                    "台北卡 #1：大眾運輸電動化",
                    "台北卡 #2：屋頂太陽能補助",
                    "台北卡 #3：垃圾強制分類",
                    "台北卡 #4：空氣品質改善計畫",
                    "台北卡 #5：智慧建築節能方案"
                },
                "高雄" => new List<string>
                {
                    "高雄卡 #1：港區綠能再生\n123123",
                    "高雄卡 #2：再生水處理廠啟用",
                    "高雄卡 #3：污染源管理政策",
                    "高雄卡 #4：淨零工業專區",
                    "高雄卡 #5：環保教育中心"
                },
                // ===== 預設：其他地區共用卡 =====
                _ => new List<string>
                {
                    $"{cityName}卡 #1",
                    $"{cityName}卡 #2",
                    $"{cityName}卡 #3",
                    $"{cityName}卡 #4",
                    $"{cityName}卡 #5"
                }
            };
        }
    }
}