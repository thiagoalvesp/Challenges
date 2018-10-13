using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Cap_13
{
    public static class Password
    {
        public static string Hash(string password)
        {
            var passwordInBytes = Encoding.UTF8.GetBytes(password);
            HashAlgorithm sha512 = SHA512.Create();
            byte[] hashInBytes = sha512.ComputeHash(passwordInBytes);
            StringBuilder hash = new StringBuilder();
            Array.ForEach(hashInBytes, x =>
            {
                hash.Append(x);
            });
            return hash.ToString();
        }
    }
}
