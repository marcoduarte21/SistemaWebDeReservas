using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeReservasWeb.Model
{
    public class User
    {
       public string userId {  get; set; }
        public string idPerson { get; set; }
        public string passwordd { get; set; }
        public Rol rolle { get; set; }
    }
}
