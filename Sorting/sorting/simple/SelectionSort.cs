using System.Diagnostics;

namespace Sorting.sorting.simple
{
    class SelectionSort
    {
        public static int[] Sorting(int[] vet)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int n = vet.Length;
            int min;
            for (int i = 0; i < n - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (vet[j] < vet[min])
                    {
                        min = j;
                    }
                }

                int tmp = vet[i];
                vet[i] = vet[min];
                vet[min] = tmp;
            }

            stopwatch.Stop();

            Console.WriteLine($"Tempo de execução: {stopwatch}");
            return vet;
        }
    }
}
