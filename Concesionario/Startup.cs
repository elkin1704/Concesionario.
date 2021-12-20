using Concesionario.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Concesionario
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            //Connection DataBase Server
            string BaseDatos = Configuration.GetSection("Parametros").GetSection("BaseDatos").Value;
            if (BaseDatos == "SqlServer")
            {
                string conn = Configuration.GetConnectionString("ConnDbServer");
                services.AddDbContext<DBConcesionario>(options => options.UseSqlServer(conn));
            }
            if (BaseDatos == "Postgres")
            {
                string connPost = Configuration.GetConnectionString("ConnDbServerPostgres");
                services.AddDbContext<DBConcesionario>(options => options.UseNpgsql(connPost));
            }
            if (BaseDatos == "Memory")
            {

                services.AddDbContext<DBConcesionario>(options => options.UseInMemoryDatabase(databaseName: "DBMemoria"));
            }
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
