using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeReservasWeb.Model
{
    public class Appoinments
    {
        public int id {  get; set; }
        public DateTime datte { get; set; }
        public TipoDeCita appoinmentType { get; set; }
        public Users clientUser { get; set; }
        public Employees employeeInChange { get; set; }
        public AppoinmentState statte { get; set; } 
    }
}
