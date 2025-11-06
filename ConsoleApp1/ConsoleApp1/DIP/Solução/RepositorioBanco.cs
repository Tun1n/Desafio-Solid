using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DIP.Solução
{
    // Agora a classe depende da abstração IRepositorio, cumprindo o Princípio da Inversão de Dependência.
    public class RepositorioBanco : IRepositorio
    {
        public void Salvar(string dados)
        {
            Console.WriteLine("Dados salvos no banco de dados: " + dados);
        }
    }
}
