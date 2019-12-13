using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste1");
            //Console.WriteLine("Teste2");

            //For1();
            //Console.WriteLine("");
            //Arg1();         
            //Class1
            //SayHello();
            //Console.WriteLine("[0]",Class1.SayHello1()); 

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
                bool Console.KeyAvailable{ get; };
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
    }
}
