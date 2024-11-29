using ChallengeApp;
using System.Reflection.Metadata;

Employee employee1 = new Employee("Zbyszek", "Kieliszek", 30, 0);
Employee employee2 = new Employee("Anka", "Szklanka", 31, 0);
Employee employee3 = new Employee("Mietek", "Podnietek", 29, 0);

employee1.AddScore(6);
employee1.AddScore(3);
employee1.AddScore(8);
employee1.AddScore(7);
employee1.AddScore(5); //26

employee2.AddScore(2);
employee2.AddScore(9);
employee2.AddScore(4);
employee2.AddScore(6);
employee2.AddScore(7); //28

employee3.AddScore(4);
employee3.AddScore(6);
employee3.AddScore(3);
employee3.AddScore(5);
employee3.AddScore(4); //22

List<Employee> employees = new List<Employee>()
{ employee1, employee2, employee3 };

int maxResult = -1;
Employee EmployeeWithMaxResult = null;

foreach (var employee in employees)
{
    if(employee.Result > maxResult)
    {
        maxResult = employee.Result;
        EmployeeWithMaxResult = employee;
    }
}
Console.WriteLine("Name:" + EmployeeWithMaxResult.Name);
Console.WriteLine("Surname:" + EmployeeWithMaxResult.Surname);
Console.WriteLine("Age" + EmployeeWithMaxResult.Age);
Console.WriteLine("Result" + EmployeeWithMaxResult.Result);