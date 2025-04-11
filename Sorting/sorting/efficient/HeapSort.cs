using System.Security.Cryptography;

namespace Sorting.sorting.efficient
{
    class HeapSort
    {
        public int[] Sortings(int[] ver, int n)
        {
            //Contrução do heap
            for (int tam = 2; tam <= n; tam++)
            {
                construir(ver, tam);
            }
            //Ordenacao propriamente dita
            int tam = n;
            while (tam > 1)
            {
                swap(1, tam--);
                reconstruir(tam);

                return ver;
            }
        }

        void construir(int[] ver, int tam)
        {
            for (int i = tam; i > 1 && ver[i] > ver[i / 2]; i /= 2)
            {
                swap(i, i / 2);
            }
        }

        void reconstruir(int tam)
        {
            int i = 1;
            while (hasFilho(i, tam) == true)
            {
                int filho = getMaiorFilho(i, tam);
                if (array[i] < array[filho])
                {
                    swap(i, filho);
                    i = filho;
                }
                else
                {
                    i = tam;
                }
            }
        }
    }
}
