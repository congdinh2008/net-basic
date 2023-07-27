using System.Globalization;
using System.Text.RegularExpressions;

public class InputHelpers
{

    public DateTime InputDateTime(string format)
    {
        CultureInfo viVN = new CultureInfo("vi-VN");
        DateTime dateOfBirth;
        do
        {
            System.Console.WriteLine("Date of Birth({0}):", format);
            bool converted = DateTime.TryParseExact(System.Console.ReadLine(), format, viVN, DateTimeStyles.None, out dateOfBirth);
            if (converted)
            {
                break;
            }
            else
            {
                System.Console.WriteLine("Please enter a valid date!");
            }

        } while (true);

        return dateOfBirth;
    }

    public string? InputEmail()
    {
        string? email;
        do
        {
            System.Console.WriteLine("Email:");
            email = System.Console.ReadLine();

            if (IsValidEmail(email))
            {
                break;
            }
            else
            {
                System.Console.WriteLine("Please enter a valid email!");
            }

        } while (true);

        return email;
    }

    public string? InputPhoneNumber()
    {
        string? phone;
        do
        {
            System.Console.WriteLine("Phone Number:");
            phone = System.Console.ReadLine();

            if (IsValidPhoneNumber(phone))
            {
                break;
            }
            else
            {
                System.Console.WriteLine("Please enter a valid phone number!");
            }

        } while (true);

        return phone;
    }

    private static bool IsValidEmail(string? email)
    {
        // Regex pattern for email validation
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        // Use Regex.IsMatch to check if the email matches the pattern
        return Regex.IsMatch(email ?? "", pattern);
    }

    static bool IsValidPhoneNumber(string? phoneNumber)
    {
        // Regex pattern for phone number validation (minimum 7 digits)
        string pattern = @"^\d{7,}$";

        // Use Regex.IsMatch to check if the phone number matches the pattern
        return Regex.IsMatch(phoneNumber ?? "", pattern);
    }
}