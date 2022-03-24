using System;
using System.Collections.Generic;

#nullable disable

namespace blockTimeWebApi.Domains
{
    public partial class Chaveacesso
    {
        public int Id { get; set; }
        public short? IdTipoChave { get; set; }
        public int? IdCliente { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Tipochave IdTipoChaveNavigation { get; set; }
    }
}
