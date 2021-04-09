using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3A_Encryption
{
    class Authenticate
    {
        static string username = "";
        static string incomingPwd= "";
        static bool isValid = false;
        static List<Tuple<string, string>> myList = new List<Tuple<string, string>>();

        public static void GetUnameAndPwd()
        {
            username = "";
            incomingPwd = "";
            Console.WriteLine("AUTHENTICATE");
            Console.WriteLine("------------\n");

            while (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(incomingPwd))
            {
                Console.WriteLine("Enter your username:");
                username = Console.ReadLine();
                Console.WriteLine("Enter your password:");
                incomingPwd = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(username))
                {
                    Console.WriteLine("Username invalid");
                }
                if(string.IsNullOrWhiteSpace(incomingPwd))
                {
                    Console.WriteLine("Password invalid");
                }
                else
                {
                    incomingPwd = Encrypt.MD5(incomingPwd);
                    myList = Create.myList;
                    if(myList.Count == 0)
                    {
                        Console.WriteLine("No Users. Create an account.");
                        break;
                    }
                    else
                    {
                        for (int i = 0; i < myList.Count; i++)
                        {
                            if (username == myList[i].Item1 && incomingPwd == myList[i].Item2)
                            {
                                Console.WriteLine("User Authenticated.\n");
                                Heart.PrintHeart();  //Print a heart because it's awesome!
                                isValid = true;
                                break;
                            }
                            else if (username == myList[i].Item1 && incomingPwd != myList[i].Item2)
                            {
                                Console.WriteLine("User Not Authenticated!");
                                isValid = true;
                                break;
                            }                      
                        }
                        if(!isValid)
                        {
                            Console.WriteLine("Username does not exist!");
                        }
                    }                    
                }
            }          
        }
    }
}
