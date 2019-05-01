using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CapstoneClassLibrary
{
    public class SaltingHashing
    {
        public string passHash { get; set; }
        public string passSalt { get; set; }


        public static SaltingHashing CreateSaltHash(int size, string password)
        {
            var saltSize = new byte[size];
            var provider = new RNGCryptoServiceProvider();
            provider.GetNonZeroBytes(saltSize);
            var salt = Convert.ToBase64String(saltSize);

            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltSize, 10000);
            var rawHash = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));

            SaltingHashing hashSalt = new SaltingHashing { passHash = rawHash.ToString(), passSalt = salt.ToString() };
            return hashSalt;
        }

        public static bool AuthenticPass(string userPassword, string hash, string salt)
        {
            var saltBytes = Convert.FromBase64String(salt);
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(userPassword, saltBytes, 10000);
            return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256)) == hash;
        }
    }
}

