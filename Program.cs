﻿using System;
using System.Collections.Generic; // necessary to use Collection

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste1");
            //Console.WriteLine("Teste2");

            //For1();
            Console.WriteLine("");
            //Arg1();         
            //Class1
            //SayHello();
            //Console.WriteLine("[0]",Class1.SayHello1()); 
            
            //Array1();

            Collection1();

            Console.ReadLine();

        }

        // You can create your own functions (methods)
        private static void SayHello()
        {
            // Defines a variable that will store a string
            // of characters
            string name = "";

            Console.Write("What is your name : ");

            // Save the input the user provides
            name = Console.ReadLine();

            Console.WriteLine("Hello {0}", name);
        }

        private static void For1()
        {
            Console.WriteLine("");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Count {0} ", i);
                //Console.ReadLine();
                //bool Console.KeyAvailable{ get; };
                Console.WriteLine("Press Enter to Continues");
            }
        }

        private static void Arg1()
        {
            Console.WriteLine("");
            //Get an array of the command line arguments
            string[] myArgs = Environment.GetCommandLineArgs();

            //Use the Join function to combine arguments with a comma
            Console.WriteLine(string.Join(", ", myArgs));

            Console.WriteLine("");
        }

        private static void Array1()
        {
            //Array
            string[] List = new string[3];

            List[0] = "Bianca";
            List[1] = "Nando";
            List[2] = "Amanda";

            // Like OrderBy Alphabet
            Array.Sort(List);

            int size = List.Length;

            Console.WriteLine("Existe {0} contatos", size);

            // loop
            foreach (string Name in List)
            {
                Console.WriteLine(Name);
            }
        }

        private static void Collection1()
        {
            //Collection
            List<string> List1 = new List<string>();
            List1.Add("Roger");
            List1.Add("Andrezza");
            List1.Add("Bruninho");

            Console.WriteLine(List1[0]);

            Console.WriteLine("");

            //List1.;

            foreach (string Name1 in List1)
            {
                Console.WriteLine(Name1);
            }

            Console.WriteLine("");

            if (List1.Exists (e=> e == "Andrezza"))
            {
                Console.WriteLine("Andrezza existe no Collection");
            }
        }
    }
}
