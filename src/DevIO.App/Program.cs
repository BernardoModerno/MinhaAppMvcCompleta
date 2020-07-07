using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace DevIO.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}

/*Comando Utilizados até agora
 * 
Update-Database -Verbose
Add-Migration TabelasSistema
ApplicationDbContext(AppMvcBasica.Data)
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.Relational
Add-Migration Initial -Verbose -Context MeuDbContext
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 2.2.0
Script-Migration -Context MeuDbContext
Update-Database -Context ApplicationDbContext
Update-Database -Context MeuDbContext
Install-Package automapper.extensions.microsoft.dependencyinjection
 
 */
