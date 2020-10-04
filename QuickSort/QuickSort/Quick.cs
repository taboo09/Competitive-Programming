namespace QuickSort
{
    public class Quick
    {
        public static int[] Sort(int[] arr)
        {
            QS(arr, 0, arr.Length - 1);

            return arr;
        }

        private static void QS(int[] arr, int left, int right)
        {
            if (left >= right) return;
            
            int pivot = Partition(arr, left, right);

            QS(arr, left, pivot - 1);
            QS(arr, pivot + 1, right);
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];

            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp2 = arr[right];
            arr[right] = arr[i + 1];
            arr[i + 1] = temp2;

            return i + 1;
        }
    }
}