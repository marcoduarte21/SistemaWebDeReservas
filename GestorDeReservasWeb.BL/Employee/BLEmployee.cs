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

        public void TermineLaCita(Appoinment appoinment)
        {
            Model.Appoinment appoinmentAEliminar;
            appoinmentAEliminar = GetAppoinment(appoinment.id);
            appoinmentAEliminar.statte = AppoinmentState.FINALIZADA;
            DbContexto.Appoinments.Update(appoinmentAEliminar);
            DbContexto.SaveChanges();
        }

        public Model.Employee GetEmployee(string id)
        {
            foreach (var employee in DbContexto.Employees)
            {
                if (employee.employeeId == id)
                {
                    return employee;
                }
            }
            return null;
        }
    }
}
