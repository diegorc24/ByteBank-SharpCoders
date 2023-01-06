using ByteBank_SharpCoders.Entidades;
using ByteBank_SharpCoders.Exceções;
using ByteBank_SharpCoders.ObjetosValor;
using System.Globalization;
using System;

internal class Utils
{
    public static Cliente CadastrarCliente()
    {
        string primeiroNome;
        string ultimoNome;
        Cpf cpf = string.Empty;
        Email email = string.Empty;
        DateTime dataNascimento = DateTime.MinValue;

        Console.WriteLine("Insira o primeiro nome do cliente: ");
        primeiroNome = Console.ReadLine();
        Console.WriteLine("Insira o sobrenome do cliente: ");
        ultimoNome = Console.ReadLine();
        while (!cpf.Evalido)
        {
            Console.WriteLine("Insira o cpf do cliente sem pontos e traços: ");
            cpf = Console.ReadLine();
        }

        while (!email.Evalido)
        {
            Console.WriteLine("Insira o e-mail do cliente: ");
            email = Console.ReadLine();
        }

        while (dataNascimento == DateTime.MinValue)
        {
            try
            {
                Console.WriteLine("Insira a data de nascimento do cliente, no formato dd/MM/yyyy: ");
                dataNascimento = Convert.ToDateTime(Console.ReadLine(), new CultureInfo("pt-BR"));
            }
            catch (Exception)
            {
                Console.WriteLine("Data inserida no formato errado, tente novamente");
            }
        }

        try
        {
            var pessoa = new Pessoa(primeiroNome, ultimoNome, dataNascimento, cpf, email);
            var cliente = new Cliente()
            {
                Pessoa = pessoa,
                Ativo = true
            };

            return cliente;
        }
        catch (OrderException ex)
        {
            Console.WriteLine("Erro ao cadastrar cliente:");
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro desconhecido:");
            Console.WriteLine(ex.Message);
        }

        return null;
    }

    internal static int EscolhaOpcaoMenu()
    {
        throw new NotImplementedException();
    }

    internal static void ListCustomers(List<Cliente> cliente)
    {
        throw new NotImplementedException();
    }
}