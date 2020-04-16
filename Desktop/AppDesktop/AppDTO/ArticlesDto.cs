 using System.Collections.Generic;
 

namespace AppDTO
{
    public class ArticlesDto : BaseEntityDto
    {
        public int StoreId { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int? TotalInShelf { get; set; }
        public int? TotalInVault { get; set; }
        public List<StoresDto> LstStores { get; set; }
    }
}
