using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LSP.Solução
{
    public class Quadrado : Figura
    {
        public double Lado { get; set; }
        public override double Area() => Lado * Lado;
    }
}
