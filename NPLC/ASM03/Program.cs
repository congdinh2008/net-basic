internal class Program
{
    private static void Main(string[] args)
    {
        Company vivu = new Company("ViVu Store");

        Department it = new Department("IT");
        Department accounting = new Department("Accounting");
        Department business = new Department("Business");

        Employee john = new SalariedEmployee("SSN001", "John", "Doe", DateTime.Parse("1990-01-15"), "123456789", "john@example.com", 0.10, 10000, 2000);
        Employee jane = new SalariedEmployee("SSN002", "Jane", "Smith", DateTime.Parse("1985-05-20"), "987654321", "jane@example.com", 0.08, 8000, 1500);
        Employee mike = new SalariedEmployee("SSN003", "Mike", "Johnson", DateTime.Parse("1988-09-30"), "555555555", "mike@example.com", 0.05, 9000, 1800);

        Employee alice = new HourlyEmployee("SSN101", "Alice", "Brown", DateTime.Parse("1992-03-25"), "111111111", "alice@example.com", 25, 40);
        Employee bob = new HourlyEmployee("SSN102", "Bob", "Williams", DateTime.Parse("1987-08-10"), "222222222", "bob@example.com", 20, 30);
        Employee emily = new HourlyEmployee("SSN103", "Emily", "Davis", DateTime.Parse("1995-12-05"), "333333333", "emily@example.com", 18, 35);

        it.Employees.Add(john);
        it.Employees.Add(jane);
        it.Employees.Add(alice);

        accounting.Employees.Add(mike);
        accounting.Employees.Add(bob);
        accounting.Employees.Add(emily);
        
        vivu.Departments.Add(it);
        vivu.Departments.Add(accounting);
        vivu.Departments.Add(business);

        System.Console.WriteLine("---------------- {0} Management ----------------", vivu.Name);

        int option = 0;
        bool rightChoose = false;
    Menu:
        do
        {
            Console.WriteLine("---------------- Menu Management ----------------");
            Console.WriteLine("1. Create a new department");
            Console.WriteLine("2. Create a new employee");
            Console.WriteLine("3. Display list of employees");
            Console.WriteLine("4. Classify employees");
            Console.WriteLine("5. Departments Report");
            Console.WriteLine("6. Exit application");
            Console.WriteLine("Enter a number between 1 and 6 to choose action: ");

            if (int.TryParse(Console.ReadLine(), out option))
            {
                if (option >= 1 && option <= 6)
                {
                    rightChoose = true;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 6.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        } while (!rightChoose);

        CompanyManager companyManager = new CompanyManager();
        EmployeeManager employeeManager = new EmployeeManager();

        switch (option)
        {
            case 1:
                System.Console.WriteLine("---------------- Create a new Department - Menu Management ----------------");
                companyManager.CreateDepartment(vivu);
                break;
            case 2:
                employeeManager.DisplayMenu(vivu);
                break;
            case 3:
                System.Console.WriteLine("---------------- Display List of Employees - Menu Management ----------------");
                companyManager.DisplayListEmployees(vivu);
                break;
            case 4:
                System.Console.WriteLine("---------------- Classify Employees - Menu Management ----------------");
                companyManager.ClassifyEmployees(vivu);
                break;
            case 5:
                System.Console.WriteLine("---------------- Department Reports - Menu Management ----------------");
                companyManager.ReportDepartments(vivu);
                break;
            case 6:
                System.Console.WriteLine("---------------- Exit Application - Menu Management ----------------");
                Environment.Exit(0);
                break;
            default:
                break;
        }
        goto Menu;
    }
}