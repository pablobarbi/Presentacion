

using System;

namespace WebApi.Dto
{
   public class UserDto
    {
        public Guid UserId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }
    }
}
