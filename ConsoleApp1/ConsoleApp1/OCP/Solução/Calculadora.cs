using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OCP.Solução
{
    /* A classe Calculadora está de acordo com o Princípio Aberto/Fechado (OCP) pois está aberta para extensão (novos tipos de calculadoras de desconto podem ser criados) 
     * e fechada para modificação (não é necessário alterar esta classe para adicionar novos tipos de desconto).*/

    public abstract class Calculadora
    {
        public abstract double CalcularDesconto(double valorCompra);
    }
}
