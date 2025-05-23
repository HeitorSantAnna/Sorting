namespace Sorting.basic_class
{
    /*public class Program
    {
        public static void Main(string[] args)
        {
            Lista item = new Lista();

            item.Inserir("Machado");
            item.Inserir("Espada");
            item.Inserir("Arco");

            item.Remover("Flexa");

            item.Mostrar();
        }
    }*/

    public class Lista
    {
        public Item sent;
        public Item ult;

        public Lista()
        {
            this.sent = new Item("");
            ult = sent;
        }

        public void Inserir(string nome)
        {
            Item i = new Item(nome);
            ult.prox = i;
            ult = ult.prox;
        }

        public void Mostrar()
        {
            Console.Write("[");
            for(Item i = sent.prox; i != null; i = i.prox)
            {
                Console.Write($"{i.nome}, ");
            }
            Console.Write("]");
        }

        public void Remover(string nome)
        {
            Item ant = sent, atu = sent.prox;

            for (; atu != null; ant = ant.prox, atu = atu.prox)
            {
                if (atu.nome == nome)
                {
                    ant.prox = atu.prox;
                    if(ant.prox == null)
                    {
                        ult = ant;
                    }
                    break;
                }
            }

            if(atu == null)
            {
                throw new Exception($"Não é possivel encontrar o elemento {nome}");
            }
        }
    }

    public class Item
    {
        public string nome;
        public Item prox;

        public Item(string nome)
        {
            this.nome = nome;
        }
    }
}
