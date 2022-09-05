using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlgorithmsAPI.Controllers
{
    [Route("[action]")]
    [ApiController]
    public class AlgorithmsController : ControllerBase
    {
        private readonly IAlgorithms _algoritms;

        public AlgorithmsController(IAlgorithms algoritms)
        {
            _algoritms = algoritms;
        }

        [HttpPost]
        public ActionResult<IResponse> BubbleSort(List<int> list)
            => Ok(_algoritms.BubbleSort(list));

        [HttpPost]
        public ActionResult<IResponse> InsertionSort(List<int> list)
            => Ok(_algoritms.InsertionSort(list));

        [HttpPost]
        public ActionResult<IResponse> QuickSort(List<int> list)
            => Ok(_algoritms.QuickSort(list));

        [HttpPost]
        public ActionResult<IResponse> MergeSort(List<int> list)
            => Ok(_algoritms.MergeSort(list));

        [HttpPost]
        public ActionResult<IResponse> SelectionSort(List<int> list)
            => Ok(_algoritms.SelectionSort(list));
    }
}
