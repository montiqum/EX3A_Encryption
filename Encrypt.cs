using System;
using System.Security.Cryptography;

namespace EX3A_Encryption
{
    class Encrypt
    {
        static string pwdencrypt = "";
        public static string MD5(string input)
        {
            pwdencrypt = "";
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            for (int i = 0; i < hashBytes.Length; i++)
            {
                pwdencrypt += hashBytes[i].ToString();
                //Console.Write(hashBytes[i]);
            }
            return pwdencrypt;
        }
    }
}
