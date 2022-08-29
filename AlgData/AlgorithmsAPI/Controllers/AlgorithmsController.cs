using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlgorithmsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlgorithmsController : ControllerBase
    {
        private readonly IAlghoritms _alghoritms;

        public AlgorithmsController(IAlghoritms alghoritms)
        {
            _alghoritms = alghoritms;
        }

        [HttpPost]
        [Route("BubbleSort")]
        public ActionResult<IResponse> BubbleSort([FromQuery] List<int> list)
        {
            var result = _alghoritms.BubbleSort(list);
            return Ok(result);
        }
    }
}
