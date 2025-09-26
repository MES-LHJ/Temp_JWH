using ApiEmpManagement.Model.Dto;
using ApiEmpManagement.Service.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ApiEmpManagement.Service
{
    public sealed class EmployeeService
    {
        private static readonly Lazy<EmployeeService> _instance = new Lazy<EmployeeService>(() => new EmployeeService());
        public static EmployeeService Instance => _instance.Value;

        private readonly JavaScriptSerializer _serializer = new JavaScriptSerializer();
        private readonly HttpClient _client;
        private const string BaseUrl = "http://test.smartqapis.com:5000/api/Employee";

        private EmployeeService()
        {
            _client = ApiClient.Instance.HttpClient;
        }

        private void SetAuthorizationHeader(string token)
        {
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
        }

        public async Task<List<EmployeeDto>> GetEmployeesAsync(string token, int factoryId)
        {
            SetAuthorizationHeader(token);

            HttpResponseMessage response = await _client.GetAsync($"{BaseUrl}?factoryId={factoryId}");
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            EmployeeApiResponse apiResponse = _serializer.Deserialize<EmployeeApiResponse>(json);

            if (!string.IsNullOrEmpty(apiResponse?.Error))
                throw new Exception($"API Error: {apiResponse.Error}");

            return apiResponse?.Data ?? new List<EmployeeDto>();
        }

        public async Task<bool> AddEmployeeAsync(string token, EmployeeAddDto employee)
        {
            SetAuthorizationHeader(token);

            string json = _serializer.Serialize(employee);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.PostAsync(BaseUrl, content);
            response.EnsureSuccessStatusCode();

            string result = await response.Content.ReadAsStringAsync();
            var apiResponse = _serializer.Deserialize<EmployeeAddResponse>(result);

            if (!string.IsNullOrEmpty(apiResponse?.Error))
                throw new Exception($"사원 추가 실패: {apiResponse.Error}");

            return true;
        }

        public async Task<bool> UpdateEmployeeAsync(string token, long employeeId, EmployeeUpdateDto dto)
        {
            SetAuthorizationHeader(token);

            string json = _serializer.Serialize(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.PutAsync($"{BaseUrl}/{employeeId}", content);
            response.EnsureSuccessStatusCode();

            string result = await response.Content.ReadAsStringAsync();
            if (result.Contains("\"Error\":\"") && !result.Contains("\"Error\":null"))
                throw new Exception("서버 오류 발생: " + result);

            return true;
        }

        public async Task<bool> DeleteEmployeeAsync(string token, long employeeId)
        {
            SetAuthorizationHeader(token);

            HttpResponseMessage response = await _client.DeleteAsync($"{BaseUrl}/{employeeId}");
            response.EnsureSuccessStatusCode();

            string result = await response.Content.ReadAsStringAsync();
            if (result.Contains("\"Error\":\"") && !result.Contains("\"Error\":null"))
                throw new Exception("서버 오류 발생: " + result);

            return true;
        }
    }
}
