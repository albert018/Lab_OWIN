using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using System.Net.Http;

namespace Lab_OWIN
{
    class Program
    {
        static void Main(string[] args)
        {
            var option = new StartOptions();
            option.Urls.Add("http://localhost:80");
            //option.Urls.Add("http://192.168.18.137:80");
            using (WebApp.Start<Startup>(option))
            {
                //var client = new HttpClient();
                //var result = client.GetAsync(address + "api/Async").Result;
                //Console.WriteLine(result);
                
                Console.WriteLine("running");
                Console.ReadLine();
            }
        }
    }
}
