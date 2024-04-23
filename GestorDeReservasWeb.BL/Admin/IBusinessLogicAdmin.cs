using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;


namespace GestorDeReservasWeb.BL.Admin
{
    public interface IBusinessLogicAdmin
    {
        public void RegisterAppoinment(Model.Appoinment appoinment);
        public void RegisterPerson(Model.People person);
        public void RegisterEmployee(Model.Employee employee);
        public void RegisterUser(Model.User user);
        public List<Model.Appoinment> GetAppoinments();
        public List<Model.Users> GetUsers();
        public List<Model.Employee> GetEmployees();
        public List<Model.Appoinment> GetProgrammedAppoinments();
        public void EditeLaCita(Model.Appoinment appoinment);
        public void ElimineLaCita(Model.Appoinment appoinment);
        public Model.People GetPerson(int id);
        public Model.Appoinment GetAppoinment(int id);
        public Model.Employee GetEmployee(string id);
        public Model.User GetUser(string id);

    }
}
