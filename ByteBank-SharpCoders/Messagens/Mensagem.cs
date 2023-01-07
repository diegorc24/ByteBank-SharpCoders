using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_SharpCoders.Messagens
{
    public class Mensagem
    {
        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Digite o número da opção desejada:");
            Console.WriteLine("1 - Cadastro de cliente");
            Console.WriteLine("2 - Deletar um Cliente");
            Console.WriteLine("3 - Visualizar clientes");
            Console.WriteLine("5 - Quantia armazenada no banco");
            Console.WriteLine("6 - Manipular a conta");
            Console.WriteLine("0 - Sair");
            Console.WriteLine();
        }

        public static void OpcaoInvalida()
        {
            Console.WriteLine();
            Console.WriteLine("Opção escolhida inválida, escolha uma das opções do menu");
        }

        public static void EntradaInvalida()
        {
            Console.WriteLine();
            Console.WriteLine("Digite apenas caracteres numéricos");
        }
    }
}
