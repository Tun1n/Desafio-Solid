using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OCP.Solução
{
    public class CalculadoraDeDescontoEletronico : Calculadora
    {
        public override double CalcularDesconto(double valorCompra) => valorCompra * 0.1;
    }
}
