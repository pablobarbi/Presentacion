

using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace AppService.Helper
{
    public static class ServicesHelper
    {
        /// <summary>
        /// Propiedad que se llena al iniciar la aplicacion con la URL principal de las WebApi
        /// </summary>
        public static string URL { get; set; }

        /// <summary>
        /// Metodo para realizar llamado al metodo post
        /// </summary>
        /// <param name="action">Action que se llama al controller</param>
        /// <param name="data">es el objeto que se envia por parametro</param>
        /// <returns></returns>
        public static string MethodPost(string action, object data)
        { 
            HttpClient client = new HttpClient();
            var content = new StringContent(JsonConvert.SerializeObject(data) , Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(URL + action, content).Result;
            //response.EnsureSuccessStatusCode();
            if ( response.StatusCode == HttpStatusCode.OK )
            {
                return response.Content.ReadAsStringAsync().Result;
            }

            return string.Empty;
        }


        /// <summary>
        /// Metodo para llamar al metodo get de una WebApi
        /// </summary>
        /// <param name="action">Action que se utiliza en el metodo GET</param>
        /// <returns></returns>
        public static string  MethodGet(string action)
        { 
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(URL + action).Result;
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return response.Content.ReadAsStringAsync().Result;
            }

            return string.Empty;
        }


    }
}
