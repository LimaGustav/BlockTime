using System;
using System.Collections.Generic;

#nullable disable

namespace blockTimeWebApi.Domains
{
    public partial class UsuarioZabbix
    {
        public int Id { get; set; }
        public int? IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
