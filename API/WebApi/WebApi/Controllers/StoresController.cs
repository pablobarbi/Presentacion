using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using WebApi.Dto;
using WebApi.Helper;
using WebApi.Manager;

namespace WebApi.Controllers
{
    [Route("services/[controller]")]
    [ApiController]
    public class StoresController : ControllerBase
    {

        [HttpGet]
        [Route("GetAll")]
        public ActionResult<Response> GetAll()
        {
            try
            {
                StoresManager storeManager = new StoresManager();
                var lista = storeManager.GetAll().ToList();
                return Ok(Respuesta(lista));
            }
            catch (Exception ex)
            {
                return new Response("Ha ocurrido un error al obtener Stores.", TypeResponse.Error);
            }

        }



        [HttpPost]
        [Route("AddStore")]
        public ActionResult<Response> Add([FromBody] StoresDto storesDto)
        {
            try
            {
                StoresManager storeManager = new StoresManager();

                if (storesDto.Id == 0)
                {
                    storeManager.Add(storesDto);
                }
                else
                {
                    storeManager.Upd(storesDto);
                }

                return new Response("Se guardo correctamente la información.", TypeResponse.Success);
            }
            catch (Exception ex)
            {
                return new Response("Ha ocurrido un error al guardar.", TypeResponse.Error);
            }

        }

        [HttpPost]
        [Route("DelStore")]
        public ActionResult<Response> Del([FromBody] StoresDto storesDto)
        {
            try
            {
                StoresManager storeManager = new StoresManager();
                storeManager.Del(storesDto);


                return new Response("Se elimino correctamente la información.", TypeResponse.Success);
            }
            catch (Exception ex)
            {
                return new Response("Ha ocurrido un error al eliminar la información.", TypeResponse.Error);
            }

        }

        #region Metodos privados
        private string Respuesta(List<StoresDto> lista)
        {
            JObject obj = JObject.FromObject(new
            {
                stores =
                            from p in lista
                            orderby p.Id
                            select new
                            {
                                p.Id,
                                p.Name,
                                p.Address
                            },
                Success = true,
                total_elements = lista.Count()

            });

            return obj.ToString();
        }
        #endregion
    }

}



