using System.Globalization;
using System.Security.Principal;

namespace GestorDeReservasWeb.Model
{
    public class Persona
    {
        public int id { get; set; }
        public int identificacion { get; set; }
        public string nombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string email { get; set; }
        public Direccion idDireccion { get; set; }
        public int telefono { get; set; }
        public Rol rol { get; set; }

    }
}