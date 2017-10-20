using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NMUGApp.Core.Services
{
    public interface IHttpClientService
    {
        Task<T> GetJsonAsync<T>(Uri apiAddress, Dictionary<string, object> queryStringArgs = null);
    }
}
