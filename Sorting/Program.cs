using Sorting.manager;
using Sorting.print;
using Sorting.sorting.specials;
using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        // https://github.com/accj1990/Sorting.git
        // https://pt.overleaf.com/read/kptbxrwtrzch#8b9776

        //int escolha;
        int[] vet = ManagerFileReader.Arquivo10000TXT();
        //int[] vet = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        /*Console.WriteLine("Qual tamanho do arquivo que você quer ler:\n 1.10\n 2.100\n 3.1000\n 4.10000\n 5.100000\n 6.1000000");
        escolha = int.Parse(Console.ReadLine());

        switch(escolha)
        {
            case 1: vet = ManagerFileReader.Arquivo10TXT(); break;
            case 2: vet = ManagerFileReader.Arquivo100TXT(); break;
            case 3: vet = ManagerFileReader.Arquivo1000TXT(); break;
            case 4: vet = ManagerFileReader.Arquivo10000TXT(); break;
            case 5: vet = ManagerFileReader.Arquivo100000TXT(); break;
            case 6: vet = ManagerFileReader.Arquivo1000000TXT(); break;
        }*/
         
        //BUBBLESORT
        //Está certo
        /*
       PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.BUBBLESORT);

       ManagerFileSorting.Ordenar(Sorting.enums.Sortings.BUBBLESORT, vet);

       PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.BUBBLESORT);
        */
        
       // Crie um menu que solicite ao usuário qual é o arquivo que será lido e qual algoritmo deverá ser executado

       //Segure ctrl em cima do ordenar para ir direto para a pagina de ordenação e adicionar o SELECTIONSORT para comçar a ser chamado

       //SELECTIONSORT
       //Está funcionando
       /*
       PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.SELECTIONSORT);

       ManagerFileSorting.Ordenar(Sorting.enums.Sortings.SELECTIONSORT, vet);

       PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.SELECTIONSORT);
        */
       //INSERTIONSORT
       //Está funcionando
       /*
       PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.INSERTIONSORT);

       ManagerFileSorting.Ordenar(Sorting.enums.Sortings.INSERTIONSORT, vet);

       PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.INSERTIONSORT);
       */
        //COUNTINGSORT
        //Está funcionando

        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.COUNTINGSORT);

        ManagerFileSorting.Ordenar(Sorting.enums.Sortings.COUNTINGSORT, vet);


        //Pesquisar qual é o atributo no código utils/UtilCountingTime.cs que vai falar qual é o tempo de execução do código*/

        //Fazer os códigos a partir da pagina 89 do segundo link do topo

        //SHELLSORT
        //Tudo certo
        /*
        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.SHELLSORT);

        ManagerFileSorting.Ordenar(Sorting.enums.Sortings.SHELLSORT, vet);

        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.SHELLSORT);
        */
        //QuickSORT
        //Está certo
        /*
        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.QUICKSORT);

        ManagerFileSorting.Ordenar(Sorting.enums.Sortings.QUICKSORT, vet);

        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.QUICKSORT);
        */
        //Merge
        //Está certo
        /*
        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.MERGESORT);

        ManagerFileSorting.Ordenar(Sorting.enums.Sortings.MERGESORT, vet);

        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.MERGESORT);
        */
        //Radix não precisa fazer

        //Na primeira questão do slide é para considerar o tempo de execução
    }
}