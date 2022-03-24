using System;
using System.Collections.Generic;

#nullable disable

namespace blockTimeWebApi.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            UsuarioZabbixes = new HashSet<UsuarioZabbix>();
        }

        public int Id { get; set; }
        public short? IdTipoUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual Tipousuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<UsuarioZabbix> UsuarioZabbixes { get; set; }
    }
}
