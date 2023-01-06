using ByteBank_SharpCoders.Núcleo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_SharpCoders.Entidades
{
    public class Cliente : BaseEntidade
    {
        public Pessoa Pessoa { get; set;}
        public bool Ativo { get; set;}  
    }
}
