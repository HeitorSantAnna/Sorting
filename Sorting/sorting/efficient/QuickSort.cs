namespace Sorting.sorting.efficient
{
    class QuickSort
    {

        public static int[] Sorting(int[] vet, int esq, int dir)
        {
            int i = esq, j = dir, pivo = vet[(esq + dir) / 2];
            while (i <= j)
            {
                while (vet[i] < pivo)
                    i++;
                while (vet[j] > pivo)
                    j--;
                if (i <= j)
                { swap(vet, i, j);
                    i++;
                    j--; 
                }
            }
            if (esq < j)
                Sorting(vet, esq, j);
            if (i < dir)
                Sorting(vet, i, dir);
            
            return vet;
        }

        static void swap(int[] vet, int i, int j)
        {
            int aux;
            aux = vet[i];
            vet[i] = vet[j];
            vet[j] = aux;
        }
    }
}
