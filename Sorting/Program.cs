using Sorting.basic_class;
using Sorting.manager;
using Sorting.print;
using Sorting.sorting.specials;
using System.Diagnostics;
using System.Net.Http.Headers;

public class Program
{
    public static void Main(string[] args)
    {
        // https://github.com/accj1990/Sorting.git
        // https://pt.overleaf.com/read/kptbxrwtrzch#8b9776

        Pilha<string> pilha = new Pilha<string>();
        Lista item = new Lista();
        Fila<string> fila = new Fila<string>();

        int escolha;
        int[] vetor;
        string[] vector = ManagerFileReader.Arquivos10TXT();
        int[] vet = ManagerFileReader.Arquivo10000TXT();
        ArvoreBinaria<int> arvoreBinaria = new ArvoreBinaria<int>();
        TabelaHash<string> tabelaHash = new TabelaHash<string>(vector.Length); ;

        Console.WriteLine("Qual tamanho do arquivo que você quer ler:\n 1.10\n 2.100\n 3.1000\n 4.10000\n 5.100000\n 6.1000000");
        escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1: vet = ManagerFileReader.Arquivo10TXT(); vetor = ManagerFileReader.Arquivo10TXT(); vector = ManagerFileReader.Arquivos10TXT(); tabelaHash = new TabelaHash<string>(vector.Length); foreach (int valor in vetor)
                {
                    arvoreBinaria.Inserir(valor);
                }
                foreach(string valor in vector)
                {
                    tabelaHash.Inserir(valor);
                    pilha.II(valor);
                    item.Inserir(valor);
                    fila.II(valor);
                }
                break;
            case 2: vet = ManagerFileReader.Arquivo100TXT(); vetor = ManagerFileReader.Arquivo100TXT();  vector = ManagerFileReader.Arquivos100TXT(); tabelaHash = new TabelaHash<string>(vector.Length); foreach (int valor in vetor)
                {
                    arvoreBinaria.Inserir(valor);
                }
                foreach (string valor in vector)
                {
                    tabelaHash.Inserir(valor);
                    pilha.II(valor);
                    item.Inserir(valor);
                    fila.II(valor);
                }
                break;
            case 3: vet = ManagerFileReader.Arquivo1000TXT(); vetor = ManagerFileReader.Arquivo1000TXT(); vector = ManagerFileReader.Arquivos1000TXT(); tabelaHash = new TabelaHash<string>(vector.Length); foreach (int valor in vetor)
                {
                    arvoreBinaria.Inserir(valor);
                }
                foreach (string valor in vector)
                {
                    tabelaHash.Inserir(valor);
                    pilha.II(valor);
                    item.Inserir(valor);
                    fila.II(valor);
                }
                break;
            case 4: vet = ManagerFileReader.Arquivo10000TXT(); vetor = ManagerFileReader.Arquivo10000TXT(); vector = ManagerFileReader.Arquivos10000TXT(); tabelaHash = new TabelaHash<string>(vector.Length); foreach (int valor in vetor)
                {
                    arvoreBinaria.Inserir(valor);
                }
                foreach (string valor in vector)
                {
                    tabelaHash.Inserir(valor);
                    pilha.II(valor);
                    item.Inserir(valor);
                    fila.II(valor);
                }
                break;
            case 5: vet = ManagerFileReader.Arquivo100000TXT(); vetor = ManagerFileReader.Arquivo100000TXT(); vector = ManagerFileReader.Arquivos100000TXT(); tabelaHash = new TabelaHash<string>(vector.Length); foreach (int valor in vetor)
                {
                    arvoreBinaria.Inserir(valor);
                }
                foreach (string valor in vector)
                {
                    tabelaHash.Inserir(valor);
                    pilha.II(valor);
                    item.Inserir(valor);
                    fila.II(valor);
                }
                break;
            case 6: vet = ManagerFileReader.Arquivo1000000TXT(); vetor = ManagerFileReader.Arquivo1000000TXT(); vector = ManagerFileReader.Arquivos1000000TXT(); tabelaHash = new TabelaHash<string>(vector.Length); foreach (int valor in vetor)
                {
                    arvoreBinaria.Inserir(valor);
                }
                foreach (string valor in vector)
                {
                    tabelaHash.Inserir(valor);
                    pilha.II(valor);
                    item.Inserir(valor);
                    fila.II(valor);
                }
                break;
            default: Main(args); break;
        }

