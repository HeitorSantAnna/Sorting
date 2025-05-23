using System.Diagnostics;

namespace Sorting.sorting.efficient
{
    class QuickSort
    {

        public static int[] Sorting(int[] vet, int esq, int dir)
        {

            int i = esq, j = dir, pivo = vet[(esq + dir) / 2], quantidade = 0, x = 0;
            while (i <= j)
            {
                while (vet[i] < pivo)
                {
                    i++;
                }

                while (vet[j] > pivo)
                {
                    j--;
                }

                if (i <= j)
                { swap(vet, i, j, ref quantidade);
                    i++;
                    j--;
                    quantidade++;
                }
            }
            if (esq < j)
            {
                Sorting(vet, esq, j);
            }

            if (i < dir)
            {
                Sorting(vet, i, dir);
            }

            if (x < 1)
            {
                Console.WriteLine($"Comparações: {quantidade}");
                x++;
            }

            return vet;
        }

        static void swap(int[] vet, int i, int j, ref int quant)
        {
            int aux;
            aux = vet[i];
            vet[i] = vet[j];
            vet[j] = aux;
            quant++;
        }
    }
}
