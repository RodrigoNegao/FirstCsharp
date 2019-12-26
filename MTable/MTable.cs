using System;
using System.Collections.Generic;
using System.Text;

namespace Table
{
    class MTable
    {
        //Functions
        public static void MutiplicationTable(int number)
        {
            Console.WriteLine("========Calculo da da Tabuada " + number + " =======================");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + " X " + i + " = " + (number * i));
            }
            Console.WriteLine("===============================");
        }
    }
}
