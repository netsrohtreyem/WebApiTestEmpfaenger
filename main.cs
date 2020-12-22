using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace WebApiTestEmpfaenger
{
    public class main
    {
        public static void Main(string[] args)
        {            
            IWebHostBuilder neu = WebHost.CreateDefaultBuilder(args);
            neu.UseStartup<startup>();
            neu.UseUrls("http://localhost:5000");
            neu.Build().Run();
        }
    }
}
