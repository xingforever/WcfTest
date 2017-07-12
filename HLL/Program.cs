using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HLL
{
    class Program
    {
        static void Main(string[] args)
        {

            using (ServiceHost host = new ServiceHost("bll.UserinfoService")) {
                host.Open();//开启服务

                Console.ReadKey();

            }
        }
    }
}
