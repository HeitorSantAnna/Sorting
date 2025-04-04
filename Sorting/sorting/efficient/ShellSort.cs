using Sorting.print;

namespace Sorting.sorting.efficient
{
    class ShellSort
    {
        //Achar a solução do pq não está 
        public static int[] Sorting(int[] vet)
        {
            int j, h, x, y, nn;
            int n = vet.Length;

            for(h = 1; h <= n; h = (3*h+1))
            {
                while(h > 1)
                {
                    h /= 3;
                    for(int k = 0; k < h; k++)
                    {
                        nn = ((n / h) + ((n % h > k) ? 1 : 0));
                        for(int i = 1; i < nn; i++)
                        {
                            x = vet[(i * h) + k];
                            j = i - 1;
                            y = vet[j * h + k];
                            while (j >= 0 && y > x)
                            {
                                vet[((j + 1) * h) + k] = vet[(j * h) + k];
                                j--;
                            }
                            vet[((j + 1) * h) + k] = x;
                        }
                    }

                    //PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, enums.Sortings.SHELLSORT);
                    break;
                }
            }

            return vet;
        }
    }
}
