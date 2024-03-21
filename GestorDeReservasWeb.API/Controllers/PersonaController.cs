using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestorDeReservasWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        DA.DbContexto DbContexto;
        BL.BusinessLogicReservation BusinessLogicReservation;

        public PersonaController(DA.DbContexto dbContexto)
        {
            DbContexto = dbContexto;
            BusinessLogicReservation = new BL.BusinessLogicReservation(dbContexto);
        }

        [HttpGet("GetReservations")]
        public List<Model.Appoinment> GetReservations()
        {
            return BusinessLogicReservation.GetAllReservacion();
        }
    }
}
