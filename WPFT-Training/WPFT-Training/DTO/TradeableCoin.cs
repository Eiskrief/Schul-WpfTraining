using Newtonsoft.Json;

namespace WPFT_Training.DTO
{
    public class TradeableCoin
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; set; }
        [JsonProperty(PropertyName = "rank")]
        public string Rank { get; set; }
        [JsonProperty(PropertyName = "price_usd")]
        public string PriceUsd { get; set; }
        [JsonProperty(PropertyName = "24h_volume_usd")]   
        public string VolumeUsd24H { get; set; }
        [JsonProperty(PropertyName = "market_cap_usd")]
        public string MarketCapUsd { get; set; }
        [JsonProperty(PropertyName = "available_supply")]
        public string AvailableSupply { get; set; }
        [JsonProperty(PropertyName = "total_supply")]
        public string TotalSupply { get; set; }
        [JsonProperty(PropertyName = "percent_change_1h")]
        public string PercentChange1H { get; set; }
        [JsonProperty(PropertyName = "percent_change_24h")]
        public string PercentChange24H { get; set; }
        [JsonProperty(PropertyName = "percent_change_7d")]
        public string PercentChange7D { get; set; }
        [JsonProperty(PropertyName = "last_updated")]
        public string LastUpdated { get; set; }
    }
}
