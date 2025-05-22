using Sorting.manager;
using Sorting.print;
using Sorting.reader;

namespace Sorting.basic_class
{
    /*public class Program
    {
        public static void Main(string[] args)
        {
            Pilha<string> pilha = new Pilha<string>();

            string[] vet = ManagerFileReader.Arquivo100TXT();

            pilha.II("24");
            pilha.II("2345");
            pilha.II("8747");

            for (int i = 0; i < vet.Length; i++)
            {
                pilha.Empilhar(vet[i]);
            }

            pilha.Mostrar();
        }
    }*/

    public class Pilha<T>
    {
        public No<T> topo;

        public Pilha()
        {
            topo = null;
        }

        public void Empilhar(T valor)
        {
            No<T> n = new No<T>(valor);
            n.embaixo = topo;
            topo = n;
        }

        public void II(T valor)
        {
            No<T> nova = new No<T>(valor);

            if (topo == null)
            {
                topo = nova;
            }
            else
            {
                topo.embaixo = nova;
                topo = nova;
            }
        }

        public void Mostrar()
        {
            Console.Write($"[");
            for(No<T> n = topo; n != null; n = n.embaixo)
            {
                Console.Write($"{n.valor.ToString()}, ");
            }
            Console.Write("]");
        }
    }

    public class No<T>
    {
        public T valor;
        public No<T> embaixo;

        public No(T valor)
        {
            this.valor = valor;
            embaixo = null;
        }
    }
}
