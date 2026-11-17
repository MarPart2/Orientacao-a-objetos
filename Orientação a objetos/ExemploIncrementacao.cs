using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientação_a_objetos
{
    internal class ExemploIncrementacao
    {
        static string MeuMetodo(string pais = "Brasil")
        {
           return (pais);
           
        }

        static public void Main(string[] args)
        {
            MeuMetodo("Canada");
            MeuMetodo("Espanha");
            MeuMetodo();
            MeuMetodo("Russia");
        }
    }
}
