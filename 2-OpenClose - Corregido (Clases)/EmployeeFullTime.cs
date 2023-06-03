namespace OpenClose
{
    public class EmployeeFullTime : Employee
    {
        //Atributos

        //Constructor
        public EmployeeFullTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        //Metodos
        public override decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 30000M;
            decimal salary = hourValue * HoursWorked;
            return salary;
        }
    }
}