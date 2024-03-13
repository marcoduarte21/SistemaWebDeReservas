using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;


namespace GestorDeReservasWeb.BL
{
    public interface IBusinessLogicReservation
    {

        public void RegisterReservation(Model.Reservacion reservacion);
        public void RegisterPerson(Model.Persona persona);
        public List<Model.Reservacion> GetAllReservacion();
        public void ElimineLaReservacion(Model.Reservacion reservacion);
        public Model.Persona GetPersona(int id);
        public Model.Reservacion GetReservation(int id);
        
    }
}
