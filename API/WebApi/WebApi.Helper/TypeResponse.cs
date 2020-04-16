using System;


namespace WebApi.Helper
{
    public static class TypeResponse
    {
        public static string Success => "success";

        public static string Error => "danger";

        public static string Alert => "warning";

        public static string Info => "info";
    }
    public class Response
    {
        public Response(string messagge, string typeResponse, string jsonObject)
        {
            Mensaje = messagge;
            if ((typeResponse != TypeResponse.Success) &&
                (typeResponse != TypeResponse.Error) &&
                (typeResponse != TypeResponse.Alert) &&
                (typeResponse != TypeResponse.Info))
            {
                throw new Exception("Tipo de Respuesta incorrecto, utilice la clase  estatica TipoRespuesta");
            }
            TipoRespuesta = typeResponse;
            Resultado = (typeResponse == TypeResponse.Success);
            JsonObject = jsonObject;
        }


        public Response(string messagge, string typeResponse)
        {
            Mensaje = messagge;
            if ((typeResponse != TypeResponse.Success) &&
                (typeResponse != TypeResponse.Error) &&
                (typeResponse != TypeResponse.Alert) &&
                (typeResponse != TypeResponse.Info))
            {
                throw new Exception("Tipo de Respuesta incorrecto, utilice la clase  estatica TipoRespuesta");
            }
            TipoRespuesta = typeResponse;
            Resultado = (typeResponse == TypeResponse.Success);
        }



        public Response(string messagge, string typeResponse, bool IsFirstTime)
        {
            Mensaje = messagge;
            if ((typeResponse != TypeResponse.Success) &&
                (typeResponse != TypeResponse.Error) &&
                (typeResponse != TypeResponse.Alert) &&
                (typeResponse != TypeResponse.Info))
            {
                throw new Exception("Tipo de Respuesta incorrecto, utilice la clase  estatica TipoRespuesta");
            }
            TipoRespuesta = typeResponse;
            Resultado = (typeResponse == TypeResponse.Success);
            EsPrimeraVez = IsFirstTime;
        }




        public string Mensaje { get; set; }
        public string JsonObject { get; set; }
        public string TipoRespuesta { get; set; }
        public bool Resultado { get; set; }
        public bool EsPrimeraVez { get; set; }





    }
}
