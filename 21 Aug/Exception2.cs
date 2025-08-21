using System;

namespace UsernameValidationApp
{
    // Custom exception for invalid usernames
    public class InvalidUsernameException : Exception
    {
        public InvalidUsernameException(string message) : base(message)
        {
        }
    }

    // Validation class
    public class Validation
    {
        public static void ValidateUsername(string username)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(username))
                {
                    throw new InvalidUsernameException("Username cannot be empty.");
                }

                if (username.Length < 5)
                {
                    throw new InvalidUsernameException("Username must be at least 5 characters long.");
                }

                if (username.Contains(" "))
                {
                    throw new InvalidUsernameException("Username cannot contain spaces.");
                }

                Console.WriteLine(" Username is valid: " + username);
            }
            catch (InvalidUsernameException ex)
            {
                Console.WriteLine("Invalid username: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(" An unexpected error occurred: " + ex.Message);
            }
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your username: ");
            string userInput = Console.ReadLine();

            Validation.ValidateUsername(userInput);

        }
    }
}
