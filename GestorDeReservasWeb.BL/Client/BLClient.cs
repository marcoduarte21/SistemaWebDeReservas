using GestorDeReservasWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeReservasWeb.BL.Client
{
    public class BLClient : IBLClient
    {
        private DA.DbContexto DbContexto;
        public BLClient(DA.DbContexto dbContexto)
        {

            DbContexto = dbContexto;

        }
        public void AgendarCita(Appoinment appoinment)
        {
            Model.Appoinment appoinmentAgendado = appoinment;
            appoinment.statte = AppoinmentState.RESERVADA;
            DbContexto.Appoinments.Update(appoinmentAgendado);
            DbContexto.SaveChanges();
           
        }

        void IBLClient.EliminarLaCita(Appoinment appoinment)
        {
            Model.Appoinment appoinmentAEliminar;
            appoinmentAEliminar = GetAppoinment(appoinment.id);
            appoinmentAEliminar.statte = AppoinmentState.DISPONIBLE;
            DbContexto.Appoinments.Update(appoinmentAEliminar);
            DbContexto.SaveChanges();
        }

        public Appoinment GetAppoinment(int id)
        {
            foreach (var appoiment in DbContexto.Appoinments)
            {
                if (appoiment.id == id)
                {
                    return appoiment;
                }
            }
            return null;
        }

        public User GetUser(string id)
        {
            foreach (var user in DbContexto.Users)
            {
                if (user.userId == id)
                {
                    return user;
                }
            }
            return null;
        }

        public List<Appoinment> GetListCitasProgramadas(User user)
        {
            var list = from appoinment in DbContexto.Appoinments
                       where appoinment.statte == AppoinmentState.RESERVADA && appoinment.clientUser == user.userId
                       select appoinment;

            return list.ToList();
        }
    }
}
