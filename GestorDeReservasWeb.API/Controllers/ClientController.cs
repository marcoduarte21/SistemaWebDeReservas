using GestorDeReservasWeb.BL.Admin;
using GestorDeReservasWeb.BL.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestorDeReservasWeb.API.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class ClientController : ControllerBase
        {
            DA.DbContexto DbContexto;
            BLClient businessLogic;

            public ClientController(DA.DbContexto dbContexto)
            {
                DbContexto = dbContexto;
                businessLogic = new BLClient(dbContexto);
            }

        [HttpPut("AgendarCita")]
        public IActionResult AgendarCita(Model.Appoinment appoinment)
        {
            if(ModelState.IsValid)
            {
                businessLogic.AgendarCita(appoinment);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpGet("GetProgrammedAppoinments")]
        public List<Model.Appoinment> GetProgrammedAppoinments(string userId)
        {
            Model.User user = businessLogic.GetUser(userId);
            return businessLogic.GetListCitasProgramadas(user).ToList();
        }

        }
}
