using PadraoFacade;

class Program
{
    static void Main(string[] args)
    {
        Serasa serasa = new Serasa();
        SPC spc = new SPC();
        LimiteCredito limiteCredito = new LimiteCredito();
        Cadastro cadastro = new Cadastro();

        Fachada fachada = new Fachada(cadastro, serasa, spc, limiteCredito);

        Cliente cliente = new Cliente
        {
            Nome = "John Doe",
            CPF = 1234567890
        };

        fachada.CadastroCliente(cliente);
        fachada.VerificaCredito(cliente, 1000);
    }
}