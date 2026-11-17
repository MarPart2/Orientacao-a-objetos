using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientação_a_objetos
{
    internal class ExemploReturn
    {
        static string MeuMetodo(string Nome)
        {
            return (Nome + " é um belo nome");
        }

        static public void Main(string[] args)
        {
            Console.WriteLine("Concatenação e informações passadas por parametro e return");
            Console.WriteLine("");
            Console.WriteLine(MeuMetodo("Algo"));
            Console.WriteLine(MeuMetodo("Gabsdd"));
        }
    }
}
