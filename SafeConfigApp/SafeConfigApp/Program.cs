using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeConfigApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = ConfigurationManager.AppSettings["password"];
            Console.WriteLine($"Password is '{password}'");

            Console.ReadKey();
        }
    }
}
