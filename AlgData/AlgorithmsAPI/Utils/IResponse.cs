namespace AlgorithmsAPI.Utils
{
    public interface IResponse
    {
        List<int>? SortedList { get; set; }
        float TimeOfCalculation { get; set; }
    }
}