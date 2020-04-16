using System;
using System.Collections.Generic;

namespace WebApi.EF.Models
{
    public partial class Articles
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int? TotalInShelf { get; set; }
        public int? TotalInVault { get; set; }

        public virtual Stores Store { get; set; }
    }
}
