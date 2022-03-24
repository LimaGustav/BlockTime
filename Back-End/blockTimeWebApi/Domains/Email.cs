using System;
using System.Collections.Generic;

#nullable disable

namespace blockTimeWebApi.Domains
{
    public partial class Email
    {
        public int Id { get; set; }
        public int? IdCliente { get; set; }
        public string Email1 { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
