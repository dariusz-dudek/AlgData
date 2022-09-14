namespace AlgDataAPI.Controllers
{
    [Route("[action]")]
    [ApiController]
    public class DataStructureController : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IConfiguration _config;

        public DataStructureController(IHttpClientFactory clientFactory, IConfiguration config)
        {
            _clientFactory = clientFactory;
            _config = config;
        }

        [HttpGet("{dataStructureName}")]
        public async Task<IActionResult> GetDataStructureAsync(string dataStructureName)
        {
            var client = _clientFactory.CreateClient();
            var response = await client.GetStringAsync($"{_config.GetValue<string>("DataStructuresApiBaseUrl")}/api/DataStructure/{dataStructureName}");

            return Content(response, MediaTypeNames.Application.Json);
        }
    }
}
