using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3A_Encryption
{
    class Create
    {
        static string username = "";
        static bool isValid = false;
        static string pwd = "";
        public static List<Tuple<string, string>> myList = new List<Tuple<string, string>>();
        public static void CreateAcct()
        {
            Console.WriteLine("CREATE AN ACCOUNT");
            Console.WriteLine("-----------------\n");

            while (string.IsNullOrWhiteSpace(username) || !isValid)
            {
                Console.WriteLine("Enter a username: ");
                username = Console.ReadLine();

                if (myList.Count == 0 && !string.IsNullOrWhiteSpace(username))
                {
                    GetPwd();
                }
                else
                {
                    for (int i = 0; i < myList.Count; i++)
                    {
                        if (myList[i].Item1 == username)
                        {
                            Console.WriteLine("Username not available");
                            username = "";
                            isValid = false;
                            break; //break out for loop and ask for username again 
                        }
                        isValid = true;
                    }//username has not been found                    
                    if(isValid && !string.IsNullOrWhiteSpace(username))
                    {
                        GetPwd();
                    }                  
                }
            }
            username = "";
            pwd = "";
            isValid = false;
        }
        public static void GetPwd()
        {
            while(string.IsNullOrWhiteSpace(pwd))
            {
                pwd = "";
                Console.WriteLine("Enter a password: ");
                pwd = Console.ReadLine();
                if(!string.IsNullOrWhiteSpace(pwd))
                {
                    pwd = Encrypt.MD5(pwd); //Encrypt the password
                    myList.Add(Tuple.Create(username, pwd));
                    isValid = true;
                    Console.WriteLine("Saved!");
                }
                
            }
            
        }       
    }
}
