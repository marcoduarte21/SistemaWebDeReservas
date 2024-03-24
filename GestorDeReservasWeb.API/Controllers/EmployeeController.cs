using GestorDeReservasWeb.BL.Client;
using GestorDeReservasWeb.BL.Employee;
using Microsoft.AspNetCore.Mvc;

namespace GestorDeReservasWeb.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        DA.DbContexto DbContexto;
        BLEmployee businessLogic;

        public EmployeeController(DA.DbContexto dbContexto)
        {
            DbContexto = dbContexto;
            businessLogic = new BLEmployee(dbContexto);
        }

        [HttpGet("GetListCitasProgramadas")]
        public List<Model.Appoinment> GetListCitasProgramadas(string employeeId) {

            Model.Employee employee = businessLogic.GetEmployee(employeeId);
        
            return businessLogic.GetListCitasProgramadas(employee).ToList();
        
        }

        [HttpPut("TermineLaCita")]
        public IActionResult TermineLaCita(Model.Appoinment appoinment)
        {
            if (ModelState.IsValid)
            {
                businessLogic.TermineLaCita(appoinment);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }


    }
}
