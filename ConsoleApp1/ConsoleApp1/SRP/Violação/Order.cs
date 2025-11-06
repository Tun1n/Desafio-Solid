using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SRP.Violação
{
    // A classe Order está violando o Princípio da Responsabilidade Única (SRP) pois ela possui mais de uma responsabilidade.
    public class Order
    {
        public void Print()
        {
            Console.WriteLine("Pedido feito!");
        }

        public void SendEmail()
        {
            Console.WriteLine("Email enviado ao cliente!");
        }

    }
}

