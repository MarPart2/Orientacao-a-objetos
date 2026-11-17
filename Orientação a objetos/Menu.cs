using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientação_a_objetos
{
    internal class Menu
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - ExemploReturn");
            Console.WriteLine("2 - ExemploDoisParametros");
            Console.WriteLine("3 - ExemploIncrementacao");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    ExemploReturn.Main(args);
                    break;
                case "2":
                    Console.Clear();
                    ExemploDoisParametros.Main(args);
                    break;
                case "3":
                    Console.Clear();
                    ExemploIncrementacao.Main(args);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
