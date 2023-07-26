public class Company
{
    public Company(string? name)
    {
        Name = name;
    }

    public string? Name { get; set; }

    public List<Department> Departments { get; set; } = new List<Department>();
}