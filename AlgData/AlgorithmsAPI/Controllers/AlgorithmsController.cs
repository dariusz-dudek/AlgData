using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlgorithmsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlgorithmsController : ControllerBase
    {
        private readonly IAlgoritms _algoritms;

        public AlgorithmsController(IAlgoritms algoritms)
        {
            _algoritms = algoritms;
        }

        [HttpPost]
        [Route("BubbleSort")]
        public ActionResult<IResponse> BubbleSort(List<int> list)
            => Ok(_algoritms.BubbleSort(list));

        [HttpPost]
        [Route("InsertionSort")]
        public ActionResult<IResponse> InsertionSort(List<int> list)
            => Ok(_algoritms.InsertionSort(list));

        [HttpPost]
        [Route("QuickSort")]
        public ActionResult<IResponse> QuickSort(List<int> list)
            => Ok(_algoritms.QuickSort(list));
    }
}
