using Sorting.manager;
using Sorting.print;
using Sorting.sorting.specials;

public class Program
{
    public static void Main(string[] args)
    {
        // https://github.com/accj1990/Sorting.git
        // https://pt.overleaf.com/read/kptbxrwtrzch#8b9776

        int[] vet = ManagerFileReader.Arquivo10TXT();

        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.BUBBLESORT);

        ManagerFileSorting.Ordenar(Sorting.enums.Sortings.BUBBLESORT, vet);

        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.BUBBLESORT);


        // Crie um menu que solicite ao usuário qual é o arquivo que será lido e qual algoritmo deverá ser executado

        /*Segure ctrl em cima do ordenar para ir direto para a pagina de ordenação e adicionar o CoutingSort para comçar a ser chamado*/
        int[] arr = ManagerFileReader.Arquivo100TXT();

        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.BUBBLESORT);

        ManagerFileSorting.Ordenar(Sorting.enums.Sortings.BUBBLESORT, vet);

        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.BUBBLESORT);
    }
}