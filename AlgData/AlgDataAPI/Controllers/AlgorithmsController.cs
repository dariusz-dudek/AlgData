namespace AlgDataAPI.Controllers
{
    [Route("[action]")]
    [ApiController]
    public class AlgorithmsController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _config;

        public AlgorithmsController(IHttpClientFactory httpClientFactory, IConfiguration config)
        {
            _httpClient = httpClientFactory.CreateClient();
            _config = config;
        }

        [HttpPost("{sortMethod}")]
        public async Task<IActionResult> SortAsync(string sortMethod, List<int> list)
        {
            var response = await _httpClient.PostAsJsonAsync($"{_config.GetValue<string>("AlgorithmsApiBaseUrl")}/{sortMethod}", list);
            return Ok(await response.Content.ReadAsStringAsync());
        }
    }
}