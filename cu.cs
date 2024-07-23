IEmployee employee = Employees.FirstOrDefault(e => e.FullName.Equals(employeeFullName));

if (employee != null)
{
    Console.WriteLine($"Found employee: {employee.FullName} with ID: {employee.Id}");
}
else
{
    Console.WriteLine("Employee not found.");
}
