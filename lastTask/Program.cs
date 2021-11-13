// See https://aka.ms/new-console-template for more information

User Account = new User(); // instance from class

Console.WriteLine("Enter your first name");
Account.firstName = Console.ReadLine();

Console.WriteLine("Enter your last name");
Account.lastName=Console.ReadLine();

Console.WriteLine("Enter your email");
Account.email = Console.ReadLine();

Console.WriteLine("Enter your password");
Account.password=Console.ReadLine();

Console.WriteLine("Enter you confirm password");
Account.confirmPassword=Console.ReadLine();

Console.WriteLine("Enter your Monthely solory");
Account.mounthSalary=Convert.ToDouble( Console.ReadLine());

Console.WriteLine("Enter your birthday");
Account.birthday = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine("Enter your National id");
Account.nationalId = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your phone number");
Account.phoneNumber = Console.ReadLine();

if (Account.IsMatch())
{
    if (Account.IsUserAdult())
    {
        Console.WriteLine("User is allowed to use this app");
        if (Account.NationalIDValidation())
        {
            Console.WriteLine(Account.GetFullName());
            Console.WriteLine(Account.YearlySalary());        
        }
        else
        {
            Console.WriteLine("national id is not correct");
        }
    }
    else
    {
        Console.WriteLine("User is not allowed to use this app");
        Console.ReadLine();
    }
}
else
{
    Console.WriteLine("Password not match");
}


