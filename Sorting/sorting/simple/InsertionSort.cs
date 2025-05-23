using System.Diagnostics;

namespace Sorting.sorting.simple
{
    class InsertionSort
    {
        public static int[] Sorting(int[] vet)
        {
            int j, x;
            long quant = 0;
            int n = vet.Length;
            for (int i = 1; i < n; i++)
            {
                x = vet[i];
                j = i - 1;
                quant++;
                while (j >= 0 && vet[j] > x)
                {
                    vet[j + 1] = vet[j];
                    j--;
                    quant++;
                }
                vet[j + 1] = x;
                quant++;
            }

            Console.WriteLine($"Tempo de execução: {quant}");

            return vet;
        }
    }
}
