using System;
using System.IO;
using Microsoft.Extensions.Configuration;

//TODO :  Criar um appSettings.json 

namespace ConsoleApp1
{
    public class Configuration
    {

        public readonly IConfiguration _configuration;

        public Configuration(IConfiguration config)
        {
            _configuration = config;
        }

        public string J1Result { get; private set; }
        public string JsonResult() 
        { 
            string J1Result = _configuration.GetConnectionString("directory:fileDirectory");
            return J1Result;
        }

    }

}

// AppSetting { get; }
//        static ConfigurationManager()
//        {
//            var AppSetting = new ConfigurationBuilder()
//                    .SetBasePath(GetBasePath());//Directory.GetCurrentDirectory())
//                    .AddJsonFile("appSettings.json", false);
//                    .Build();
//        }