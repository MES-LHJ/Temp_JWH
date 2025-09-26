using ApiEmpManagement.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ApiEmpManagement.Service.Api
{
    public class ApiService
    {
        private static readonly Lazy<ApiService> _instance =
            new Lazy<ApiService>(() => new ApiService());

        private readonly HttpClient _httpClient;
        private readonly JavaScriptSerializer _serializer = new JavaScriptSerializer();

        public string CompanyToken { get; private set; }
        public string EmployeeToken { get; private set; }

        public static ApiService Instance => _instance.Value;

        private ApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.Timeout = TimeSpan.FromSeconds(30);
        }

        // 1. 업체 토큰 요청
        public async Task<bool> AuthenticateCompanyAsync(string brn)
        {
            var bodyObj = new { Brn = brn };
            string json = _serializer.Serialize(bodyObj);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(
                "http://test.smartqapis.com:5001/api/Customers/authenticate",
                content);

            if (!response.IsSuccessStatusCode)
                return false;

            string result = await response.Content.ReadAsStringAsync();
            var companyResponse = _serializer.Deserialize<CompanyAuthResponse>(result);

            if (companyResponse != null && companyResponse.Data != null)
            {
                CompanyToken = companyResponse.Data.Token;
                return true;
            }

            return false;
        }

        // 2. 사원 토큰 요청
        public async Task<bool> AuthenticateEmployeeAsync(string loginId, string password)
        {
            if (string.IsNullOrEmpty(CompanyToken))
                throw new InvalidOperationException("먼저 업체 토큰을 받아와야 합니다.");

            var bodyObj = new { loginId = loginId, password = password };
            string json = _serializer.Serialize(bodyObj);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", CompanyToken);

            var response = await _httpClient.PostAsync(
                "http://test.smartqapis.com:5000/api/Login",
                content);

            if (!response.IsSuccessStatusCode)
                return false;

            string result = await response.Content.ReadAsStringAsync();
            var employeeResponse = _serializer.Deserialize<EmployeeAuthResponse>(result);

            if (employeeResponse != null && !string.IsNullOrEmpty(employeeResponse.Data))
            {
                EmployeeToken = employeeResponse.Data;
                return true;
            }

            return false;
        }
    }
}
