using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace NoDerps
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Build().Run();
        }

        public static IWebHostBuilder BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            //Potentially useful things in other deployments...    
                //.UseKestrel()
                //.UseContentRoot(Directory.GetCurrentDirectory())
                
                // params string[] urls
                //Was previously specific: .UseUrls(urls: "https://10.142.0.3:5001");
                    //Set to use all on the port so that it will all get fed into the rev. proxy.
                    .UseUrls(urls: "http://127.0.0.1:5000")
                .UseStartup<Startup>();
                //.Build();
    }
}
