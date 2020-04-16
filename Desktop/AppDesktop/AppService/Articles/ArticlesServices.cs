using AppDTO;
using AppService.Helper;
using Newtonsoft.Json;
using System;

namespace AppService.Articles
{
    public class ArticlesServices
    { 
        /// <summary>
        /// Obtengo la lista de Articulos
        /// </summary>
        /// <returns></returns>
        public ResultResponseArticle GetAll()
        {
            try
            {
                var action = "Articles/GetAll";
                string json = ServicesHelper.MethodGet(action).ToString();
                if (string.IsNullOrEmpty(json))
                {
                    throw new Exception("Se ha producido un error al obtener Articles");
                }
                return JsonConvert.DeserializeObject<ResultResponseArticle>(json);
            }
            catch (Exception ex)
            {

                throw new Exception("Se ha producido un error al obtener Articles");
            }
            
        }


        /// <summary>
        /// Metodo para crear o actualizar un articulo
        /// </summary>
        /// <param name="articleDto">Objeto para que se guardado</param>
        /// <returns>Mensaje de Respuesta</returns>
        public Response Save(ArticlesDto articleDto)
        {
            try
            {
                var action = "Articles/AddArticles";
                var json = ServicesHelper.MethodPost(action, articleDto);
                if (string.IsNullOrEmpty(json))
                {
                    throw new Exception("Se ha producido un error al guardar Articles");
                }
                return JsonConvert.DeserializeObject<Response>(json);
            }
            catch (Exception ex)
            {

                return new Response() { Mensaje = "Se ha producido un error al guardar Articles", Resultado = false };
            }
           

        }

        /// <summary>
        /// Metodo para eliminar un articulo
        /// </summary>
        /// <param name="articleDto">Objeto para que se guardado</param>
        /// <returns>Mensaje de Respuesta</returns>
        public Response Delete(ArticlesDto articleDto)
        {
            try
            {
                var action = "Articles/DelArticles";
                var json = ServicesHelper.MethodPost(action, articleDto);
                if (string.IsNullOrEmpty(json))
                {
                    throw new Exception("Se ha producido un error al eliminar Articles");
                }
                return JsonConvert.DeserializeObject<Response>(json);
            }
            catch (Exception ex)
            {

                return new Response() { Mensaje = "Se ha producido un error al eliminar Articles", Resultado = false };
            }


        }
    }




}
