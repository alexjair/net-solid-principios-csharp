using OpenClose;

/****************[ FUNCTIONS]*******************/

void ShowSalaryMonthly(List<Employee> employees)
{
   foreach (Employee employee in employees)
    {
        Console.WriteLine($"Empleado: {employee.Fullname}, pago: {employee.CalculateSalaryMonthly():C1}");
    }
}


/******************[ MAIN ]*******************/

ShowSalaryMonthly(
    new List<Employee>()
    {
        new EmployeeFullTime("Pepito Pérez", 160),
        new EmployeePartTime("Manuel Lopera", 180),
        new EmployeeContractor("Contractor Lopera", 180)
    }
);


