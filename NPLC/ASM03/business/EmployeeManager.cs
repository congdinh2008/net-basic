public class EmployeeManager
{
    public void DisplayMenu(Company company)
    {
        int option = 0;
        bool rightChoose = false;
        do
        {
            System.Console.WriteLine("---------------- Create a new Employee - Menu Management ----------------");
            Console.WriteLine("1. Create Salary department");
            Console.WriteLine("2. Create Hourly employee");
            Console.WriteLine("Enter a number between 1 and 2 to choose action: ");

            if (int.TryParse(Console.ReadLine(), out option))
            {
                if (option >= 1 && option <= 2)
                {
                    rightChoose = true;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 2.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        } while (!rightChoose);

        switch (option)
        {
            case 1:
                var salariedEmployee = CreateSalariedEmployee();
                AddEmployeeToDepartment(salariedEmployee, company);
                break;
            case 2:
                var hourlyEmployee = CreateHourlyEmployee();
                AddEmployeeToDepartment(hourlyEmployee, company);
                break;
            default:
                break;
        }
    }

    public SalariedEmployee CreateSalariedEmployee()
    {
        System.Console.WriteLine("---------------- Creating Salaried Employee ----------------");

        InputHelpers inputHelpers = new InputHelpers();

        System.Console.WriteLine("SSN:");
        string? ssn = System.Console.ReadLine();

        System.Console.WriteLine("First Name:");
        string? firstName = System.Console.ReadLine();

        System.Console.WriteLine("Last Name:");
        string? lastName = System.Console.ReadLine();

        string? email = inputHelpers.InputEmail();

        string? phoneNumber = inputHelpers.InputPhoneNumber();

        string format = "dd/MM/yyyy";
        DateTime birthDate = inputHelpers.InputDateTime(format);

        System.Console.WriteLine("Commission Rate:");
        double commissionRate = double.Parse(System.Console.ReadLine() ?? "0");

        System.Console.WriteLine("Gross Sales:");
        double grossSales = double.Parse(System.Console.ReadLine() ?? "0");

        System.Console.WriteLine("Basic Salary:");
        double basicSalary = double.Parse(System.Console.ReadLine() ?? "0");

        return new SalariedEmployee(ssn, firstName, lastName, birthDate, phoneNumber, email, commissionRate, grossSales, basicSalary);
    }

    public HourlyEmployee CreateHourlyEmployee()
    {
        System.Console.WriteLine("---------------- Creating Hourly Employee ----------------");

        InputHelpers inputHelpers = new InputHelpers();

        System.Console.WriteLine("SSN:");
        string? ssn = System.Console.ReadLine();

        System.Console.WriteLine("First Name:");
        string? firstName = System.Console.ReadLine();

        System.Console.WriteLine("Last Name:");
        string? lastName = System.Console.ReadLine();

        string? email = inputHelpers.InputEmail();

        string? phoneNumber = inputHelpers.InputPhoneNumber();

        string format = "dd/MM/yyyy";
        DateTime birthDate = inputHelpers.InputDateTime(format);

        System.Console.WriteLine("Rate:");
        double rate = double.Parse(System.Console.ReadLine() ?? "0");

        System.Console.WriteLine("Working Hours:");
        double workingHours = double.Parse(System.Console.ReadLine() ?? "0");

        return new HourlyEmployee(ssn, firstName, lastName, birthDate, phoneNumber, email, rate, workingHours);
    }

    private void AddEmployeeToDepartment(Employee employee, Company vivu)
    {
        int option = 0;
        bool rightChoose = false;
        do
        {
            System.Console.WriteLine("---------------- Add Employee to Department - Menu Management ----------------");

            int i = 1;
            vivu.Departments.ForEach(d =>
            {
                System.Console.WriteLine($"{i}. {d.Name}");
                i++;
            });

            if (int.TryParse(Console.ReadLine(), out option))
            {
                if (option >= 1 && option <= vivu.Departments.Count)
                {
                    rightChoose = true;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please enter a number between 1 and {0}.", vivu.Departments.Count);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        } while (!rightChoose);

        vivu.Departments[option - 1].Employees.Add(employee);
    }
}