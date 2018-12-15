using System.Net.Http;
using System.Threading.Tasks;
using Api.Controllers;
using Newtonsoft.Json;
using Xunit;

namespace Tests
{
    public class GetByNumber : ApiControllerTestBase
    {
        private HttpClient _client;

        public GetByNumber()
        {
            _client = base.GetClient();
        }

        [Theory]
        [InlineData("trivia")]
        public async Task ReturnsTestForTheNumber42(string controllerName)
        {
            var response = await _client.GetAsync($"/api/{controllerName}/42");
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<TriviaResponse>(stringResponse);

            Assert.Equal(42, result.Number);
            Assert.NotEmpty(result.Text);
        }
    }
}