namespace OpenClose
{
    public class EmployeePartTime : Employee
    {
        //Atributos

        //Constructor
        public EmployeePartTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        //Metodos 
        public override decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 20000M;
            decimal salary = hourValue * HoursWorked;
            if (HoursWorked > 160)
            {
                decimal effortCompensation = 5000M;
                int extraDays = HoursWorked - 160;
                salary += effortCompensation * extraDays;
            }
            return salary;
        }
    }
}