using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlgDataAPI.Controllers
{
    [Route("[action]")]
    [ApiController]
    public class AlghoritmsController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly string _url = "https://localhost:7239/api/Algorithms";

        public AlghoritmsController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }


        [HttpPost]
        public async Task<IActionResult> BubbleSort(List<int> list)
        {
            var response = await _httpClient.PostAsJsonAsync($"{_url}/BubbleSort", list);
            return Ok(await response.Content.ReadAsStringAsync());
        }
    }
}