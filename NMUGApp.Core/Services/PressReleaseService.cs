using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using QuickType;

namespace NMUGApp.Core.Services
{
    public class PressReleaseService : IPressReleaseService
    {
        public const string DojPressReleaseApiUrlBase = "https://www.justice.gov/api/v1/press_releases.json";

        private readonly IHttpClientService _httpClient;

        public PressReleaseService(IHttpClientService httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PressReleaseQueryResult> GetPressReleaseQueryResult(int pageSize, int pageNumber)
        {
            var apiUriBase = new UriBuilder(DojPressReleaseApiUrlBase);

            var queryStringArgs = new Dictionary<string,object>{
                { nameof(pageSize), pageSize},
                { nameof(pageNumber), pageNumber}
            };

            return await _httpClient.GetJsonAsync<PressReleaseQueryResult>(apiUriBase.Uri, queryStringArgs);
        }
    }
}
