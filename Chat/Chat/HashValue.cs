using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Chat
{
    public static class Hashing
    {
        public static string Sha512Hash(string input)
        {
            using (SHA512 sha512 = SHA512.Create()) 
            { 
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hashValue = sha512.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashValue) 
                { 
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
