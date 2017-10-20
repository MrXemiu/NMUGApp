// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var data = PressReleaseQueryResult.FromJson(jsonString);
//

using Newtonsoft.Json;

namespace NMUGApp.Core.Models
{
    public partial class ResponseInfo
    {
        [JsonProperty("developerMessage")]
        public string DeveloperMessage { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }
    }
}
