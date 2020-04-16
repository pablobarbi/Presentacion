using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Dto;
using WebApi.Helper;
using WebApi.Manager;

namespace WebApi.Controllers
{
    [Route("services/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<Response> GetAll()
        {
            ArticlesManager articlesManager = new ArticlesManager();
            var lista = articlesManager.GetAll().ToList();
            return Ok(Respuesta(lista));
        }



        [HttpGet]
        [Route("GetArticlesByStore")]
        public ActionResult<Response> GetArticlesByStore(int storeId)
        {
            ArticlesManager articlesManager = new ArticlesManager();
            var lista = articlesManager.GetArticlesByStore(storeId).ToList();
            return Ok(Respuesta(lista));
        }


        [HttpPost]
        [Route("AddArticles")]
        public ActionResult<Response> Add([FromBody] ArticlesDto articleDto)
        {
            try
            {
                ArticlesManager articlesManager = new ArticlesManager();
                if (articleDto.Id == 0)
                {
                    articlesManager.Add(articleDto);
                }
                else
                {
                    articlesManager.Upd(articleDto);
                }

                return new Response("Se guardo correctamente la información.", TypeResponse.Success);
            }
            catch (Exception ex)
            {
                return new Response("Ha ocurrido un error al guardar.", TypeResponse.Error);
            }

        }


        [HttpPost]
        [Route("DelArticles")]
        public ActionResult<Response> Del([FromBody] ArticlesDto articleDto)
        {
            try
            {
                ArticlesManager articlesManager = new ArticlesManager();

                articlesManager.Del(articleDto);


                return new Response("Se elimino correctamente la información.", TypeResponse.Success);
            }
            catch (Exception ex)
            {
                return new Response("Ha ocurrido un error al eliminar la información.", TypeResponse.Error);
            }

        }

        #region Metodos Privados
        private string Respuesta(List<ArticlesDto> lista)
        {
            JObject obj = JObject.FromObject(new
            {
                articles =
                            from p in lista
                            orderby p.Id
                            select new
                            {
                                Id = p.Id,
                                Name = p.Name,
                                Description = p.Description,
                                Price = p.Price,
                                TotalInShelf = p.TotalInShelf,
                                TotalInVault = p.TotalInVault,
                                StoreId = p.StoreId,
                                LstStores = p.LstStores
                            },
                Success = true,
                total_elements = lista.Count()

            });

            return obj.ToString();
        }
        #endregion
    }
}