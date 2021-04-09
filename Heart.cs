using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3A_Encryption
{
    class Heart
    {
        public static void PrintHeart()
        {
            for (int i = 6 / 2; i <= 6; i += 2)
            {
                for (int j = 1; j < 6 - i; j += 2)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                for (int j = 1; j <= 6- i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            // Loop to print lower part
            for (int i = 6; i >= 1; i--)
            {
                for (int j = i; j < 6; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= (i * 2) - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
 
