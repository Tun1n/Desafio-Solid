using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LSP.Violação
{
    // A classe Quadrado está violando o Princípio de Substituição de Liskov (LSP) pois a classe derivada altera o comportamento esperado da classe base.
    public class Quadrado : Retângulo
    {
        public override double Altura { get => base.Altura; set => base.Altura = value; }
        public override double Largura { get => base.Largura; set => base.Largura = value; }
    }
}
