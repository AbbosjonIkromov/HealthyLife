using System;

namespace CustomException
{
    class Program
    {
        static string  userName = "admin";
        static string password = "admin";
        static void Main(string[] lyuboy)
        {

            UserProfile user = new UserProfile();

            Console.Write("UserName: ");
            user.UserName = Console.ReadLine();
            Console.Write("Password: ");
            user.UserPassword = Console.ReadLine();

            try
            {
                Console.Clear();

                ValidateUser(user);

                Console.WriteLine("Welcome to the system...");
            }
            catch (InvalidUserCredentialsException ex)
            {
                Console.Clear();

                Logger.LogError(InvalidUserCredentialsException.Code, ex.Message);
            }
            finally
            {
                Console.WriteLine("\n\nSession finished");
            }


            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
        static void ValidateUser(UserProfile user)
        {
            if(user.UserName != userName || user.UserPassword != password)
                throw new InvalidUserCredentialsException();

        }
    }
}
