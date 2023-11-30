using System.Security.Cryptography;
using System.Text;

namespace PasswordHashing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var password = Console.ReadLine();


            Random rand = new Random();
            int salt = rand.Next();
            var saltedPasswort = password + salt;
            Console.WriteLine(HashPassword(password));

            CreatePasswordHash(password, );
        }

        private static string HashPassword(string plainPassword)
        {
            using (var sha256Hash = SHA256.Create())
            {
                var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(plainPassword));

                var sb = new StringBuilder();
                foreach (var b in bytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private static void CreatePasswordHash(string plainPassword, out byte[] passwordHash, out byte[] saltHash)
        {
            using(var hmac = new HMACSHA256())
            {
                passwordHash = hmac.Key();
                saltHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(plainPassword));
            }

        }
    }
}