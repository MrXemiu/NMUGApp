// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var data = PressReleaseQueryResult.FromJson(jsonString);
//
namespace QuickType
{

    using Newtonsoft.Json;
    public partial class Component
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }
}
