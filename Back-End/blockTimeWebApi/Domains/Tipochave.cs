using System;
using System.Collections.Generic;

#nullable disable

namespace blockTimeWebApi.Domains
{
    public partial class Tipochave
    {
        public Tipochave()
        {
            Chaveacessos = new HashSet<Chaveacesso>();
        }

        public short Id { get; set; }
        public string Titulo { get; set; }

        public virtual ICollection<Chaveacesso> Chaveacessos { get; set; }
    }
}
