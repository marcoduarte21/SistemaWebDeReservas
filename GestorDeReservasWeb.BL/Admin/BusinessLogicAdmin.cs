using GestorDeReservasWeb.DA;
using GestorDeReservasWeb.Model;

namespace GestorDeReservasWeb.BL.Admin
{
    public class BusinessLogicAdmin : IBusinessLogicAdmin
    {
        private DbContexto DbContexto;

        public BusinessLogicAdmin(DbContexto dbContexto)
        {
            DbContexto = dbContexto;
        }

        public void EditeLaCita(Appoinment appoinment)
        {
            throw new NotImplementedException();
        }

        public void ElimineLaCita(Appoinment appoinment)
        {
            throw new NotImplementedException();
        }

        public Appoinment GetAppoinment(int id)
        {
            throw new NotImplementedException();
        }

        public List<Appoinment> GetAppoinments()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(string id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public People GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public List<Appoinment> GetProgrammedAppoinments()
        {
            throw new NotImplementedException();
        }

        public User GetUser(string id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void RegisterAppoinment(Appoinment appoinment)
        {
            throw new NotImplementedException();
        }

        public void RegisterEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void RegisterPerson(People person)
        {
            throw new NotImplementedException();
        }

        public void RegisterUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}