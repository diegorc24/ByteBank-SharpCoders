using ByteBank_SharpCoders.Núcleo.Entidades;
using ByteBank_SharpCoders.ObjetosValor;

namespace ByteBank_SharpCoders.Entidades
{
    public class Pessoa : BaseEntidade
    {
        public string PrimeiroNome { get; private set; }
        public string Ultimonome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public int Idade
        {
            get
            {
                var dataAtual = DateTime.Now;
                var idade = dataAtual.Year - DataNascimento.Year;

                if (dataAtual.Month < DataNascimento.Month)
                    idade--;

                return idade;
            }
        }
        public Cpf Cpf { get; private set; }
        public Email Email { get; private set; }

        public Pessoa(string primeiroNome, string ultimoNome, DateTime dataNascimento, Cpf cpf, Email email)
        {
            PrimeiroNome = primeiroNome.Trim();
            Ultimonome = ultimoNome.Trim();

            if (DateTime.Now.Year - dataNascimento.Year > 110)
                throw new OrderException("Idade superior a 110 anos não permitida!");

            if (!cpf.Evalido)
                throw new OrderException("Cpf inválido!");

            if (!email.Evalido)
                throw new OrderException("E-mail inválido!");

            DataNascimento = dataNascimento;
            Cpf = cpf;
            Email = email;
            DataHoraRegisto = DateTime.Now;
        }

        public string FullName =>
            $"{PrimeiroNome} {Ultimonome}";
    }
}