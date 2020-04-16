 
namespace AppDTO
{
    public class ResultResponseArticle
    {
        public ArticlesDto[] articles { get; set; }
        public bool Success { get; set; }
        public int total_elements { get; set; }
    }
}
