public abstract class Employee : IEmployee
{
    protected Employee(string? sSN, string? firstName, string? lastName, DateTime birthDate, string? phone, string? email)
    {
        SSN = sSN;
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        Phone = phone;
        Email = email;
    }

    public string? SSN { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }

    public abstract double GetPaymentAmount();

    public override string ToString()
    {
        return string.Format("| {0,-15} | {1,-15} | {2,-15} | {3,-15} | {4,-15} | {5,-28}|",
            SSN, FirstName, LastName, BirthDate, Phone, Email);
    }
}