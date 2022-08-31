namespace AlgorithmsAPI.Utils
{
    public interface IAlgoritms
    {
        IResponse BubbleSort(List<int> list);
        IResponse InsertionSort(List<int> list);
        IResponse MergeSort(List<int> list);
        IResponse QuickSort(List<int> list);
        IResponse SelectionSort(List<int> list);
        IResponse TreeSort(List<int> list);
    }
}