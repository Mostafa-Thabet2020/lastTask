// See https://aka.ms/new-console-template for more information
//string length
//confirm password

public class User
{
    public string firstName;
    public string lastName;
    public string email;
    public string password;
    public string confirmPassword;
    public DateTime birthday;
    public double mounthSalary;
    public string phoneNumber;
    public int nationalId;

    private int adultAge = 18;

    private DateTime CurrentTime = DateTime.Now;
    private int ColculateAge()
    {
        return CurrentTime.Year - birthday.Year;
    }
    public bool IsUserAdult()
    {

        if (ColculateAge() >= adultAge)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IsMatch()
    {
        if (password == confirmPassword)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool NationalIDValidation()
    {
        string NationalIdString = Convert.ToString(nationalId);
        if (NationalIdString.Length == 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetFullName()
    {

        //return "full name is " + firstName + " " + lastName;
        return $"full name is {firstName} {lastName}"; // best way
        //return string.Concat(firstName, lastName);
    }
    public string YearlySalary()
    {
        //double yearly = mounthSalary * 12;
        //string text = "Yearly salary is ";
        //string lastText = text + Convert.ToString(yearly);
        //return lastText;
        
        return string.Concat("Yearly salary is ", Convert.ToString( mounthSalary * 12));
    }
}