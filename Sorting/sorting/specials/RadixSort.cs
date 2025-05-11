namespace Sorting.sorting.specials
{
    class RadixSort
    {
        public static int[] Sorting(int[] array, int n)
        {
            //Array para contar o numero de ocorrencias de cada elemento
            int[] count = new int[getMaior(array, n) + 1];
            int[] ordenado = new int[n];
            //Inicializar cada posicao do array de contagem
            for (int i = 0; i < count.Length; count[i] = 0, i++) ;
            //Agora, o count[i] contem o numero de elemento iguais a i
            for (int i = 0; i < n; count[array[i]]++, i++) ;
            //Agora, o count[i] contem o numero de elemento menores ou iguais a i
            for (int i = 1; i < count.Length; count[i] += count[i - 1], i++) ;
            //Ordenando
            for (int i = n - 1; i >= 0; ordenado[count[array[i]] - 1] = array[i], count[array[i]]--, i--) ; return array;
        }

        static int getMaior(int[] array, int n)
        {
            int maior = array[0];
            for (int i = 1; i < n; i++)
            {
                if (array[i] > maior)
                { maior = array[i]; }
            }
            return maior;
        }
    }
}
