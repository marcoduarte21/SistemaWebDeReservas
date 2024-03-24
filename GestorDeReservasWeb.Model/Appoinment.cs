using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeReservasWeb.Model
{
    public class Appoinment
    {
        public int id {  get; set; }
        public DateTime datte { get; set; }
        public TipoDeCita appoinmentType { get; set; }
        public string clientUser { get; set; }
        public string employeeInChange { get; set; }
        public AppoinmentState statte { get; set; } 
    }
}
