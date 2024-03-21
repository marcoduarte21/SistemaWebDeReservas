using System.Globalization;
using System.Security.Principal;

namespace GestorDeReservasWeb.Model
{
    public class People
    {
        public int id { get; set; }
        public string idCard { get; set; }
        public string name { get; set; }
        
        public string firstSurname { get; set; }
        public string secondSurname { get;set; }
        public string email { get; set; }
        public string addres { get; set; }
        public int cellNumber { get; set; }
    }
}