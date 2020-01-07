using System;
using Calc;
using Files;
using Table;
using System.Collections.Generic;
using System.Text;
using Customer2;

namespace Menu
{
    class Menu1
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULAR_MEDIA = 3;
        public const int CALL_MENUC = 4;
        public static void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("\n=============================================\n");
                string mensage = "Eae , Usuário, blz ?\n" +
                    "\n Ultilizando programção funcional \n" +
                    "\n\n" +
                    "Digite uma das opções abaixo: \n" +
                    "      00 - Sair do programa abaixo; \n" +
                    "      01 - Ler Arquivos; \n" +
                    "      02 - Executar a Tabuada; \n" +
                    "      03 - Executar a média.\n"  +
                    "      04 - Executar a Menu Clientes.\n";
                Console.WriteLine(mensage);
                Console.WriteLine("\n=============================================\n");

                //Console.ReadLine();

                Console.WriteLine("Digite " + SAIDA_PROGRAMA + " para sair do Programa.");
                int valor = int.Parse(Console.ReadLine());



                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("======== Opção Ler Arquivos ====================");
                    ReadFiles.FileRead(1);
                    Console.WriteLine("\n=============================================\n");
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("======== Opção Tabuada =======================");
                    Console.WriteLine("Digite o numero desejado para Calcular:");
                    int number = int.Parse(Console.ReadLine());
                    MTable.MutiplicationTable(number);
                    Console.WriteLine("\n=============================================\n");
                }
                else if (valor == CALCULAR_MEDIA)
                {
                    Console.WriteLine("======== Opção Calcular a Média ===============");
                    MedianCalc.CalcMediaAlunos();
                    Console.WriteLine("\n=============================================\n");
                }
                else if (valor == CALL_MENUC)
                {
                    Console.WriteLine("======== Opção Menu Cliente ==================");
                    CustomerMenu.CustomerMenu1() ;
                    Console.WriteLine("\n=============================================\n");
                }                
                else
                {
                    Console.WriteLine("\n=============================================\n");
                    Console.WriteLine("********* Opção Invalida digite Novamente ***********");
                    Console.WriteLine("\n=============================================\n");
                }
            }

        }
    }
}
