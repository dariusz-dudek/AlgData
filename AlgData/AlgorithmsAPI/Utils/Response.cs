namespace AlgorithmsAPI.Utils
{
    public class Response : IResponse
    {
        public List<int>? SortedList { get; set; }
        public float TimeOfCalculation { get; set; }
    }
}
