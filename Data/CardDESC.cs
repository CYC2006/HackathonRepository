using System.Collections.Generic;

namespace Hackathon.Data
{
    public static class CardDESC
    {
        // 每個城市的卡片標題
        public static readonly Dictionary<string, List<string>> Title = new()
        {
            ["台南"] = new List<string>
            {
                "AAA",
                "BBB",
                "CCC",
                "DDD",
                "EEE",
                "FFF",
                "GGG",
                "III",
                "JJJ",
                "KKK"
            },
            ["台北"] = new List<string>
            {
                "AAA",
                "BBB",
                "CCC",
                "DDD"
            },
            ["高雄"] = new List<string>
            {
                "AAA",
                "BBB",
                "CCC",
                "DDD"
            }
        };

        // 每個城市的卡片敘述列表
        public static readonly Dictionary<string, List<string>> Desc = new()
        {
            ["台南"] = new List<string>
            {
                "推動綠能示範區建設，建立地方能源轉型示範基地。",
                "老城區文化保存計畫，平衡發展與歷史保存。",
                "設立電動車充電站，鼓勵低碳交通使用。",
                "推廣永續觀光活動，培育在地導覽員。",
                "推動綠能示範區建設，建立地方能源轉型示範基地。",
                "老城區文化保存計畫，平衡發展與歷史保存。",
                "設立電動車充電站，鼓勵低碳交通使用。",
                "推廣永續觀光活動，培育在地導覽員。",
                "推廣永續觀光活動，培育在地導覽員。",
                "推廣永續觀光活動，培育在地導覽員。"
            },
            ["台北"] = new List<string>
            {
                "屋頂太陽能補助，鼓勵市民使用綠電。",
                "大眾運輸電動化計畫，逐步淘汰燃油公車。",
                "空氣品質改善計畫，減少PM2.5排放。",
                "垃圾強制分類推動，提升回收利用率。"
            },
            ["高雄"] = new List<string>
            {
                "港區綠能再生建設，推動海上風電。",
                "再生水處理廠啟用，循環再利用工業用水。",
                "污染源管理政策，降低重工業排放。",
                "淨零工業專區，結合低碳技術示範。"
            }
        };
    }
}