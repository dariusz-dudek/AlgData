using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlgDataAPI.Controllers
{
    [Route("[action]")]
    [ApiController]
    public class AlghoritmsController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly string _url = "https://localhost:7239";

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

        [HttpPost]
        public async Task<IActionResult> InsertionSort(List<int> list)
        {
            var response = await _httpClient.PostAsJsonAsync($"{_url}/InsertionSort", list);
            return Ok(await response.Content.ReadAsStringAsync());
        }

        [HttpPost]
        public async Task<IActionResult> QuickSort(List<int> list)
        {
            var response = await _httpClient.PostAsJsonAsync($"{_url}/QuickSort", list);
            return Ok(await response.Content.ReadAsStringAsync());
        }

        [HttpPost]
        public async Task<IActionResult> MergeSort(List<int> list)
        {
            var response = await _httpClient.PostAsJsonAsync($"{_url}/MergeSort", list);
            return Ok(await response.Content.ReadAsStringAsync());
        }

        [HttpPost]
        public async Task<IActionResult> SelectionSort(List<int> list)
        {
            var response = await _httpClient.PostAsJsonAsync($"{_url}/SelectionSort", list);
            return Ok(await response.Content.ReadAsStringAsync());
        }
    }
}