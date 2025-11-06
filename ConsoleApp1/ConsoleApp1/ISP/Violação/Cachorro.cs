using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ISP.Violação
{
    // A classe Cachorro está violando o Princípio da Segregação de Interfaces
    public class Cachorro : IAcoesAnimal
    {
        public void Comer() => Console.WriteLine("O cachorro está comendo.");

        public void Nadar() => Console.WriteLine("O cachorro está nadando.");

        // Cachorros não voam, mas ainda assim são obrigados a implementar este método
        public void Voar() => Console.WriteLine("Cachorro está voando.");
    }
}
