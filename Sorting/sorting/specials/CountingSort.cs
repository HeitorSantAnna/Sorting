namespace Sorting.sorting.specials
{
    class CountingSort
    {
        public int[] Sorting(int[] arr, int max)
        {
            int[] count = new int[max + 1];
            int[] output = new int[arr.Length];

            foreach(var num in arr)
            {
                count[num]++;
            }

            for (int i = 1; i <= max; i++) count[i] += count[i - 1];

            for(int i = arr.Length - 1; i >= 0; i--)
            {
                output[count[arr[i]] - 1] = arr[i];
                count[arr[i]]--;
            }

            return arr;
        }
    }
}
