using Base1;
using Customer1;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Interface
{
    public interface IPeople 
    {
        //public string Name { get; set; }
        //public string NPhone { get; set; }
        //public string CPF { get; set; }

        public List<Base> ReadPeople();
        public void SaveData();
        //public ReadPeople();
    }
}
