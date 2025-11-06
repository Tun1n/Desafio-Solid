using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LSP.Solução
{
    public class Retangulo : Figura
    {
        public double Largura { get; set; }
        public double Altura { get; set; }
        public override double Area() => Largura * Altura;
    }
}
