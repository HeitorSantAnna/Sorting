using Sorting.print;

namespace Sorting.sorting.efficient
{
    class ShellSort
    {
        //Achar a solução do pq não está 
        /*public static int[] Sorting(int[] vet)
        {
            //Não aparece o retorno
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
                }
            }
            PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, enums.Sortings.SHELLSORT);
            return vet;
        }*/

        public static int[] shellsort(int[] array, int n)
        {
            int h = 1;
            do { h = (h * 3) + 1; } while (h < n);
            do
            {
                h /= 3;
                for (int cor = 0; cor < h; cor++)
                {
                    insercaoPorCor(array, n, cor, h);
                }
            } while (h != 1);

            insercao(array, n);

            return array;
        }
        static void insercaoPorCor(int[] array, int n, int cor, int h)
        {
            for (int i = (h + cor); i < n; i += h)
            {
                int tmp = array[i];
                int j = i - h;
                while ((j >= 0) && (array[j] > tmp))
                {
                    array[j + h] = array[j];
                    j -= h;
                }
                array[j + h] = tmp;
            }
        }
        static void insercao(int[] array, int n)
        {
            for (int i = 1; i < n; i += 1)
            {
                int tmp = array[i];
                int j = i - 1;
                while ((j >= 0) && (array[j] > tmp))
                {
                    array[j + 1] = array[j];
                    j -= 1;
                }
                array[j + 1] = tmp;
            }
        }

    }
}
