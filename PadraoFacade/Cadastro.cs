using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoFacade
{
    public class Cadastro
    {
        public bool CadastrarCliente(Cliente cliente)
        {
            Console.WriteLine("Cliente registered.");
            return true;
        }
    }
}
