using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace rallyeLecture
{
    class HashPhp
    {
        
        public HashPhp()
        {
            
        }
        public static  string GetSha256FromString(string data)
        {
            var message = Encoding.ASCII.GetBytes(data);
            SHA256Managed hashString = new SHA256Managed();
            string hex = "";
            var hashValue = hashString.ComputeHash(message);
            foreach (byte x in hashValue)
                hex += String.Format("{0:x2}", x);
            return hex;
        }
        public static string GetHashPassword(string passWord)
        {

            var message = Encoding.ASCII.GetBytes(passWord);
            SHA256Managed hashString = new SHA256Managed();
            string hex = "";
            var hashValue = hashString.ComputeHash(message);
            foreach (byte x in hashValue)
            {
                hex += String.Format("{0:x2}", x);
            }
            return hex;

        }
        public static string Salt(string password, string salt)
        {
            // salage en md5 salt+password
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(salt);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                string passMD5 = sb.ToString();
                passMD5 = passMD5.ToLowerInvariant();
                string hashpassword = GetHashPassword(passMD5 + password);
                return hashpassword;
            }
        }

    }
}
