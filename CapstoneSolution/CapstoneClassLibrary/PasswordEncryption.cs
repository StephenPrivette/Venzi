using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneClassLibrary
{
    // Class for proctecting user passwords - ATW
    // Not final version, just testing it out.
    class PasswordEncryption
    {
        public static string encryptPassword(string userPassword)
        {
            byte[] passwordSalt;
            new RNGCryptoServiceProvider().GetBytes(passwordSalt = new byte[16]);
            var hashValue = new Rfc2898DeriveBytes(userPassword, passwordSalt, 1000);
            byte[] passwordHash = hashValue.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(passwordSalt, 0, hashBytes, 0, 16);
            Array.Copy(passwordHash, 0, hashBytes, 16, 20);
            string encryptedPassword = hashBytes.ToString();;
            return encryptedPassword;
        }

        public static string decryptPassword(string password)
        {
            byte[] hashBytes = Convert.FromBase64String(password);
            byte[] passwordSalt = new byte[16];
            Array.Copy(hashBytes, 0, passwordSalt, 0, 16);
            var hashValue = new Rfc2898DeriveBytes(password, passwordSalt, 1000);
            byte[] passwordHash = hashValue.GetBytes(20);
            return passwordHash.ToString();
        }
    }
}
