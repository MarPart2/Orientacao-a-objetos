using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientação_a_objetos
{
    internal class ExemploDoisParametros
    {
        static string MeuMetodo(string nome, int idade)
        {
            return ($"{nome} é seu nome e tem {idade} anos");
        }
        static public void Main(string[] args)
        {
            Console.WriteLine(MeuMetodo("josé", 1));
            Console.WriteLine(MeuMetodo("Sebastião", 35));
            Console.WriteLine(MeuMetodo("Renato", 25));
        }
    }
}
