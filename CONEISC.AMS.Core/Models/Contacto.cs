using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONEISC.AMS.Core.Models
{
    public class Contacto
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string NumeroTelefono { get; set; }
        public string ImageUrl { get; set; }
    }
}
