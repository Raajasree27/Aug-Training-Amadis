using System;
using System.Text.RegularExpressions;

namespace EmailValidationApp
{
    public class Validation
    {
        public static void ValidateEmail(string email)
        {
            try
            {
                // Email validation
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                if (!Regex.IsMatch(email, pattern))
                {
                    throw new FormatException("Invalid email format.");
                } 

                Console.WriteLine(" Email is valid: " + email);
            }
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(" Validation error: " + ex.Message);
            //}
            catch (Exception ex)
            {
                Console.WriteLine(" An unexpected error occurred: " + ex.Message);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your email: ");
            string userEmail = Console.ReadLine();

            Validation.ValidateEmail(userEmail);

        }
    }
}
