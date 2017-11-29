using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;

namespace ConsoleWebService
{
    class Program
    {
        static void Main(string[] args)
        {
            MySimpleHost msh = (MySimpleHost)ApplicationHost.CreateApplicationHost(typeof(MySimpleHost), "/", Directory.GetCurrentDirectory());



            Console.WriteLine("Running...");
            Console.ReadKey();
        }
    }

    public class MySimpleHost : MarshalByRefObject
    {
        public void ProcessRequest(string file)
        {
        }
    }
}
