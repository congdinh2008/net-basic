public class CompanyManager
{
    public void CreateDepartment(Company company)
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

        company.Departments.Add(new Department(name));
    }

    public void ReportDepartments(Company company)
    {
        Console.WriteLine("Department Information - {0}:", company.Name);
        Console.WriteLine("--------------------------------------------------------------------------------------------------");
        Console.WriteLine("|   Name          |   Number of Employees     |   Salaried Employees      |   Hourly Employees   |");
        Console.WriteLine("--------------------------------------------------------------------------------------------------");

        company.Departments.ForEach(d =>
        {
            System.Console.WriteLine(d.ToString());
        });
    }

    public void DisplayListEmployees(Company company)
    {
        Console.WriteLine("All Employee Information:");
        Console.WriteLine("----------------------------------------------------------------------------------------------");
        Console.WriteLine("|   Type Of Employee   |   SSN           |   First Name    |   Last Name     |      Birth Date       |     Phone       |   Email                      |   Commission Rate    |   Gross Sales   |   Basic Salary  |    Rate    |  Working Hours  |");
        Console.WriteLine("----------------------------------------------------------------------------------------------");


        company.Departments.ForEach(d =>
        {
            d.Employees.ForEach(e =>
            {
                string print = String.Empty;
                if (e is SalariedEmployee)
                {
                    print = string.Format("| {0,-20} {1,-15} {2,-10} | {3,-15} |", e.GetType(), e.ToString(), "", "");
                }
                if (e is HourlyEmployee other)
                {
                    print = string.Format("| {0,-20} | {1,-15} | {2,-15} | {3,-15} | {4,-15} | {5,-15} | {6,-28} | {7,-20} | {8, -15} | {9, -15} | {10, -10} | {11, -15} |", e.GetType(), other.SSN, other.FirstName, other.LastName, other.BirthDate, other.Phone, other.Email, "", "", "", other.Rate, other.WorkingHours);
                }
                System.Console.WriteLine(print);
            });
        });
    }

    internal void ClassifyEmployees(Company vivu)
    {
        var salariedEmployees = new List<SalariedEmployee>();
        var hourlyEmployees = new List<HourlyEmployee>();

        vivu.Departments.ForEach(d =>
        {
            salariedEmployees.AddRange(d.GetEmployees<SalariedEmployee>());
            hourlyEmployees.AddRange(d.GetEmployees<HourlyEmployee>());
        });

        System.Console.WriteLine($"---------------- Salaried Employee - {vivu.Name} Management ----------------");
        Console.WriteLine("----------------------------------------------------------------------------------------------");
        Console.WriteLine("|   SSN           |   First Name    |   Last Name     |      Birth Date       |     Phone       |   Email                      |   Commission Rate    |   Gross Sales   |   Basic Salary  |");
        Console.WriteLine("----------------------------------------------------------------------------------------------");
        salariedEmployees.ForEach(e =>
        {
            System.Console.WriteLine(e.ToString());
        });

        System.Console.WriteLine();
        System.Console.WriteLine($"---------------- Hourly Employee - {vivu.Name} Management ----------------");
        Console.WriteLine("----------------------------------------------------------------------------------------------");
        Console.WriteLine("|   SSN           |   First Name    |   Last Name     |      Birth Date       |     Phone       |   Email                      |   Rate   |   Working Hours  |");
        Console.WriteLine("----------------------------------------------------------------------------------------------");
        hourlyEmployees.ForEach(e =>
        {
            System.Console.WriteLine(e.ToString());
        });
    }
}