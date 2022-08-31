namespace AlgorithmsAPI.Utils
{
    public interface IResponse
    {
        List<int>? SortedList { get; set; }
        float TicksOfCalculation { get; set; }
    }
}