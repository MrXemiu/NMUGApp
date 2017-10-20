// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var data = PressReleaseQueryResult.FromJson(jsonString);
//
namespace QuickType
{

    using Newtonsoft.Json;
    public partial class Metadata
    {
        [JsonProperty("responseInfo")]
        public ResponseInfo ResponseInfo { get; set; }

        [JsonProperty("executionTime")]
        public double ExecutionTime { get; set; }

        [JsonProperty("resultset")]
        public Resultset Resultset { get; set; }
    }
}
