using GestorDeReservasWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeReservasWeb.BL.Client
{
    public interface IBLClient
    {
        public void AgendarCita(Model.Appoinment appoinment);
        public List<Model.Appoinment> GetListCitasProgramadas(User user);
        public void EliminarLaCita(Model.Appoinment appoinment);
        public void GetAppoinment(int id);

    }
}
