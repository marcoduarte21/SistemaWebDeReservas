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
            DbContexto.Appoinments.Update(appoinment);
            DbContexto.SaveChanges();
        }

        public void ElimineLaCita(Appoinment appoinment)
        {
            Model.Appoinment appoinmentAEliminar;
            appoinmentAEliminar = GetAppoinment(appoinment.id);
            appoinmentAEliminar.statte = AppoinmentState.DISPONIBLE;
            DbContexto.Appoinments.Update(appoinmentAEliminar);
            DbContexto.SaveChanges();
        }

        public Appoinment GetAppoinment(int id)
        {
           foreach(var appoiment in DbContexto.Appoinments)
            {
                if(appoiment.id == id)
                {
                    return appoiment;
                }
            }
            return null;
        }

        public List<Appoinment> GetAppoinments()
        {
           return DbContexto.Appoinments.ToList();
        }

        public Model.Employee GetEmployee(string id)
        {
            foreach (var employee in DbContexto.Employees)            {
                if (employee.employeeId == id)
                {
                    return employee;
                }
            }
            return null;
        }

        public List<Model.Employee> GetEmployees()
        {
           return DbContexto.Employees.ToList();
        }

        public People GetPerson(int id)
        {
            foreach (var person in DbContexto.People)
            {
                if (person.id == id)
                {
                    return person;
                }
            }
            return null;
        }

        public List<Appoinment> GetProgrammedAppoinments()
        {
            var listaDeCitasProgramadas = from appoinment in DbContexto.Appoinments
                                          where appoinment.statte == AppoinmentState.RESERVADA
                                          select appoinment;
            return listaDeCitasProgramadas.ToList();
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

        public List<Model.Users> GetUsers()
        {
            var listUsers = (from user in DbContexto.Users
                            join person in DbContexto.People
                            on user.idPerson equals person.id
                            select new Users
                            {
                                userId = user.userId,
                                idCard = person.idCard,
                                name = person.name,
                                firstSurname = person.firstSurname,
                                secondSurname = person.secondSurname,
                                email = person.email,
                                cellNumber = person.cellNumber,
                                rolle = user.rolle,
                                password = user.passwordd
                            });

            return listUsers.ToList();

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