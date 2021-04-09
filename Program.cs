using System;
using System.Security.Cryptography;

namespace EX3A_Encryption
{
    class Program
    {
        static int type = 0;
        public static void Authentication()
        {
            while(type < 1 || type > 3)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Create an account - 1");
                Console.WriteLine("Authenticate a username and password - 2");
                Console.WriteLine("Exit - 3");
                try
                {
                    type = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    type = 0;
                }
                if (type == 1)
                {
                    Create.CreateAcct();
                    Console.WriteLine();
                    type = 0;
                    
                }
                else if (type == 2)
                {
                    Authenticate.GetUnameAndPwd();
                    Console.WriteLine();
                    type = 0;
                }
                else if (type == 3)
                {
                    Printer.PrintList();
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Entry!\n");
                }
            }
        }

        static void Main(string[] args)
        {
            Encryption.MD5();
            Console.WriteLine();
            Authentication();
            
        }
    }
}
