using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OCP.Violação
{
    // A classe CalculadoraDeDesconto está violando o Princípio Aberto/Fechado (OCP) pois cada vez que um novo tipo de cliente é adicionado, será necessário modificar esta classe.
    public class CalculadoraDeDesconto
    {
        public double CalcularDesconto(string tipoProduto, double valor)
        {
            if (tipoProduto == "Eletronico")
            {
                return valor * 0.1;
            }
            else if (tipoProduto == "Roupas")
            {
                return valor * 0.2;
            }
            else
            {
                return 0;

            }
        }
    }
}
