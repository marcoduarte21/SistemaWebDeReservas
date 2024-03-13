using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeReservasWeb.Model
{
    public class Reservacion
    {
        public int id {  get; set; }
        public DateTime fecha { get; set; }
        public TipoDeCita idTipoDeCita { get; set; }
        public Persona idPersona { get; set; }
        public string encargado { get; set; }
        public Estado estado { get; set; } 
    }
}
