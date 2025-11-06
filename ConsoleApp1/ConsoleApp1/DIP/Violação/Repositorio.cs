using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DIP.Violação
{
    public class Repositorio
    {
        public void Salvar(string dados)
        {
            Console.WriteLine("Dados salvos no banco de dados: " + dados);
        }
    }
}
