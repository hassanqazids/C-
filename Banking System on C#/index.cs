using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string lastname = "";
            int age = 0; // Set a default value for age
            string gender = "";
            string email = "";
            int pin = 0;
            double accountBalance = 0.0;
            bool isAccountCreated = false;

            while (true)
            {
                Console.WriteLine("WELCOME");
                Console.WriteLine("Select option");
                Console.WriteLine("A: Create Account");
                Console.WriteLine("B: Withdraw");
                Console.WriteLine("C: Deposit");

                string option = Console.ReadLine();

                if (option.ToLower() == "a" && !isAccountCreated)
                {
                    Console.WriteLine("ENTER YOUR NAME");
                    name = Console.ReadLine();

                    Console.WriteLine("ENTER YOUR LASTNAME");
                    lastname = Console.ReadLine();

                    Console.WriteLine("ENTER YOUR AGE");
                    age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER YOUR GENDER");
                    gender = Console.ReadLine();

                    Console.WriteLine("ENTER YOUR EMAIL");
                    email = Console.ReadLine();

                    Console.WriteLine("ENTER YOUR PIN");
                    pin = Convert.ToInt32(Console.ReadLine());

                    isAccountCreated = true;

                    Console.WriteLine("ACCOUNT CREATED");
                    Console.WriteLine("YOUR ACCOUNT DETAILS");
                    Console.WriteLine("NAME: " + name);
                    Console.WriteLine("LASTNAME: " + lastname);
                    Console.WriteLine("AGE: " + age);
                    Console.WriteLine("GENDER: " + gender);
                    Console.WriteLine("EMAIL: " + email);
                    Console.WriteLine("PIN: " + pin);
                }
                else if (option.ToLower() == "b" && isAccountCreated)
                {
                    Console.WriteLine("Enter the amount to withdraw:");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());

                    if (withdrawAmount <= accountBalance)
                    {
                        accountBalance -= withdrawAmount;
                        Console.WriteLine($"You have successfully withdrawn {withdrawAmount}. New balance: {accountBalance}");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient funds.");
                    }
                }
                else if (option.ToLower() == "c" && isAccountCreated)
                {
                    Console.WriteLine("Enter the amount to deposit:");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    accountBalance += depositAmount;
                    Console.WriteLine($"You have successfully deposited {depositAmount}. New balance: {accountBalance}");
                }
                else
                {
                    Console.WriteLine("Invalid option or account not created yet.");
                }
            }
        }
    }
}
