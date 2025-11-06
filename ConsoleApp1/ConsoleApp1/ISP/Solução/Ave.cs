using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ISP.Solução
{
    public class Ave : IVoar
    {
        public void Voar() => Console.WriteLine("A ave está voando.");
    }
}
