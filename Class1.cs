using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        public static int CalcularSoma()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c;
        }

        public int CalcularSoma2()
        {
            int a = 3;
            int b = 2;
            int c = a + b;
            return c;
        }

        public static void FileRead(int NumberFile)       //string fileName)
        {

            //string DirectoryFile = Path.Combine(Directory.GetCurrentDirectory() + fileName);
            string DirectoryFile = @"C:\Users\rodrigo negao\Desktop\PROJETOS\C#\ConsoleApp1\arg" + NumberFile + ".txt";

            if (File.Exists(DirectoryFile))
            {
                Console.WriteLine("Your file content is:");
                using (StreamReader arquivo = File.OpenText(DirectoryFile))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }

            }

            //recursive function
            string DirectoryFile2 = @"C:\Users\rodrigo negao\Desktop\PROJETOS\C#\ConsoleApp1\arg" + (NumberFile + 1) + ".txt";
            if (File.Exists(DirectoryFile2))
            {
                FileRead(NumberFile + 1);
            }
        }

    }
}
