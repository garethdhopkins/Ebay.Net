using EbayNet;
using Newtonsoft.Json;

namespace BrowseAPIs.Models
{
    public static class Serialize
    {
        public static string ToJson(this ItemGroupModel self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this ItemModel self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this ItemSummaryCollectionModel self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this ItemSummaryModel self) => JsonConvert.SerializeObject(self, Converter.Settings);

    }
}
