using System.Text.Json.Serialization;

namespace AppsLab_019_MethodsOverloading
{
    /// <summary>
    /// Represents a password generator that can generate random passwords.
    /// </summary>
    public class PasswordGenerator
    {
        private const int DefaultLength = 8;
        private const string Alphabet = "abcdefghijklmnopqrstuvwxyz";
        private const string SpecialChars = "!@#$%^&*()";
        private const string Numbers = "0123456789";

        private readonly Random _random = new();
        readonly string _password;  
        readonly string _salt;  
        private readonly string _salt2;
        private readonly string _salt3;
        

        /// <summary>
        /// Generates a random password with the default length of 8 characters and no special characters or numbers.
        /// </summary>
        /// <returns>A randomly generated password.</returns>
        public string GeneratePassword()
        {
            var random = new Random();
            var result = "";

            for (int i = 0; i < 8; i++)
            {
                result += Alphabet[random.Next(Alphabet.Length -1)];
            }
            return result;

        }

        /// <summary>
        /// Generates a random password with the specified length and no special characters or numbers.
        /// </summary>
        /// <param name="length">The length of the password to generate.</param>
        /// <returns>A randomly generated password.</returns>
        public string GeneratePassword(int length)
        {
            var random = new Random();
            var result = "";

            string password = "";
            for (int i = 0; i < length; i++) ;
            {
                result += Alphabet[random.Next(Alphabet.Length - 1)];
            }
            return result;
        
        }

        /// <summary>
        /// Generates a random password with the specified length, and optionally includes special characters and/or numbers.
        /// </summary>
        /// <param name="length">The length of the password to generate.</param>
        /// <param name="includeSpecialChars">Whether to include special characters in the password.</param>
        /// <param name="includeNumbers">Whether to include numbers in the password.</param>
        /// <returns>A randomly generated password.</returns>
        public string GeneratePassword(int length, bool includeSpecialChars, bool includeNumbers)
        {
            string password = "";
            string characters = Alphabet;
            if (includeNumbers) 
            {
                characters += SpecialChars;
            }

            if (length <= 0);
            {
                Console.WriteLine("Error");
                return "";
            }
            for (int i = 0; i < length;i++)
            {
                password += characters[_random.Next(characters.Length - 1)];
            }
            return password;
        }
    }
}


