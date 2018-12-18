
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    // [ApiController]
    public class TriviaController : Controller
    {
        [HttpGet("{number}")]
        public async Task<TriviaResponse> GetAsync(int number)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("http://numbersapi.com/" + number + "?json");
            var triviaResult = await response.Content.ReadAsStringAsync();
            var responseObj = JsonConvert.DeserializeObject<TriviaResponse>(triviaResult);
            responseObj.Text += " Test Commit 2";
            return responseObj;
        }
    }
}
