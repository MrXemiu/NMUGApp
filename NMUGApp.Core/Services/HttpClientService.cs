using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Plugins.Messenger;
using Newtonsoft.Json;
using NMUGApp.Core.Models;

namespace NMUGApp.Core.Services
{
    public class HttpClientService : IHttpClientService
    {
        private readonly IMvxMessenger _messenger;

        private HttpClient _httpClient;

        public HttpClient HttpClient => _httpClient ?? (_httpClient = new HttpClient());

        public HttpClientService(IMvxMessenger messenger)
        {
            _messenger = messenger;
        }

        public async Task<T> GetJsonAsync<T>(Uri apiAddress, Dictionary<string, object> queryStringArgs = null)
        {
            var endPoint = AppendQueryStringArgs(apiAddress, queryStringArgs);
            var response = await SendHttpRequest<HttpResponseMessage>(HttpMethod.Get, endPoint, null);
            var jsonString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(jsonString);

            return result;
        }

        private static Uri AppendQueryStringArgs(Uri serviceEndPoint, Dictionary<string, object> queryStringArgs = null)
        {
            if (queryStringArgs == null || queryStringArgs.Count <= 0) return serviceEndPoint;

            var qsList = queryStringArgs.ToList();

            var builder = new UriBuilder(serviceEndPoint)
            {
                Query = string.Join("&", qsList.Select(pair => string.Join("=", pair.Key, pair.Value)))
            };
            return builder.Uri;
        }

        private async Task<HttpResponseMessage> SendHttpRequest<T>(HttpMethod method, Uri serviceEndPoint, T data)
        {
            _messenger.Publish(new BeforeExecuteRequestMsg(this));

            HttpResponseMessage response;

            try
            {
                response = await ExecuteRequest(method, serviceEndPoint, data);
            }
            finally
            {
                _messenger.Publish(new AfterExecuteRequestMsg(this));
            }

            return response;
        }

        private async Task<HttpResponseMessage> ExecuteRequest<T>(HttpMethod method, Uri serviceEndPoint, T data)
        {
            HttpResponseMessage response;

            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            switch (method.Method)
            {
                case "PUT":
                    throw new NotImplementedException();

                case "POST":
                    throw new NotImplementedException();

                case "DELETE":
                    throw new NotImplementedException();

                default:
                    response = await HttpClient.GetAsync(serviceEndPoint.AbsoluteUri).ConfigureAwait(false);
                    break;
            }

            return response;
        }

        private StringContent StringContentFrom<T>(T data)
        {
            var json = JsonConvert.SerializeObject(data);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }
    }
}
