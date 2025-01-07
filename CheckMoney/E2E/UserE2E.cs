using Money.DTOs;
using System.Net;
using System.Net.Http.Json;

namespace CheckMoney.E2E
{
    public class UserE2E
    {
        private readonly HttpClient _httpClient;

        public UserE2E()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:5077/User")
            };
        }

        [Fact]
        public async Task createAnEmptyUser()
        {
            var response = await _httpClient.PostAsJsonAsync("", new {});
            var json = await response.Content.ReadFromJsonAsync<ValidationErrorDTO>();
            Console.Write(json);
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
            Assert.Equal("Validation Error",json!.Message);
        }
    }
}
