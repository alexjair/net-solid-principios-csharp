namespace Liskov
{
    
    public class EmployeeFullTime : Employee
    {
    
        //Atributos
        public int ExtraHours { get; set; }

        public EmployeeFullTime(
            string fullname, 
            int hoursWorked, 
            int extrahours
            ) : base(
                fullname, 
                hoursWorked
            )
        { }

        public override decimal CalculateSalary()
        {
            decimal hourValue = 40;
            return hourValue * (HoursWorked + ExtraHours);
        }
    }
}