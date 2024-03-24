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


        }
}
