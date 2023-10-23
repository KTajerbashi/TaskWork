using Domain.Model;
using System;
using System.Security.Cryptography;
namespace BusinessLogic.Library.Extentions
{
    public class HashSalt
    {
        public string Hash { get; set; }
        public string Salt { get; set; }
    }

    public static class CryptoPassword
    {
        public static HashSalt GeneratePassword(string password)
        {
            return GenerateSaltedHash(64, password);
        }
        private static HashSalt GenerateSaltedHash(int size, string password)
        {
            var saltBytes = new byte[size];
            var provider = new RNGCryptoServiceProvider();
            provider.GetNonZeroBytes(saltBytes);
            var salt = Convert.ToBase64String(saltBytes);

            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, 10000);
            var hashPassword = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));

            HashSalt hashSalt = new HashSalt { Hash = hashPassword, Salt = salt };
            return hashSalt;
        }
        public static bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt)
        {
            var saltBytes = Convert.FromBase64String(storedSalt);
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(enteredPassword, saltBytes, 10000);
            return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256)) == storedHash;
        }
        
    }
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        public static bool VerifyPassword(string passwod, string currenthash)
        {
            return BCrypt.Net.BCrypt.Verify(passwod, currenthash);

        }
    }
}
