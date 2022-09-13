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


        //private readonly HttpClient _httpClient;

        //public DataStructureController(IHttpClientFactory httpClientFactory)
        //{
        //    _httpClient = httpClientFactory.CreateClient();
        //}

        //private async Task<ContentResult> ProxyTo(string url)
        //    => Content(await _httpClient.GetStringAsync(url));

        //[HttpGet]
        //public async Task<IActionResult> Stack()
        //    => await ProxyTo("http://datastructureapi/api/datastructure/stack");

        //[HttpGet]
        //public async Task<IActionResult> LinkedList()
        //    => await ProxyTo("http://datastructureapi/api/datastructure/linkedlist");

        //[HttpGet]
        //public async Task<IActionResult> Graph()
        //    => await ProxyTo("http://datastructureapi/api/datastructure/graph");

        //[HttpGet]
        //public async Task<IActionResult> Queue()
        //    => await ProxyTo("http://datastructureapi/api/datastructure/queue");

        //[HttpGet]
        //public async Task<IActionResult> BinarySearchTree()
        //    => await ProxyTo("http://datastructureapi/api/datastructure/binarysearchtree");

        //[HttpGet]
        //public async Task<IActionResult> HashTable()
        //    => await ProxyTo("http://datastructureapi/api/datastructure/hashtable");
    }
}
