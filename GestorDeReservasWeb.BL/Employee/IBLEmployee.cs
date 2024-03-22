using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeReservasWeb.BL.Employee
{
    public interface IBLEmployee
    {
        public List<Model.Appoinment> GetListCitasProgramadas();
    }
}
