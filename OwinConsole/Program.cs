using System;
using System.IO;
using System.Web.Http;
using System.Windows.Forms;
using Microsoft.Owin;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.Hosting;
using Microsoft.Owin.StaticFiles;
using MVC4WebApi;
using Owin;

namespace OwinConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Program>("http://*:9000"))
            {
                Console.WriteLine("Press [enter] to quit...");
                Console.ReadLine();
            }
        }

        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            appBuilder.UseWebApi(config);
            var path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Content");
            Console.WriteLine("Using Content path: " + path);
            appBuilder.UseFileServer(new FileServerOptions
            {
                RequestPath = new PathString(string.Empty),
                FileSystem = new PhysicalFileSystem(path),
                EnableDirectoryBrowsing = false,
            });
        }
    }
}
