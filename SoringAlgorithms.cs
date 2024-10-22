namespace Ufar.Homework
{
    public static class SortingAlgorithms
    {
        public static void BubbleSortRecursive(int[] array)
        {
            BubbleSortRecursiveHelper(array, array.Length);
        }

        private static void BubbleSortRecursiveHelper(int[] array, int n)
        {
            if (n == 1)
                return;

            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    // Swap array[i] and array[i + 1]
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }

            BubbleSortRecursiveHelper(array, n - 1);
        }
        public static void InsertionSortRecursive(int[] array)
        {
            InsertionSortRecursiveHelper(array, array.Length);
        }

        private static void InsertionSortRecursiveHelper(int[] array, int n)
        {
            if (n <= 1)
                return;
            InsertionSortRecursiveHelper(array, n - 1);
            int last = array[n - 1];
            int j = n - 2;
            while (j >= 0 && array[j] > last)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = last;
        }
        public static void SelectionSortRecursive(int[] array)
        {
            SelectionSortRecursiveHelper(array, 0, array.Length);
        }
        private static void SelectionSortRecursiveHelper(int[] array, int start, int n)
        {
            if (start >= n - 1)
                return;
            int minIndex = start;
            for (int i = start + 1; i < n; i++)
            {
                if (array[i] < array[minIndex])
                    minIndex = i;
            }
            int temp = array[start];
            array[start] = array[minIndex];
            array[minIndex] = temp;
            SelectionSortRecursiveHelper(array, start + 1, n);
        }
    }
}