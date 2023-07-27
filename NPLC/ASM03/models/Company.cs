public class Company
{
    public Company(string? name)
    {
        Name = name;
    }

    public string? Name { get; set; }

    public List<Department> Departments { get; set; } = new List<Department>();

    public void ReportDepartments()
    {
        Console.WriteLine("Department Information - {0}:", Name);
        Console.WriteLine("--------------------------------------------------------------------------------------------------");
        Console.WriteLine("|   Name          |   Number of Employees     |   Salaried Employees      |   Hourly Employees   |");
        Console.WriteLine("--------------------------------------------------------------------------------------------------");

        Departments.ForEach(d =>
        {
            System.Console.WriteLine(d.ToString());
        });
    }

    public Department CreateDepartment()
    {
        string? name = string.Empty;
        do
        {
            System.Console.WriteLine("Please enter department name:");
            name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name))
            {
                break;
            }
            else
            {
                System.Console.WriteLine("Please enter an valid department name:");
            }
        } while (true);

        return new Department(name);
    }
}