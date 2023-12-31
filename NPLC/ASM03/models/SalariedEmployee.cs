public class SalariedEmployee : Employee
{
    public SalariedEmployee(string? sSN, string? firstName, string? lastName,
        DateTime birthDate, string? phone, string? email, double commisstionRate,
        double grossSales, double basicSalary)
        : base(sSN, firstName, lastName, birthDate, phone, email)
    {
        CommisstionRate = commisstionRate;
        GrossSales = grossSales;
        BasicSalary = basicSalary;
    }

    public double CommisstionRate { get; set; }

    public double GrossSales { get; set; }

    public double BasicSalary { get; set; }

    public override double GetPaymentAmount()
    {
        return CommisstionRate * GrossSales + BasicSalary;
    }

    public override string ToString()
    {
        return string.Format("| {0,-15} | {1,-15} | {2,-15} | {3,-15} | {4,-15} | {5,-28} | {6,-20} | {7,-15} | {8,-15} |",
            SSN, FirstName, LastName, BirthDate, Phone, Email, CommisstionRate, GrossSales, BasicSalary);
    }
}