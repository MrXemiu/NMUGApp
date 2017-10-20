// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var data = PressReleaseQueryResult.FromJson(jsonString);
//

using Newtonsoft.Json;

namespace NMUGApp.Core.Models
{
    public partial class Resultset
    {
        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("pagesize")]
        public long Pagesize { get; set; }
    }
}
