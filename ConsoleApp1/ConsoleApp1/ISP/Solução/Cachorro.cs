using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ISP.Solução
{
    // Agora a classe Cachorro implementa apenas as interfaces que são relevantes para ela, seguindo o Princípio da Segregação de Interfaces
    public class Cachorro : IComer, INadar
    {
        public void Comer() => Console.WriteLine("O cachorro está comendo.");
        public void Nadar() => Console.WriteLine("O cachorro está nadando.");
    }
}
