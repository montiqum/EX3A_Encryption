using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3A_Encryption
{
    class Printer
    {
        static List<Tuple<string, string>> myList = new List<Tuple<string, string>>();
      
        public static void PrintList()
        {
            myList = Create.myList;

            Console.WriteLine($"|     USERNAME       |          PASSWORD HASH                      | ");
            for (int i = 0; i < myList.Count; i++) //formating
            {
                int n = 8 - myList[i].Item1.Length;
                string temp = myList[i].Item1;
                for (int j = 0; j < n; j++)
                {
                    temp += " ";
                }                
                Console.WriteLine($"| {temp}          | {myList[i].Item2} | ");
            }
        }
    }
}
