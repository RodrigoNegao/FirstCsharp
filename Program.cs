using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste1");
            Console.WriteLine("Teste2");

            Console.WriteLine("");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Count {0} ", i);
            }

            Console.WriteLine("");
            // Get an array of the command line arguments
            string[] myArgs = Environment.GetCommandLineArgs();

            // Use the Join function to combine arguments with a comma
            Console.WriteLine(string.Join(", ", myArgs));

            Console.WriteLine("");
            var intVal = 1234;

            Console.WriteLine("intVal Type : {0}", intVal.GetType());
            // Arrays

            Console.WriteLine("");

            //SayHello();

            
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
    }
}
