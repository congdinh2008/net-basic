public class HourlyEmployee : Employee
{
    public HourlyEmployee(string? sSN, string? firstName, string? lastName,
        DateTime birthDate, string? phone, string? email, double rate, double workingHours)
        : base(sSN, firstName, lastName, birthDate, phone, email)
    {
        Rate = rate;
        WorkingHours = workingHours;
    }

    public double Rate { get; set; }
    public double WorkingHours { get; set; }

    public override double GetPaymentAmount()
    {
        return (double)Rate * WorkingHours;
    }

    public override string ToString()
    {
        return string.Format("| {0,-15} | {1,-15} | {2,-15} | {3,-15} | {4,-15} | {5,-28}| {6,-15}| {7,-15}|",
            SSN, FirstName, LastName, BirthDate, Phone, Email, Rate, WorkingHours);
    }
}