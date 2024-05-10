using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoFacade
{
    public class Fachada
    {
        private readonly Cadastro _cadastro;
        private readonly Serasa _serasa;
        private readonly SPC _spc;
        private readonly LimiteCredito _limiteCredito;

        public Fachada(Cadastro cadastro, Serasa serasa, SPC spc, LimiteCredito limiteCredito)
        {
            _cadastro = cadastro;
            _serasa = serasa;
            _spc = spc;
            _limiteCredito = limiteCredito;
        }

        public bool CadastroCliente(Cliente cliente)
        {
            if (!_spc.ConsultaSPC(cliente) || !_serasa.ConsultaSerasa(cliente))
            {
                Console.WriteLine("Cliente cannot be registered due to SPC or Serasa check.");
                return false;
            }

            return _cadastro.CadastrarCliente(cliente);
        }

        public bool VerificaCredito(Cliente cliente, double limite)
        {
            if (!_limiteCredito.VerificaLimite(limite))
            {
                Console.WriteLine("Cliente's credit limit is not sufficient.");
                return false;
            }

            Console.WriteLine("Cliente's credit limit is sufficient.");
            return true;
        }
    }

}