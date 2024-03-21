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

        public void RegisterReservation(Model.Appoinment reservacion);
        public void RegisterPerson(Model.People persona);
        public List<Model.Appoinment> GetAllReservacion();
        public void EditeLaReservacion(Model.Appoinment reservacion);
        public void ElimineLaReservacion(Model.Appoinment reservacion);
        public Model.People GetPersona(int id);
        public Model.Appoinment GetReservation(int id);
        
    }
}
