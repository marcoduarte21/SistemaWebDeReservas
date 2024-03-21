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

        public void EditeLaReservacion(Appoinments reservacion)
        {
            Model.Appoinments reservamodificada;
            reservamodificada = GetReservation(reservacion.id);

            reservamodificada.fecha = reservacion.fecha;
            context.Reservacion.Update(reservamodificada);
            context.SaveChanges();

        }

        public void ElimineLaReservacion(Appoinments reservacion)
        {
            Model.Appoinments eliminarReserva = GetReservation(reservacion.id);
            context.Reservacion.Remove(eliminarReserva);
            context.SaveChanges();
        }

        public List<Appoinments> GetAllReservacion()
        {
            return context.Reservacion.ToList();
        }

        public People GetPersona(int id)
        {
            foreach(var persona in context.Persona)
            {
                if(persona.id == id)
                {
                    return persona;
                }
            }
            return null;
        }

        public Appoinments GetReservation(int id)
        {

            foreach (var cita in context.Reservacion)
            {
                if (cita.id == id)
                {
                    return cita;
                }
            }
            return null;
        }

        public void RegisterPerson(People persona)
        {
            context.Persona.Add(persona);
            context.SaveChanges();
            
        }

        public void RegisterReservation(Appoinments reservacion)
        {
            context.Reservacion.Add(reservacion);
            context.SaveChanges();
        }
    }
}