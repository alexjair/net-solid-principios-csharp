using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    public abstract class Employee
    {
        //Atributos
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        //Metodos
        public abstract decimal CalculateSalaryMonthly();

    }
}
