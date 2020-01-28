using Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Base1
{
    public class Base : IPeople   //,  IBase
    {
        public string Name;// { get; set; }
        public string NPhone; // { get; set; }
        public string CPF; //{ get; set; }

        
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="nome">Teste1</param>
        /// <param name="CPF">Teste2</param>
        /// <param name="Nphone">Teste3</param>
        public Base(string nome, string Nphone, string CPF)
        {
            //This can't equal a null or blanc
            this.Name = nome;
            this.NPhone = Nphone;
            this.CPF = CPF;
        }
        public Base() { }

        private string DirectoryMaster()
        {
            return ConfigurationManager.AppSettings["Directory1"] + this.GetType().Name + ".txt";
        }
        public virtual void SaveData() //
        {
            //TODO Mudar o save

            var SPeople = this.ReadPeople(); // Quando não é estatico precisa instanciar
            SPeople.Add(this);
            if (File.Exists(DirectoryMaster()))
            {
                StreamWriter r = new StreamWriter(DirectoryMaster());
                string Data = "nome;telefone;CPF;"; //n";
                r.WriteLine(Data);
                foreach (Base c in SPeople)
                {
                    var linha = c.Name + ";" + c.NPhone + ";" + c.CPF + ";"; // bug "\n" ---   Data += var linha = 
                    r.WriteLine(linha);
                }

                r.Close();
                //File.WriteAllText(DirectoryCustomer(), Data);
            }
        }

        public virtual List<Base> ReadPeople()
        {
            var dados = new List<Base>();

            if (File.Exists(DirectoryMaster()))
            {
                //Console.WriteLine("Your file content is:");
                using (StreamReader arquivo = File.OpenText(DirectoryMaster()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var DataCustomer = linha.Split(';');

                        //var b = (IPeople)Activator.CreateInstance(this.GetType());
                        //b.Name = DataCustomer[0];
                        //b.NPhone = DataCustomer[1];
                        //b.CPF = DataCustomer[2];

                        var b = new Base { Name = DataCustomer[0], NPhone = DataCustomer[1], CPF = DataCustomer[2] };

                        //var b = new Customer();// DataCustomer[0], DataCustomer[1], DataCustomer[2]); Dont Save #TODO how to save this method



                        dados.Add(b);
                        //Console.WriteLine(linha);
                    }
                }

            }

            return dados;
        }


    }
}
