Console.WriteLine("How many employees do you want to add?");
int numberOfEmployees = int.Parse(Console.ReadLine());

List<ExerciceList.Employee> employees = new List<ExerciceList.Employee>();

for( int i = 1; i <= numberOfEmployees; i++)
{
    Console.WriteLine("Employee #" + i + ":");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    float salary = float.Parse(Console.ReadLine());
    employees.Add(new ExerciceList.Employee(id, name, salary));
}

Console.WriteLine("Enter the employee id that will have salary increase: ");
int searchId = int.Parse(Console.ReadLine());
ExerciceList.Employee emp = employees.Find(match: x => x.Id == searchId);
if(emp != null)
{
    Console.WriteLine("Enter the percentage: ");
    float percentage = float.Parse(Console.ReadLine());
    emp.IncreaseSalary(percentage);
}
else
{
    Console.WriteLine("Employee not found!");
}

Console.WriteLine();
Console.WriteLine("Updated list of employees: ");
foreach (ExerciceList.Employee obj in employees)
{
    Console.WriteLine(obj);
}

