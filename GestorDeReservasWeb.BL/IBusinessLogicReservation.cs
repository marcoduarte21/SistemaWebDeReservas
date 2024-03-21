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

        public void RegisterReservation(Model.Appoinments reservacion);
        public void RegisterPerson(Model.People persona);
        public List<Model.Appoinments> GetAllReservacion();
        public void EditeLaReservacion(Model.Appoinments reservacion);
        public void ElimineLaReservacion(Model.Appoinments reservacion);
        public Model.People GetPersona(int id);
        public Model.Appoinments GetReservation(int id);
        
    }
}
