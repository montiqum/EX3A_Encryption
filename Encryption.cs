using System;
using System.Security.Cryptography;

namespace EX3A_Encryption
{
    class Encryption
    {
        static string password = "";
        static string pwdencrypt = "";

        public static void MD5()
        {
            Console.WriteLine("Input your password:");
            password = Console.ReadLine();
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            for (int i = 0; i < hashBytes.Length; i++)
            {
                pwdencrypt += hashBytes[i].ToString();
                //Console.Write(hashBytes[i]);
            }
            Console.WriteLine($"\nThe password is: {password}");
            Console.WriteLine($"The encrypted result is: {pwdencrypt}");
        }
    }
}
