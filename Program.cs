using System;
using Business;

namespace CRUD
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            bool escolheuSair = false;

            while (!escolheuSair)
            {
                Console.Clear();
                Console.WriteLine("==============================");
                Console.WriteLine("      CRUD DE CLIENTES");
                Console.WriteLine("==============================");
                Console.WriteLine("1 - Cadastrar Cliente\n2 - Pesquisar Cliente\n3 - Lista de Clientes\n4 - Remover Cliente\n5 - Sair");
                Console.WriteLine("Selecione a opçao desejada: ");
                string opçao = Console.ReadLine();
                int opint = int.Parse(opçao);
                if (opint == 5) break;

                CrudClienteServices.opçaoSelecionada(opint);
            }
            Console.Clear();
        }

    }
}

