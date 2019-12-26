using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Files
{
    class ReadFiles
    {
        public static void FileRead(int NumberFile)       //string fileName)
        {

            //string DirectoryFile = Path.Combine(Directory.GetCurrentDirectory() + fileName);
            string DirectoryFile = @"C:\Users\rodrigo negao\Desktop\PROJETOS\C#\ConsoleApp1\Files\arg" + NumberFile + ".txt";
            Console.WriteLine("===========Reading File============\n" +
                DirectoryFile + "\n=================================");

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
            string DirectoryFile2 = @"C:\Users\rodrigo negao\Desktop\PROJETOS\C#\ConsoleApp1\Files\arg" + (NumberFile + 1) + ".txt";
            if (File.Exists(DirectoryFile2))
            {
                FileRead(NumberFile + 1);
            }
        }
    }
}
