internal class Program
{
    private static void Main(string[] args)
    {
        Company vivu = new Company("ViVu Store");

        Department it = new Department("IT");
        Department accounting = new Department("Accounting");
        Department business = new Department("Business");

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

        switch (option)
        {
            case 1:
                System.Console.WriteLine("---------------- Create a new Department - Menu Management ----------------");
                Department newDepartment = vivu.CreateDepartment();
                vivu.Departments.Add(newDepartment);
                break;
            case 2:
                EmployeeManager employeeManager = new EmployeeManager();
                employeeManager.DisplayMenu(vivu);
                break;
            case 3:
                System.Console.WriteLine("---------------- Display List of Employees - Menu Management ----------------");
                break;
            case 4:
                System.Console.WriteLine("---------------- Classify Employees - Menu Management ----------------");
                break;
            case 5:
                System.Console.WriteLine("---------------- Department Reports - Menu Management ----------------");
                vivu.ReportDepartments();
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