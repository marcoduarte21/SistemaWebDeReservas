using GestorDeReservasWeb.BL.Admin;
using GestorDeReservasWeb.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace GestorDeReservasWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        DA.DbContexto DbContexto;
        BusinessLogicAdmin businessLogic;

        public AdminController(DA.DbContexto dbContexto)
        {
            DbContexto = dbContexto;
            businessLogic = new BusinessLogicAdmin(dbContexto);
        }


        [HttpPost("RegisterUser")]
        public IActionResult RegisterUser([FromBody] Model.User user)
        {
            businessLogic.RegisterUser(user);
            return Ok(user);
        }

        [HttpPost("RegisterPerson")]
        public IActionResult RegisterPerson([FromBody] Model.People person)
        {
            businessLogic.RegisterPerson(person);
            return Ok(person);
        }

        [HttpPost("RegisterEmployee")]
        public IActionResult RegisterEmployee([FromBody] Model.Employee employee)
        {
            businessLogic.RegisterEmployee(employee);
            return Ok(employee);
        }

        [HttpPost("RegisterAppoinment")]
        public IActionResult RegisterAppoinment([FromBody] Model.Appoinment appoinment)
        {
            businessLogic.RegisterAppoinment(appoinment);
            return Ok(appoinment);
        }

        [HttpGet("GetUsers")]
        public List<Model.Users> GetUsers()
        {
            return businessLogic.GetUsers();
        }

        [HttpGet("GetProgrammedAppoinments")]
        public List<Model.Appoinment> GetProgrammedAppoinments()
        {
            return businessLogic.GetProgrammedAppoinments();
        }

        [HttpGet("GetEmployees")]
        public List<Model.Employee> GetEmployees()
        {
            return businessLogic.GetEmployees();

        }

        [HttpGet("GetAppoinments")]
        public List<Model.Appoinment> GetAppoinments()
        {
            return businessLogic.GetAppoinments();

        }

        [HttpGet("GetAppoinment")]
        public Model.Appoinment GetAppoinment(int id)
        {
            return businessLogic.GetAppoinment(id);
        }

        [HttpGet("GetPerson")]
        public Model.People GetPerson(int id)
        {
            return businessLogic.GetPerson(id);
        }

        [HttpGet("GetUser")]
        public Model.User GetUser(string id)
        {
            return businessLogic.GetUser(id);
        }

        [HttpGet("getEmployee")]
        public Model.Employee GetEmployee(string id)
        {
            return businessLogic.GetEmployee(id);
        }

        [HttpPut("EditeLaCita")]
        public IActionResult EditeLaCita([FromBody] Appoinment appoinment)
        {
            if (ModelState.IsValid)
            {
                businessLogic.EditeLaCita(appoinment);
                return Ok(appoinment);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPut("CambieEstadoDeLaCita")]
        public IActionResult CambieEstadoDeLaCita(Appoinment appoinment)
        {
            if(ModelState.IsValid)
            {
                businessLogic.ElimineLaCita(appoinment);
                return Ok(appoinment);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

    }
}