        Console.WriteLine("Qual você quer usar?\n 1.Bubble;\n 2.Selection;\n 3.Insertion;\n 4.Couting;\n 5.Shell;\n 6.Quick;\n 7.Merge;");
        escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {

            //BUBBLESORT
            //Está certo
            case 1:
                PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.BUBBLESORT);

                ManagerFileSorting.Ordenar(Sorting.enums.Sortings.BUBBLESORT, vet);

                PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.BUBBLESORT);
                break;

            // Crie um menu que solicite ao usuário qual é o arquivo que será lido e qual algoritmo deverá ser executado

            //Segure ctrl em cima do ordenar para ir direto para a pagina de ordenação e adicionar o SELECTIONSORT para comçar a ser chamado

            //SELECTIONSORT
            //Está funcionando
            case 2:
                PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.SELECTIONSORT);

                ManagerFileSorting.Ordenar(Sorting.enums.Sortings.SELECTIONSORT, vet);

                PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.SELECTIONSORT);
                break;
            //INSERTIONSORT
            //Está funcionando
            case 3:
                PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.INSERTIONSORT);

                ManagerFileSorting.Ordenar(Sorting.enums.Sortings.INSERTIONSORT, vet);

                PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.INSERTIONSORT);
                break;
            //COUNTINGSORT
            //Está funcionando
            case 4:
                PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.COUNTINGSORT);

                ManagerFileSorting.Ordenar(Sorting.enums.Sortings.COUNTINGSORT, vet);
                break;
            //SHELLSORT
            //Tudo certo
            case 5:
                PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.SHELLSORT);

                ManagerFileSorting.Ordenar(Sorting.enums.Sortings.SHELLSORT, vet);

                PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.SHELLSORT);
                break;
            //QuickSORT
            //Está certo
            case 6:
                PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.QUICKSORT);

                ManagerFileSorting.Ordenar(Sorting.enums.Sortings.QUICKSORT, vet);

                PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.QUICKSORT);
                break;
            //Merge
            //Está certo
            case 7:
                PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.MERGESORT);

                ManagerFileSorting.Ordenar(Sorting.enums.Sortings.MERGESORT, vet);

                PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.MERGESORT);
                break;
            default: Main(args); break;
        }
        //Radix não precisa fazer

        Console.WriteLine("A partir daqui é a Árvore Binária:");

        arvoreBinaria.Mostrar();
        Console.WriteLine();

        Console.WriteLine("A partir daqui é a Tabela Hash");

        tabelaHash.Mostrar();
        Console.WriteLine();

        Console.WriteLine("Pilha:");

        item.Mostrar();
        Console.WriteLine();

        Console.WriteLine("Lista:");

        item.Mostrar();
        Console.WriteLine();

        Console.WriteLine("Fila");

        fila.Mostrar();
    }

    public class Nodo<T> where T : IComparable<T>
    {
        public T valor;
        public Nodo<T> esq;
        public Nodo<T> dir;

        public Nodo(T valor)
        {
            this.valor = valor;
        }
    }

    public class ArvoreBinaria<T> where T: IComparable<T>
    {
        public Nodo<T> raiz;

        public ArvoreBinaria()
        {
            this.raiz = null;
        }

        public void Inserir(T valor)
        {
            raiz = Inserir(valor, raiz);
        }

        public Nodo<T> Inserir(T valor, Nodo<T> n)
        {
            if(n == null)
            {
                n = new Nodo<T>(valor);
            }
            else
            {
                if(valor.CompareTo(n.valor) < 0)
                {
                    n.esq = Inserir(valor, n.esq);
                }
                else if(valor.CompareTo(n.valor) > 0)
                {
                    n.dir = Inserir(valor, n.dir);
                }
                else
                {
                    throw new Exception($"Error: Não é possível inserir elementos repetidos.");
                }
            }

            return n;
        }

        public void Mostrar()
        {
            Console.WriteLine("[");
            Mostrar(raiz);
            Console.WriteLine("]");
        }

        private void Mostrar(Nodo<T> n)
        {
            if(n != null)
            {
                Mostrar(n.esq);
                Console.WriteLine($"{n.valor}, ");
                Mostrar(n.dir);
            }
        }

        public bool Pesquisar(T valor)
        {
            return (Pesquisar(valor, raiz));
        }

        private bool Pesquisar(T valor, Nodo<T> n)
        {
            if(n == null)
            {
                return false;
            }
            else
            {
                if(valor.CompareTo(n.valor) < 0)
                {
                    return Pesquisar(valor, n.esq);
                }
                else if(valor.CompareTo(n.valor) > 0)
                {
                    return Pesquisar(valor, n.dir);
                }
                else
                {
                    return true;
                }
            }
        }

        public void Remover(T valor)
        {
            raiz = Remover(valor, raiz);
        }

        private Nodo<T> Remover(T valor, Nodo<T> n)
        {
            if(n == null)
            {
                throw new Exception($"ERRO: Elemento {valor} não existe na árvore");
            }
            else
            {
                if(valor.CompareTo(n.valor) < 0)
                {
                    n.esq = Remover(valor, n.esq);
                }
                else if(valor.CompareTo(n.valor) > 0)
                {
                    n.dir = Remover(valor, n.dir);
                }
                else
                {
                    if(n.esq == null && n.dir == null)
                    {
                        return null;
                    }
                    else if(n.esq != null && n.dir == null)
                    {
                        return n.esq;
                    }
                    else if(n.esq == null && n.dir != null)
                    {
                        return n.dir;
                    }
                    else
                    {
                        n.dir = SubstituiMenorDireita(n, n.dir);
                    }
                }
            }

            return n;
        }

        private Nodo<T> SubstituiMenorDireita(Nodo<T> n, Nodo<T> aux)
        {
            if(aux.esq != null)
            {
                aux.esq = SubstituiMenorDireita(n, aux.esq);
            }
            else
            {
                n.valor = aux.valor;
                return aux.dir;
            }

            return aux;
        }
    }

    public class NodoH<T>
    {
        public T valor;
        public bool utilizado;

        public NodoH(T valor)
        {
            this.valor = valor;
            utilizado = true;
        }
    }

    public class TabelaHash<T>
    {
        public NodoH<T>[] tabela;

        public TabelaHash(int tamanho)
        {
            this.tabela = new NodoH<T>[tamanho];
        }

        private int funcaoHash(T valor)
        {
            int indice = 0;
            string valorString = valor.ToString();

            for(int i = 0; i < valorString.Length; i++)
            {
                indice += (int)valorString[i] * i;
            }

            indice = indice % tabela.Length;

            return indice;
        }

        public void Inserir(T valor)
        {
            int indice = funcaoHash(valor);
            int count = 0;

            while(count < tabela.Length)
            {
                if (tabela[indice] == null)
                {
                    tabela[indice] = new NodoH<T>(valor);
                    break;
                }
                else if (tabela[indice].utilizado == false)
                {
                    tabela[indice].valor = valor;
                    tabela[indice].utilizado = true;
                    break;
                }
                else
                {
                    indice = (indice + 1) % tabela.Length;
                    count++;
                }
            }

            if(count == tabela.Length)
            {
                throw new Exception("Não é possível inserir tabela cheia");
            }
        }

        public void Mostrar()
        {
            for(int i = 0; i < tabela.Length; i++)
            {
                if (tabela[i] != null && tabela[i].utilizado == true)
                {
                    Console.WriteLine($"[{i}] --> {tabela[i].valor.ToString()}");
                }
            }
        }

        public bool Pesquisar(T valor)
        {
            int indice = funcaoHash(valor);
            int count = 0;

            while(count < tabela.Length)
            {
                if (tabela[indice] == null)
                {
                    return false;
                }
                else if (tabela[indice] != null && tabela[indice].utilizado == true && Equals(tabela[indice].valor, valor))
                {
                    return true;
                }
                else
                {
                    indice = (indice + 1) % tabela.Length;
                    count++;
                }
            }

            return false;
        }

        public void Remover(T valor)
        {
            int indice = funcaoHash(valor);
            int count = 0;

            while(count < tabela.Length)
            {
                if (tabela[indice] == null)
                {
                    throw new Exception("Não foi possível remover: Elemento não existe");
                }
                else if (tabela[indice] != null && tabela[indice].utilizado == true && Equals(tabela[indice].valor, valor))
                {
                    tabela[indice].utilizado = false;
                    break;
                }
                else
                {
                    indice = (indice + 1) % tabela.Length;
                    count++;
                }
            }

            if(count == tabela.Length)
            {
                throw new Exception("Não foi possível remover: Elemento não existe");
            }
        }
    }
}