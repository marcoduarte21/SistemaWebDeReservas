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
           return DbContexto.Appoinments.ToList();
        }

        public Model.Employee GetEmployee(string id)
        {
            throw new NotImplementedException();
        }

        public List<Model.Employee> GetEmployees()
        {
           return DbContexto.Employees.ToList();
        }

        public People GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public List<Appoinment> GetProgrammedAppoinments()
        {
            return DbContexto.Appoinments.ToList();
        }

        public User GetUser(string id)
        {
           foreach(var user in DbContexto.Users)
            {
                if(user.userId == id)
                {
                    return user;
                }
            }
            return null;
        }

        public List<User> GetUsers()
        {
            return DbContexto.Users.ToList();
        }

        public void RegisterAppoinment(Appoinment appoinment)
        {
            DbContexto.Appoinments.Add(appoinment);
            DbContexto.SaveChanges();
        }

        public void RegisterEmployee(Model.Employee employee)
        {
            DbContexto.Employees.Add(employee);
            DbContexto.SaveChanges();
        }

        public void RegisterPerson(People person)
        {
            DbContexto.People.Add(person);
            DbContexto.SaveChanges();
        }

        public void RegisterUser(User user)
        {
           DbContexto.Users.Add(user);
            DbContexto.SaveChanges();
        }
    }
}