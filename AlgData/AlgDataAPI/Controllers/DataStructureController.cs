namespace AlgDataAPI.Controllers
{
    [Route("[action]")]
    [ApiController]
    public class DataStructureController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public DataStructureController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        private async Task<ContentResult> ProxyTo(string url)
            => Content(await _httpClient.GetStringAsync(url));

        [HttpGet]
        public async Task<IActionResult> Stack()
            => await ProxyTo("https://localhost:7187/api/datastructure/stack");

        [HttpGet]
        public async Task<IActionResult> LinkedList()
            => await ProxyTo("https://localhost:7187/api/datastructure/linkedlist");

        [HttpGet]
        public async Task<IActionResult> Graph()
            => await ProxyTo("https://localhost:7187/api/datastructure/graph");

        [HttpGet]
        public async Task<IActionResult> Queue()
            => await ProxyTo("https://localhost:7187/api/datastructure/queue");

        [HttpGet]
        public async Task<IActionResult> BinarySearchTree()
            => await ProxyTo("https://localhost:7187/api/datastructure/binarysearchtree");

        [HttpGet]
        public async Task<IActionResult> HashTable()
            => await ProxyTo("https://localhost:7187/api/datastructure/hashtable");
    }
}
