namespace BinarySearch
{
    public class Binary
    {
        public static int Search(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            int middle;

            while (left <= right)
            {
                middle = (left + right) / 2;

                if (arr[middle] == target) return middle;

                else if (target < arr[middle]) right = middle - 1;

                else left = middle + 1;
            }

            return -1;
        }
    }
}