using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDataProviderFactory
{
    public class ConnectDB
    {
        public ConnectDB() { }  
        public static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json", true, true)
                                        .Build();
            var strConnection = config["ConnectionString:MyStoreDB"];
            return strConnection;
        }
    }
}
