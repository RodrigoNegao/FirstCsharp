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
            string DirectoryFile2 = @"C:\Users\rodrigo negao\Desktop\PROJETOS\C#\ConsoleApp1\arg" + (NumberFile + 1) + ".txt";
            if (File.Exists(DirectoryFile2))
            {
                FileRead(NumberFile + 1);
            }
        }

        public static  void CalcMediaAlunos()
        {
            Console.WriteLine("Digite o nome do Aluno");
            string name = Console.ReadLine();
            int qtdNotas = 3;
            Console.WriteLine("Digite as" + qtdNotas + "nostas do Aluno");
            List<int> notas = new List<int>();
            int totalNotas = 0;
            for (int i = 1; i <= qtdNotas; i++)
            {
                Console.WriteLine("Digite a nota numero " + i);
                int nota = int.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);
            }
            int media = totalNotas / notas.Count;
            Console.WriteLine("A média do Aluno " + name + " é " + media);
            Console.WriteLine("Suas notas são: \n");

            foreach ( int nota in notas)
            {
                Console.WriteLine("Nota: " + nota + "\n");
            }
        }

    }
}
