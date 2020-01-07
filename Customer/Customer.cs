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
    public class Customer
    {

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="nome">Teste1</param>
        /// <param name="CPF">Teste2</param>
        /// <param name="Nphone">Teste3</param>
        //public Customer(string nome, string Nphone, string CPF)
        //{
        //    //This can't equal a null or blanc
        //    //this.Name = _nome;
        //}

        public string Name;
        public string NPhone;
        public string CPF;

        public void SaveCustomer()
        {
            //TODO Implementar
            var SCustomer = Customer.ReadCustomer();
            SCustomer.Add(this);
            if (File.Exists(DirectoryCustomer()))
            {
                StreamWriter r = new StreamWriter(DirectoryCustomer());
                string Data = "nome;telefone;CPF;"; //n";
                r.WriteLine(Data);
                foreach (Customer c in SCustomer)
                {
                    var linha = c.Name + ";" + c.NPhone + ";" + c.CPF + ";"; // bug "\n" ---   Data += var linha = 
                    r.WriteLine(linha);
                }

                r.Close();
                //File.WriteAllText(DirectoryCustomer(), Data);
            }
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

                        var Customer2 = new Customer { Name = DataCustomer[0], NPhone = DataCustomer[1],CPF = DataCustomer[2]};

                        //var Customer2 = new Customer();// DataCustomer[0], DataCustomer[1], DataCustomer[2]); Dont Save #TODO how to save this method

                        //Customer2.Name = DataCustomer[0];
                        //Customer2.NPhone = DataCustomer[1];
                        //Customer2.CPF = DataCustomer[2];

                        customers1.Add(Customer2);
                        //Console.WriteLine(linha);
                    }
                }

            }

            return customers1;
        }
    }
}
