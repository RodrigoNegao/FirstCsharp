using Menu;
using System;
using System.Collections.Generic; // necessary to use Colle System.Configuration


//PascalCase
//camelCase
//underscore or Snake Case or (Under_line Brazlian most common)


namespace ConsoleApp1
{
    class Program
    {
        

        static void Main(string[] args)
        {

            // Execises 1 --------------------------------------------------
            //Console.WriteLine("Begin");
            //Console.WriteLine("Teste2");

            //For1();
            //Console.WriteLine("");
            //Arg1();         
            //SayHello();
            //Console.WriteLine("{0}"); 

            //Array1();

            //Collection1();

            //MutiplicationTable(2);

            //MutiplicationTable(3);

            //Console.WriteLine(Class1.CalcularSoma());

            //Cause don't use Static at Function    
            //var NewClass = new Class1();
            //var Total = NewClass.CalcularSoma2();
            //Console.WriteLine(Total);

            //Class1.FileRead(@"C:\Users\rodrigo negao\Desktop\PROJETOS\C#\ConsoleApp1\arg1.txt");

            //Class1.FileRead(1);

            //Exercises 2 OOP --------------------------------------------

            //var NewClass = new Configuration.JsonResult();
            //NewClass.JsonResult();

            Menu1.MainMenu();      

            //Console.ReadLine();

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
            List1.Add("Zeilane");

            Console.WriteLine(List1[0]);

            Console.WriteLine("");

            int Counter = List1.Count;

            Console.WriteLine("{0} Contatos", Counter);

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
