using System;
using System.Collections.Generic;
using System.Configuration; // You need install Packages 
using System.IO;
using System.Text;

// System.Configuration.ConfigurationManager
//1º Right click at dependencies;
//2º Manage Nugat;
//3º Search System.Configuration.ConfigurationManager
//4º you need Create app.config , so, Create NewItem and SEARCH "config";


namespace Customer1
{
    class Customer
    {
        public string Name;
        public string NPhone;
        public string CPF;

        public static string DirectoryFile { get; private set; }

        public void SaveCustomer()
        {
            //TODO Implementar
        }

        public static string DirectoryCustomer()
        {
            return ConfigurationManager.AppSettings["Customer1"];
        }
        public static List<Customer> ReadCustomer()
        {
            var customers1 = new List<Customer>();

            if (File.Exists(DirectoryCustomer()))
            {
                //Console.WriteLine("Your file content is:");
                using (StreamReader arquivo = File.OpenText(DirectoryCustomer()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var DataCustomer = linha.Split(';');
                        var Customer = new Customer();
                        Customer.Name = DataCustomer[0];
                        Customer.NPhone = DataCustomer[1];
                        Customer.CPF = DataCustomer[2];

                        customers1.Add(Customer);
                        //Console.WriteLine(linha);
                    }
                }

            }

            return customers1;
        }
    }
}
