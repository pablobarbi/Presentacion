

using System.Collections.Generic;

namespace WebApi.Dto
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
