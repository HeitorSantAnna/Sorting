using System.Security.Cryptography;
using System;

namespace Sorting.sorting.efficient
{
    class HeapSort
    {
        /*public static int[] Sorting(int[] ver, int n)
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
                swap(ver, 1, tam--);
                reconstruir(ver, tam);

                return ver;
            }
        }

        static void construir(int[] ver, int tam)
        {
            for (int i = tam; i > 1 && ver[i] > ver[i / 2]; i /= 2)
            {
                swap(ver, i, i / 2);
            }
        }

        static void swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        static int getMaiorFilho(int[] array, int i, int tam)
        {
            int filho;
            if (2 * i == tam || array[2 * i] > array[2 * i + 1])
            {
                filho = 2 * i;
            }
            else
            {
                filho = 2 * i + 1;
            }
            return filho;
        }

        static boolean hasFilho(int i, int tam)
        {
            return (i <= (tam / 2));
        }


        static void reconstruir(int[] array, int tam)
        {
            int i = 1;
            while (hasFilho(i, tam) == true)
            {
                int filho = getMaiorFilho(array, i, tam);
                if (array[i] < array[filho])
                {
                    swap(array, i, filho);
                    i = filho;
                }
                else
                {
                    i = tam;
                }
            }
        }*/
    }
}
