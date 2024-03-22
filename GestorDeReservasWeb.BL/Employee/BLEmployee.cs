using GestorDeReservasWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeReservasWeb.BL.Employee
{
    public class BLEmployee : IBLEmployee
    {

        private DA.DbContexto DbContexto;
        public BLEmployee(DA.DbContexto dbContexto)
        {
            DbContexto = dbContexto;
        }

        public List<Appoinment> GetListCitasProgramadas(Model.Employee employee)
        {
            var list = from appoinment in DbContexto.Appoinments
                       where appoinment.employeeInChange.employeeId ==employee.employeeId
                       select appoinment;

            return list.ToList();
        }
    }
}
