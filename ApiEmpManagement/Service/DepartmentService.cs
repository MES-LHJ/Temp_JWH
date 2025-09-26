using ApiEmpManagement.Model.Dto;
using ApiEmpManagement.Service.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ApiEmpManagement.Service
{
    public sealed class DepartmentService
    {
        private static readonly Lazy<DepartmentService> _instance = new Lazy<DepartmentService>(() => new DepartmentService());
        public static DepartmentService Instance => _instance.Value;

        private readonly JavaScriptSerializer _serializer = new JavaScriptSerializer();
        private readonly HttpClient _client;
        private const string BaseUrl = "http://test.smartqapis.com:5000/api/Department";

        private DepartmentService()
        {
            _client = ApiClient.Instance.HttpClient;
        }

        private void SetAuthorizationHeader(string token)
        {
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
        }

        public async Task<List<DepartmentDto>> GetDepartmentsAsync(string token) //조회
        {
            SetAuthorizationHeader(token);

            HttpResponseMessage response = await _client.GetAsync($"{BaseUrl}?factoryId=1");
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            DepartmentApiResponse apiResponse = _serializer.Deserialize<DepartmentApiResponse>(json);

            if (!string.IsNullOrEmpty(apiResponse?.Error))
                throw new Exception($"API Error: {apiResponse.Error}");

            return apiResponse?.Data ?? new List<DepartmentDto>();
        }
        public async Task<long> AddDepartmentAsync(string token, DepartmentAddDto dto) //추가
        {
            SetAuthorizationHeader(token);

            string json = _serializer.Serialize(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.PostAsync(BaseUrl, content);
            response.EnsureSuccessStatusCode();

            string result = await response.Content.ReadAsStringAsync();
            var apiResponse = _serializer.Deserialize<DepartmentAddResponse>(result);

            if (!string.IsNullOrEmpty(apiResponse?.Error))
                throw new Exception($"부서 추가 실패: {apiResponse.Error}");

            return apiResponse.Data; // 정상이라면 long 반환
        }
        public async Task UpdateDepartmentAsync(long? departmentId, string token, DepartmentAddDto dto)
        {
            SetAuthorizationHeader(token);

            string url = $"api/Department/{departmentId}";
            string json = _serializer.Serialize(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.PutAsync(url, content);
            string result = await response.Content.ReadAsStringAsync();

            var apiResponse = _serializer.Deserialize<DepartmentUpdateResponse<object>>(result);

            if (!string.IsNullOrEmpty(apiResponse?.Error))
                throw new Exception($"API Error: {apiResponse.Error}");
        }
        public async Task DeleteDepartmentAsync(long? departmentId, string token)
        {
            var client = ApiClient.Instance.HttpClient;
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            var response = await client.DeleteAsync($"api/Department/{departmentId}");
            string result = await response.Content.ReadAsStringAsync();

            var apiResponse = _serializer.Deserialize<DepartmentUpdateResponse<object>>(result);

            if (!string.IsNullOrEmpty(apiResponse?.Error))
                throw new Exception($"API Error: {apiResponse.Error}");
        }
    }
}

