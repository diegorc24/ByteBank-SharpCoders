namespace ByteBank_SharpCoders.Núcleo.Entidades
{
    public abstract class Entidade
    {
        public long Id { get; set; }
    }

    public abstract class BaseEntidade : Entidade
    {
        public DateTime DataHoraRegisto { get; set; }
        public DateTime MudancaDataHora { get; set; }
    }
}