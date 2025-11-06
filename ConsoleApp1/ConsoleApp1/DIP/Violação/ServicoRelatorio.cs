using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DIP.Violação
{
    // A classe viola o Princípio da Inversão de Dependência, pois depende diretamente da classe concreta Repositorio.
    public class ServicoRelatorio
    {
        private Repositorio _repositorio;
        public ServicoRelatorio()
        {
            _repositorio = new Repositorio();
        }
        public void Processar(string dados)
        {
           _repositorio.Salvar(dados);
        }
    }
}
