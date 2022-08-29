namespace AlgorithmsAPI.Utils
{
    public class Alghoritms : IAlghoritms
    {
        private readonly IResponse _response;

        public Alghoritms(IResponse response)
        {
            _response = response;
        }

        public IResponse BubbleSort(List<int> list)
        {
            var start = DateTime.Now;
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                        (list[j + 1], list[j]) = (list[j], list[j + 1]);
                }
            }
            var stop = DateTime.Now;
            var timeSpan = (stop - start).Milliseconds;
            _response.SortedList = list;
            _response.TimeOfCalculation = timeSpan;
            return _response;
        }

    }
}
