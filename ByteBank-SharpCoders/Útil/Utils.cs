using ByteBank_SharpCoders.Entidades;
using ByteBank_SharpCoders.Exceções;
using ByteBank_SharpCoders.ObjetosValor;
using System.Globalization;
using System;
using ByteBank_SharpCoders.Messagens;

public class Utils
{
    //public static List<Cliente> clientes = Json.Desserializar();

    //public static bool ValidarCpf(Cpf cpf)
    //{
    //    if (clientes == null)
    //    {
    //        clientes = new List<Cliente>();
    //        return false;
    //    }
    //    else if (clientes.Exists(cliente => cliente.Pessoa.Cpf == cpf)) return true;
    //    else return false;
    //}

    public static Cliente CadastrarCliente()
    {
        string primeiroNome;
        string ultimoNome;
        Cpf cpf = string.Empty;
        Email email = string.Empty;
        DateTime dataNascimento = DateTime.MinValue;
        string senha;

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

        Console.WriteLine("Digite a senha");
        senha = Console.ReadLine();


        try
        {
            var pessoa = new Pessoa(primeiroNome, ultimoNome, dataNascimento, cpf, email, senha);
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

    public static int EscolhaOpcaoMenu()
    {
        var resultado = -1;
        do
        {
            try
            {
                Mensagem.Menu();
                resultado = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Mensagem.EntradaInvalida();
            }
        }
        while (resultado == -1);

        return resultado;
    }

    public static void ListarClientes(List<Cliente> clientes)
    {
        if (clientes == null || clientes.Count == 0)
        {
            Console.WriteLine("Nenhum cliente foi registrado");
            return;
        }

        var count = 1;
        Console.WriteLine("Id | Nome | CPF | E-mail | Idade");
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"{count} | {cliente.Pessoa?.NomeCompleto} | {cliente.Pessoa?.Cpf.CpfFormatado} | {cliente.Pessoa?.Email} | {cliente.Pessoa?.Idade}");
            Console.WriteLine();
            count++;
        }
    }

    public static void DeletarCliente(List<Cliente> clientes)
    {
    //    Cpf cpf = string.Empty;

    //    while (!cpf.Evalido)
    //    {
    //        Console.WriteLine("Insira o cpf do cliente sem pontos e traços: ");
    //        cpf = Console.ReadLine();
    //    }
    //    int indexParaDeletar = cpf.FindIndex(cpf => cpf == cpfParaDeletar);

    //    if (indexParaDeletar == -1)
    //    {
    //        Console.WriteLine("Não foi possível deletar esta Conta");
    //        Console.WriteLine("MOTIVO: Conta não encontrada.");
    //    }

    //    cpfs.Remove(cpfParaDeletar);
    //    titulares.RemoveAt(indexParaDeletar);
    //    senhas.RemoveAt(indexParaDeletar);
    //    saldos.RemoveAt(indexParaDeletar);

    //    Console.WriteLine("Conta deletada com sucesso");
    }

    public static void QuantiaTotalBanco()
    {
    //    double quantia = 0;
    //    List<Cliente> clientes = ;
    //    foreach (Cliente cliente in clientes)
    //    {
    //        quantia += cliente.Saldo;
    //    }
    //    Print.MostrarQuantiaTotal(quantia);
    }
}