using System;

namespace PetraWheels
{
    public class LoginManager
    {
        public static bool Login()
        {
            const string username = "admin";
            const string password = "1234";

            int attempts = 0;

            while (attempts < 3)
            {
                Console.Write("Username: ");
                string inputUsername = Console.ReadLine();

                Console.Write("Password: ");
                string inputPassword = Console.ReadLine();

                if (inputUsername == username &&
                    inputPassword == password)
                {
                    Console.WriteLine("\nLogin successful!");
                    return true;
                }

                attempts++;

                Console.WriteLine(
                    $"Invalid username or password. Attempts left: {3 - attempts}");
            }

            Console.WriteLine("Maximum attempts reached. Exiting...");
            return false;
        }
    }
}