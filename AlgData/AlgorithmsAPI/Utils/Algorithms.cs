namespace AlgorithmsAPI.Utils
{
    public class Algorithms : IAlgorithms
    {
        private readonly IResponse _response;
        private readonly Stopwatch _stopwatch;

        public Algorithms(IResponse response)
        {
            _response = response;
            _stopwatch = new Stopwatch();
        }

        public IResponse BubbleSort(List<int> list)
        {
            _stopwatch.Start();
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                        (list[j + 1], list[j]) = (list[j], list[j + 1]);
                }
            }
            _stopwatch.Stop();
            var timeSpan = _stopwatch.ElapsedTicks;
            _response.SortedList = list;
            _response.TicksOfCalculation = timeSpan;
            return _response;
        }

        public IResponse InsertionSort(List<int> list)
        {
            _stopwatch.Start();
            for (int i = 0; i < list.Count; i++)
            {
                int val = list[i];
                int flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < list[j])
                    {
                        list[j + 1] = list[j];
                        j--;
                        list[j + 1] = val;
                    }
                    else
                    {
                        flag = 1;
                    }
                }
            }
            _stopwatch.Stop();
            var timeSpan = _stopwatch.ElapsedTicks;
            _response.SortedList = list;
            _response.TicksOfCalculation = timeSpan;
            return _response;
        }

        public IResponse MergeSort(List<int> list)
        {
            _stopwatch.Start();
            list = MergeSortMethod(list);
            _stopwatch.Stop();

            var timeSpan = _stopwatch.ElapsedTicks;
            _response.SortedList = list;
            _response.TicksOfCalculation = timeSpan;
            return _response;
        }

        private List<int> MergeSortMethod(List<int> list)
        {
            if (list.Count <= 1)
                return list;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = list.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(list[i]);
            }
            for (int i = middle; i < list.Count; i++)
            {
                right.Add(list[i]);
            }

            left = MergeSortMethod(left);
            right = MergeSortMethod(right);
            return Merge(left, right);
        }

        private List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }

        public IResponse QuickSort(List<int> list)
        {
            _stopwatch.Start();
            QuickSortMethod(list, 0, list.Count - 1);
            _stopwatch.Stop();

            var timeSpan = _stopwatch.ElapsedTicks;
            _response.SortedList = list;
            _response.TicksOfCalculation = timeSpan;
            return _response;
        }

        private void QuickSortMethod(List<int> list, int l, int r)
        {
            if (l < r)
            {
                var pi = PartitionToQuickSort(list, l, r);
                QuickSortMethod(list, l, pi - 1);
                QuickSortMethod(list, pi + 1, r);
            }
        }

        private void SwapToQuickSort(List<int> a, int i, int j)
            => (a[j], a[i]) = (a[i], a[j]);

        private int PartitionToQuickSort(List<int> a, int l, int r)
        {
            int ndx = l;
            int pivot = a[l];
            for (int i = l + 1; i <= r; i++)
            {
                if (a[i] < pivot)
                {
                    ndx++;
                    SwapToQuickSort(a, ndx, i);
                }
            }
            SwapToQuickSort(a, ndx, l);
            return ndx;
        }

        public IResponse SelectionSort(List<int> list)
        {
            _stopwatch.Start();
            int smolest;

            for (int i = 0; i < list.Count; i++)
            {
                smolest = i;

                for (int index = i + 1; index < list.Count; index++)
                {
                    if (list[index] < list[smolest])
                        smolest = index;
                }
                (list[i], list[smolest]) = (list[smolest], list[i]);
            }
            _stopwatch.Stop();

            var timeSpan = _stopwatch.ElapsedTicks;
            _response.SortedList = list;
            _response.TicksOfCalculation = timeSpan;
            return _response;
        }


        public IResponse TreeSort(List<int> list)
        {
            throw new NotImplementedException();
        }
    }
}
