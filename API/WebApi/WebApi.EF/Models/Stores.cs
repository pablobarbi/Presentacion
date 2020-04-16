using System;
using System.Collections.Generic;

namespace WebApi.EF.Models
{
    public partial class Stores
    {
        public Stores()
        {
            Articles = new HashSet<Articles>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Articles> Articles { get; set; }
    }
}
