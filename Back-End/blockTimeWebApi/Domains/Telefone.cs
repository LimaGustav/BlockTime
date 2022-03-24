using System;
using System.Collections.Generic;

#nullable disable

namespace blockTimeWebApi.Domains
{
    public partial class Telefone
    {
        public int Id { get; set; }
        public int? IdCliente { get; set; }
        public string Telefone1 { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
