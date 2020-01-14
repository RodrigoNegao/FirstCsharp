using Customer1;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace User1
{
    public class User : Customer
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="Nphone"></param>
        /// <param name="CPF"></param>
        public User(string nome, string Nphone, string CPF)
        {
            //This can't equal a null or blanc
            this.Name = nome;
            this.NPhone = Nphone;
            this.CPF = CPF;
        }
        public User()
        {

        }
        public static string Directory()
        {
            return ConfigurationManager.AppSettings["User1"];
        }

        public override void SaveData() // override Customer.SaveData()
        {
            var user1 = User.ReadUser();
            User u = new User(this.Name, this.NPhone, this.CPF);
            user1.Add(u);

            if (File.Exists(Directory()))
            {
                StreamWriter r = new StreamWriter(Directory());
                string Data = "nome;telefone;CPF;"; //n";
                r.WriteLine(Data);
                foreach (User c in user1)
                {
                    var linha = c.Name + ";" + c.NPhone + ";" + c.CPF + ";"; // bug "\n" ---   Data += var linha = 
                    r.WriteLine(linha);
                }

                r.Close();
                //File.WriteAllText(DirectoryCustomer(), Data);
            }
        }

        public static List<User> ReadUser()
        {
            var Users1 = new List<User>();
               //Console.WriteLine("Your file content is:");
                using (StreamReader arquivo = File.OpenText(Directory()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var DataCustomer = linha.Split(';');

                        //var Users2 = new Customer { Name = DataCustomer[0], NPhone = DataCustomer[1], CPF = DataCustomer[2] };

                        var Users2 = new User(DataCustomer[0], DataCustomer[1], DataCustomer[2]); //Dont Save #TODO how to save this method

                        //Customer2.Name = DataCustomer[0];
                        //Customer2.NPhone = DataCustomer[1];
                        //Customer2.CPF = DataCustomer[2];

                        Users1.Add(Users2);
                        //Console.WriteLine(linha);
                    }
                }            

            return Users1;
        }

    }
}
