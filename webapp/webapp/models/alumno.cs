using Microsoft.AspNetCore.Builder;
using System.ComponentModel.DataAnnotations;

namespace webapp.models
{
    public class Alumno
    {
        [Key]
        public int idalumno { get; set; }
        public int codigo { get; set; }
        public int nombre { get; set; }
        public int direccion { get; set; }
        public int telefono { get; set; }
        public int email { get; set; }
    }
}
