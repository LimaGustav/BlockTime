using System;
using System.Collections.Generic;

#nullable disable

namespace blockTimeWebApi.Domains
{
    public partial class Cliente
    {
        public Cliente()
        {
            Chaveacessos = new HashSet<Chaveacesso>();
            Emails = new HashSet<Email>();
            Telefones = new HashSet<Telefone>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Chaveacesso> Chaveacessos { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<Telefone> Telefones { get; set; }
    }
}
