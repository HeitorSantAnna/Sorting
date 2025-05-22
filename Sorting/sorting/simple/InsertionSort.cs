using System.Diagnostics;

namespace Sorting.sorting.simple
{
    class InsertionSort
    {
        public static int[] Sorting(int[] vet)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int j, x;
            int n = vet.Length;
            for (int i = 1; i < n; i++)
            {
                x = vet[i];
                j = i - 1;
                while (j >= 0 && vet[j] > x)
                {
                    vet[j + 1] = vet[j];
                    j--;
                }
                vet[j + 1] = x;
            }

            stopwatch.Stop();

            Console.WriteLine($"Tempo de execução: {stopwatch}");

            return vet;
        }
    }
}
