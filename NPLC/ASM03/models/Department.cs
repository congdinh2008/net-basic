public class Department
{
    public Department(string? name)
    {
        Name = name;
    }

    public string? Name { get; set; }
    public List<Employee> Employees { get; set; } = new List<Employee>();

    public int CountOf<T>()
    {
        int count = 0;
        Employees.ForEach(e =>
        {
            if (e is T)
            {
                count++;
            }
        });
        return count;
        // return Employees.Count(x=> x is T);
    }

    public List<T> GetEmployees<T>()
    {
        List<T> result = new List<T>();
        Employees.ForEach(e =>
        {
            if (e is T other)
            {
                result.Add(other);
            }
        });
        return result;
    }

    public override string ToString()
    {
        return string.Format("| {0,-15} | {1,-15} | {2,-15} | {3,-15} |",
            Name, Employees.Count(), CountOf<SalariedEmployee>(), CountOf<HourlyEmployee>());
    }
}