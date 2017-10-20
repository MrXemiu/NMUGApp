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
    public partial class Result
    {
        [JsonProperty("component")]
        public List<Component> Component { get; set; }

        [JsonProperty("number")]
        public object Number { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("attachment")]
        public List<object> Attachment { get; set; }

        [JsonProperty("changed")]
        public string Changed { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("image")]
        public List<object> Image { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("teaser")]
        public object Teaser { get; set; }

        [JsonProperty("topic")]
        public List<object> Topic { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("vuuid")]
        public string Vuuid { get; set; }
    }
}
