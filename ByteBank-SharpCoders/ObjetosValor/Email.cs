using System.Text.RegularExpressions;

namespace ByteBank_SharpCoders.ObjetosValor
{
    public struct Email
    {
        private readonly string _valor;
        public readonly bool Evalido;

        private Email(string value)
        {
            _valor = value.Trim();

            if (string.IsNullOrEmpty(_valor))
            {
                Evalido = false;
                return;
            }

            Evalido = Regex.IsMatch(_valor, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

            if (!Evalido)
                return;
        }

        public static implicit operator Email(string valor)
            => new Email(valor);

        public override string ToString() => _valor;
    }
}
