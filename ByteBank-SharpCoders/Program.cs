using ByteBank_SharpCoders.Entidades;
using ByteBank_SharpCoders.Messagens;

class Program
{
    static void Main(string[] args)
    {
        List<Cliente> _cliente = new List<Cliente>();
        //List<Product> _products = new List<Product>();
        //List<Order> _orders = new List<Order>();

        Console.WriteLine("Seja bem-vindo!");

        var opcaoEscolhida = -1;

        while (opcaoEscolhida != 0)
        {
            opcaoEscolhida = Utils.EscolhaOpcaoMenu();

            switch (opcaoEscolhida)
            {
                case 1:
                    _cliente.Add(Utils.CadastrarCliente());
                    break;
                case 2:
                    Utils.DeletarCliente(_cliente);
                    break;
                case 3:
                    Utils.ListarClientes(_cliente);
                    break;
                case 5:
                    Utils.QuantiaTotalBanco();
                    break;
                //case 6:
                //    Utils.ListOrders(_orders);
                //    break;
                default:
                    Mensagem.OpcaoInvalida();
                    break;
            }
        }

        Environment.Exit(0);
    }
}

