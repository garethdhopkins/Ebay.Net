namespace BrowseAPIs.Models
{
	using EbayNet;
	using Newtonsoft.Json;

    public partial class Category
    {
        [JsonProperty("categoryId")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long CategoryId { get; set; }
    }
}
