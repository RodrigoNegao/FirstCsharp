using Customer1;
using Files;
using Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace Customer2
{
    class CustomerMenu
    {
        public const int VOLTA_MENU = 0;
        public const int CREATE_CUSTOMER = 1;        
        public const int CALL_LIST = 2;
        public static void CustomerMenu1()
        {
            while (true)
            {
                //Console.WriteLine("\n=============================================\n");
                string mensage = 
                    "Digite uma das opções abaixo: \n" +
                    "      00 - Voltar ao Menu; \n" +
                    "      01 - Cadastrar Cliente; \n" +                    
                    "      02 - Lista de Clientes.\n";
                Console.WriteLine(mensage);
                Console.WriteLine("\n=============================================\n");

                //Console.ReadLine();

                Console.WriteLine("Digite " + VOLTA_MENU + " para Voltar ao Menu.");
                int valor = int.Parse(Console.ReadLine());


                if (valor == VOLTA_MENU)
                {
                    break; //Menu1.MainMenu();
                }
                else if (valor == CREATE_CUSTOMER)
                {
                    Console.WriteLine("===== Opção Cadastrar Cliente ===================");
                    CreateCustomer(); //ReadFiles.FileRead(1);
                    Console.WriteLine("\n=============================================\n");
                }               
                else if (valor == CALL_LIST)
                {
                    //Console.WriteLine("======== Lista de Cliente ==================");
                    ListCustomer();
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



        public static void ListCustomer()
            {
                var Customer1 = Customer.ReadCustomer();
                Console.WriteLine("\n======Essa é a Lista de Clientes=========\n");
                foreach (Customer c in Customer1)
                {
                    Console.WriteLine(c.Name);
                    Console.WriteLine(c.NPhone);
                    Console.WriteLine(c.CPF);
                    Console.WriteLine("\n==================================\n");
                }

                Console.ReadLine();
            }

        public static void CreateCustomer()
        {
            var cliente = new Customer();// "vitinho","5398150500","010202001");
            Console.WriteLine("Nome do Cliente:");
            cliente.Name = Console.ReadLine();
            Console.WriteLine("Numero do Telefone:");
            cliente.NPhone = Console.ReadLine();
            Console.WriteLine("Numero do CPF:");
            cliente.CPF = Console.ReadLine();
            cliente.SaveCustomer();
            //if ()
            //{
            //    Console.WriteLine("Cadastro Salvo Com Sucesso;");
            //}                
        }


        //Customer = new Customer();
    }
}
