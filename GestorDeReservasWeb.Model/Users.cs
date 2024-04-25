using GestorDeReservasWeb.Model;
using System.Numerics;

namespace GestorDeReservasWeb.Model
{
    public class Users
    {
        public string userId { get; set; }
        public string idCard { get; set; }
        public string name { get; set; }
        public string firstSurname { get; set; }
        public string secondSurname { get; set; }
        public string email { get; set; }
        public Int64 cellNumber { get; set; }
        public Rol rolle { get; set; }
        public string password { get; set; }    
    }
}