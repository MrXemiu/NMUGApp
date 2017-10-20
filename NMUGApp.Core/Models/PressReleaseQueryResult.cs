// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var data = PressReleaseQueryResult.FromJson(jsonString);
//

using System.Collections.Generic;
using Newtonsoft.Json;

namespace NMUGApp.Core.Models
{
    public partial class PressReleaseQueryResult
    {
        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("results")]
        public List<Result> Results { get; set; }
    }

    public partial class PressReleaseQueryResult
    {
        public static PressReleaseQueryResult FromJson(string json) => JsonConvert.DeserializeObject<PressReleaseQueryResult>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this PressReleaseQueryResult self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}
