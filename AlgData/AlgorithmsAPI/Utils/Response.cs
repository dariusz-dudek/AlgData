namespace AlgorithmsAPI.Utils
{
    public class Response : IResponse
    {
        public List<int>? SortedList { get; set; }
        public float TicksOfCalculation { get; set; }
    }
}
