using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LSP.Solução
{
    // Agora o princípio Liskov é respeitado, pois tanto Retângulo quanto Quadrado herdam de Figura e implementam o método Area de forma adequada (Sem alterar a classe base).
    public abstract class Figura
    {
        abstract public double Area();
    }
}
