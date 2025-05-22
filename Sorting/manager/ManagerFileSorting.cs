using Sorting.enums;
using Sorting.print;
using Sorting.sorting.efficient;
using Sorting.sorting.simple;
using Sorting.sorting.specials;
using System.Diagnostics;

namespace Sorting.manager
{
    class ManagerFileSorting
    {
        public static void Ordenar(Sortings algoritmo, int[] vet)
        {
            int[] ordenado;

            switch (algoritmo)
            {
                case Sortings.BUBBLESORT:
                    ordenado = BubbleSort.Sorting(vet);
                    break;

                case Sortings.SELECTIONSORT:
                    ordenado = SelectionSort.Sorting(vet);
                    break;

                case Sortings.INSERTIONSORT:
                    ordenado = InsertionSort.Sorting(vet);
                    break;

                case Sortings.BUCKETSORT:
                    
                    break;

                case Sortings.COUNTINGSORT:
                    ordenado = CountingSort.Sorting(vet, vet.Length);
                    PrintSolutionStatic.ImprimirArrayMesmaLinha(ordenado, Sorting.enums.Sortings.COUNTINGSORT);

                    break;

                case Sortings.RADIXSORT:
                    ordenado = RadixSort.Sorting(vet, vet.Length - 1);
                    break;

                case Sortings.SHELLSORT:
                    ordenado = ShellSort.shellsort(vet, vet.Length);
                    break;

                case Sortings.QUICKSORT:
                    ordenado = QuickSort.Sorting(vet, 0, vet.Length-1);
                    break;

                case Sortings.MERGESORT:
                    ordenado = MergeSort.Sorting(vet, 0, vet.Length - 1);
                    break;

                case Sortings.HEAPSORT:
                    //ordenado = HeapSort.Sorting(vet, vet.Length - 1);
                    break;
            }
        }
    }
}
