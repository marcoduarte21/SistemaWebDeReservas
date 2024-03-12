using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeReservasWeb.Model
{
    public class Direccion
    {
        public int id { get; set; }
        public Provincia provincia { get; set; }
        public Canton canton { get ; set; }
        public Distrito distrito { get; set; }
        public Localidad localidad { get; set; }
        public string direccion_exacta { get; set; }

    }
}
