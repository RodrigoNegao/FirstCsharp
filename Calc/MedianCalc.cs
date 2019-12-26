using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    class MedianCalc
    {
        public static void CalcMediaAlunos()
        {
            Console.WriteLine("Digite o nome do Aluno");
            string name = Console.ReadLine();
            int qtdNotas = 3;
            Console.WriteLine("Digite as " + qtdNotas + " notas do Aluno");
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

            foreach (int nota in notas)
            {
                Console.WriteLine("Nota: " + nota + "\n");
            }
        }
    }
}
