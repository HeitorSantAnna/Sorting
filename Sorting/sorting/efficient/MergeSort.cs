using System.Diagnostics;

namespace Sorting.sorting.efficient
{
    class MergeSort
    {
        public static int[] Sorting(int[] array, int esq, int dir)
        {
            int quant = 0;

            if (esq < dir)
            {
                int meio = (esq + dir) / 2;
                quant++;
                Sorting(array, esq, meio);
                Sorting(array, meio + 1, dir);
                intercalar(array, esq, meio, dir, ref quant);
            }

            Console.WriteLine($"Comparações: {quant}");

            return array;
        }

        static void intercalar(int[] array, int esq, int meio, int dir, ref int quant)
        {
            //Definir tamanho dos dois subarrays
            int nEsq = (meio + 1) - esq;
            int nDir = dir - meio;
            int[] arrayEsq = new int[nEsq + 1];
            int[] arrayDir = new int[nDir + 1];
            //Sentinela no final dos dois arrays
            arrayEsq[nEsq] = arrayDir[nDir] = 0x7FFFFFFF;
            int iEsq, iDir, i;
            //Inicializar primeiro subarray
            for (iEsq = 0; iEsq < nEsq; iEsq++)
            {
                arrayEsq[iEsq] = array[esq + iEsq];
                quant++;
            }
            //Inicializar segundo subarray
            for (iDir = 0; iDir < nDir; iDir++)
            {
                arrayDir[iDir] = array[(meio + 1) + iDir];
                quant++;
            }
            //Intercalacao propriamente dita
            for (iEsq = iDir = 0, i = esq; i <= dir; i++)
            {
                array[i] = (arrayEsq[iEsq] <= arrayDir[iDir]) ? arrayEsq[iEsq++] : arrayDir[iDir++];
                quant++;
            }
        }
    }
}
