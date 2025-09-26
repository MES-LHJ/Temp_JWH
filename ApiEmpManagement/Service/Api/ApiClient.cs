using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;

namespace ApiEmpManagement.Service.Api
{
    public class ApiClient 
    {
        private static readonly Lazy<ApiClient> _instance = new Lazy<ApiClient>(() => new ApiClient());
        private readonly HttpClient _httpClient;

        public static ApiClient Instance => _instance.Value;

        private ApiClient()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://test.smartqapis.com:5000/"),
                Timeout = TimeSpan.FromSeconds(30)
            };
        }

        public HttpClient HttpClient => _httpClient;
    }
}

