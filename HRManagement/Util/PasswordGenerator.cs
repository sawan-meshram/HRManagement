using System;
namespace HRManagement.Util
{
    public class PasswordGenerator
    {
        public PasswordGenerator()
        {
            Console.WriteLine(CreateRandomPassword());
            Console.WriteLine(CreateRandomPassword(8));
        }

        private static string CreateRandomPassword(int length = 10)
        {
            // Create a string of characters, numbers, special characters that allowed in the password
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
            Random random = new Random();

            // Select one random character at a time from the string
            // and create an array of chars
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            return new string(chars);
        }
    }
}
