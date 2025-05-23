using System.Diagnostics;

namespace Sorting.sorting.simple
{
    class SelectionSort
    {
        public static int[] Sorting(int[] vet)
        {
            int n = vet.Length;
            int min, quant = 0;
            for (int i = 0; i < n - 1; i++)
            {
                min = i;
                quant++;
                for (int j = i + 1; j < n; j++)
                {
                    if (vet[j] < vet[min])
                    {
                        min = j;
                        quant++;
                    }
                }

                int tmp = vet[i];
                vet[i] = vet[min];
                vet[min] = tmp;
                quant++;
            }

            Console.WriteLine($"Comparação: {quant}");
            return vet;
        }
    }
}
