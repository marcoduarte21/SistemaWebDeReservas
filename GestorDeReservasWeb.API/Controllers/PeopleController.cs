using GestorDeReservasWeb.BL.Admin;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestorDeReservasWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        DA.DbContexto DbContexto;
        BusinessLogicAdmin businessLogic;

        public PeopleController(DA.DbContexto dbContexto)
        {
            DbContexto = dbContexto;
            businessLogic = new BusinessLogicAdmin(dbContexto);
        }

        [HttpGet("GetAppoinments")]
        public List<Model.Appoinment> GetReservations()
        {
            return businessLogic.GetAppoinments().ToList();
        }
    }
}
