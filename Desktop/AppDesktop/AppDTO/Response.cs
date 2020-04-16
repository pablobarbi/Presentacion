using System;
using System.Collections.Generic;
using System.Text;

namespace AppDTO
{
    public class Response
    {
        public string Mensaje { get; set; }
        public string JsonObject { get; set; }
        public string TipoRespuesta { get; set; }
        public bool Resultado { get; set; }
        public bool EsPrimeraVez { get; set; }
    }
}
