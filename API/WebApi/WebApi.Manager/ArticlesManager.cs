using System.Collections.Generic;
using System.Linq;
using WebApi.Dto;
using WebApi.EF.Models;
using WebApi.Repo;

namespace WebApi.Manager
{
    public class ArticlesManager : RepositoryBase<Articles>
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<ArticlesDto> GetAll()
        {
            var lstArticles = this.All().ToList(); 
            return ListDto(lstArticles) ;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public List<ArticlesDto> GetArticlesByStore(int storeId)
        {
            var lstArticles = this.All()
                                  .Where(a=> a.StoreId == storeId)
                                  .ToList();
            return ListDto(lstArticles);
        }

        public void Add(ArticlesDto article)
        {
            this.Create(Entity(article));
        }
        public void Upd(ArticlesDto article)
        {
            this.Update(Entity(article));
        }
        public void Del(ArticlesDto article)
        {
            this.Delete(Entity(article));
        }


        #region Mapper
        /// <summary>
        /// Transformo el resultado para devolver un DTO
        /// </summary>
        /// <param name="listArticle">Lista de Articles</param>
        /// <returns>Retorna la lista DTO de la entidad</returns>
        private List<ArticlesDto> ListDto( List<Articles> listArticle)
        {
            StoresManager storesManager = new StoresManager();
            var lstStore = storesManager.GetAll();
            
            return listArticle.Select(s => new ArticlesDto()
            {
                 Description = s.Description,
                 Id = s.Id,
                 Name = s.Name,
                 Price = s.Price,
                 StoreId = s.StoreId,
                 TotalInShelf = s.TotalInShelf,
                 TotalInVault = s.TotalInVault,
                 LstStores = lstStore.Where( ls=> ls.Id == s.StoreId).ToList()
            }).ToList(); 
        }

        private ArticlesDto ToDto( Articles article)
        {
            return new ArticlesDto()
            {
                Description = article.Description,
                Id = article.Id,
                Name = article.Name,
                Price = article.Price,
                StoreId = article.StoreId,
                TotalInShelf = article.TotalInShelf,
                TotalInVault = article.TotalInVault
            };
        }


        private Articles Entity(ArticlesDto articlesDto)
        {
            return new Articles()
            {
                 StoreId = articlesDto.StoreId,
                 Id= articlesDto.Id,
                 Description = articlesDto.Description,
                 Name= articlesDto.Name,
                 Price = articlesDto.Price,
                 TotalInShelf = articlesDto.TotalInShelf,
                 TotalInVault = articlesDto.TotalInVault
            };
        }

        #endregion
    }
}
