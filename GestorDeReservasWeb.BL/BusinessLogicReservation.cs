using GestorDeReservasWeb.DA;
using GestorDeReservasWeb.Model;

namespace GestorDeReservasWeb.BL
{
    public class BusinessLogicReservation : IBusinessLogicReservation
    {
        private DA.DbContexto context;

        public BusinessLogicReservation(DbContexto Context)
        {
            context = Context;
        }

        public void EditeLaReservacion(Reservacion reservacion)
        {
            throw new NotImplementedException();
        }

        public void ElimineLaReservacion(Reservacion reservacion)
        {
            throw new NotImplementedException();
        }

        public List<Reservacion> GetAllReservacion()
        {
            throw new NotImplementedException();
        }

        public Persona GetPersona(int id)
        {
            throw new NotImplementedException();
        }

        public Reservacion GetReservation(int id)
        {
            throw new NotImplementedException();
        }

        public void RegisterPerson(Persona persona)
        {
            throw new NotImplementedException();
        }

        public void RegisterReservation(Reservacion reservacion)
        {
            throw new NotImplementedException();
        }
    }
}