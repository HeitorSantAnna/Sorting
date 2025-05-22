using Sorting.manager;
using Sorting.print;
using Sorting.reader;

namespace Sorting.basic_class
{
    /*public class Program
    {
        public static void Main()
        {
            Fila<string> fila = new Fila<string>();

            string[] vet = ManagerFileReader.Arquivo100TXT();

            for(int i = 0; i < vet.Length; i++)
            {
                fila.Enfileirar(vet[i]);
            }

            fila.II("120");
            fila.IF("2.000");

            fila.Mostrar();
        }
    }*/

    public class Nodo<T>
    {
        public T valor;
        public Nodo<T> prox;

        public Nodo(T valor)
        {
            this.valor = valor;
            prox = null;
        }
    }

    public class Fila<T>
    {
        public Nodo<T> inicio;
        public Nodo<T> fim;

        public Fila()
        {
            inicio = null;
            fim = null;
        }

        public void IF(T item)
        {
            Nodo<T> nova = new Nodo<T>(item);
            if(fim == null)
            {
                inicio = fim = nova;
            }
            else
            {
                fim.prox = nova;
                fim = nova;
            }
        }

        public void II(T item)
        {
            Nodo<T> nova = new Nodo<T>(item);

            if(inicio == null)
            {
                inicio = fim = nova;
            }
            else
            {
                nova.prox = inicio;
                inicio = nova;
            }
        }

        public void Enfileirar(T valor)
        {
            Nodo<T> n = new Nodo<T>(valor);

            if(inicio == null)
            {
                inicio = n;
                fim = inicio;
            }
            else
            {
                fim.prox = n;
                fim = n;
            }
        }

        public void Mostrar()
        {
            Console.Write("[");
            for(Nodo<T> n = inicio; n != null; n = n.prox)
            {
                Console.Write($"{n.valor.ToString()}, ");
            }
            Console.Write("]");
        }
    }
}
