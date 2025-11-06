using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LSP.Violação
{
    public class Retângulo
    {
        public virtual double Largura { get; set; }
        public virtual double Altura { get; set; }
        public double CalcularArea() => Largura * Altura;
    }
}
