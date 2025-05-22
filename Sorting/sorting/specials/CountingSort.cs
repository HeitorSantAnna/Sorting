using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using System.Diagnostics;

namespace Sorting.sorting.specials
{
    class CountingSort
    {
        public static int[] Sorting(int[] array, int n)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //Array para contar o numero de ocorrencias de cada elemento
            int[] count = new int[getMaior(array) + 1];
            int[] ordenado = new int[n];

            //Inicializar cada posicao do array de contagem
            for (int i = 0; i < count.Length; count[i] = 0, i++) ;

            //Agora, o count[i] contem o numero de elemento iguais a i
            for (int i = 0; i < n; count[array[i]]++, i++) ;

            /*Console.WriteLine("Agora, o count[i] contem o numero de elemento iguais a i");
            for (int i = 0; i < count.Length; i++)
            {
                Console.Write($"{count[i]}, ");
            }
            Console.WriteLine();*/

            //Agora, o count[i] contem o numero de elemento menores ou iguais a i
            for (int i = 1; i < count.Length; count[i] += count[i - 1], i++) ;
            /*Console.WriteLine("Agora, o count[i] contem o numero de elemento menores ou iguais a i");
            for (int i = 0; i < count.Length; i++)
            {
                Console.Write($"{count[i]}, ");
            }*/

            //Ordenando
            for (int i = n - 1; i >= 0; ordenado[count[array[i]] - 1] = array[i], count[array[i]]--, i--) ;

            /*for(int i = 0; i < n; i++)
            {
                Console.Write($"{ordenado[i]}, ");
            }
            Console.WriteLine();*/
            stopwatch.Stop();

            Console.WriteLine($"Tempo de execução: {stopwatch}");
            return ordenado;
        }

        static int getMaior(int[] array)
        {
            int maior = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > maior)
                {
                    maior = array[i];
                }
            }

            return maior;
        }
    }
}
