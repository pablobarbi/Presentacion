using AppDTO;
using AppService.Helper;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace AppService.Stores
{
    public class StoresServices
    {
        /// <summary>
        /// Metodo para obtener todos los Stores
        /// </summary>
        /// <returns></returns>
        public ResultResponseStore GetAllAsync()
        {
            try
            {
                var action = "Stores/GetAll";
                var json = ServicesHelper.MethodGet(action);
                if (string.IsNullOrEmpty(json))
                {
                    throw new Exception("Se ha producido un error al obtener Stores");
                }
                return JsonConvert.DeserializeObject<ResultResponseStore>(json);
            }
            catch (Exception)
            {

                throw new Exception("Se ha producido un error al obtener Stores");
            }

        }
        /// <summary>
        /// Metodo para crear o actualizar un registro
        /// </summary>
        /// <param name="storesDto"></param>
        /// <returns></returns>
        public Response Save(StoresDto storesDto)
        {
            try
            {
                var action = "Stores/AddStore";
                var json = ServicesHelper.MethodPost(action, storesDto);
                if (string.IsNullOrEmpty(json))
                {
                    throw new Exception("Se ha producido un error al guardar Articles");
                }
                return JsonConvert.DeserializeObject<Response>(json);
            }
            catch (Exception)
            {

                throw new Exception("Se ha producido un error al guardar Articles");
            }


        }


        /// <summary>
        /// Metodo para eliminar un registro
        /// </summary>
        /// <param name="storesDto"></param>
        /// <returns></returns>
        public Response Delete(StoresDto storesDto)
        {
            try
            {
                var action = "Stores/DelStore";
                var json = ServicesHelper.MethodPost(action, storesDto);
                if (string.IsNullOrEmpty(json))
                {
                    throw new Exception("Se ha producido un error al eliminar Articles");
                }
                return JsonConvert.DeserializeObject<Response>(json);
            }
            catch (Exception)
            {

                throw new Exception("Se ha producido un error al eliminar Articles");
            }


        }
    }
}
