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

        List<Appoinment> IBLClient.GetListCitasProgramadas(User user)
        {
            var list = from appoinment in DbContexto.Appoinments
                       where appoinment.statte == AppoinmentState.RESERVADA && appoinment.clientUser.userId == user.userId
                       select appoinment;

            return list.ToList();
        }
    }
}
