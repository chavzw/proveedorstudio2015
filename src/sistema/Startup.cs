using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using sistema.Models;
using Microsoft.Extensions.Configuration; //extension de IconfigurationRoot
using Microsoft.EntityFrameworkCore; //extension para sql server

namespace sistema
{
    public class Startup
    {
        //propiedad para administrar la conexion de DBMS
        private IConfigurationRoot _configurationRoot;
        //agregacion del metodo constructor 

            public Startup(IHostingEnvironment hostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder()
                .SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();
        }//fin del contructor

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //registrar el AppDBContext para interactuar con la conexion al DBMS
            services.AddDbContext<AppDbContext>(options =>
           options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));

            //registrar mi clase repositoria y mock ya que todo es un servicio
            //actualizado por implementacion EFCore
            //services.AddTransient<IProveedorRepositorio, MockProveedorRepositorio>();
            services.AddTransient<IProveedorRepositorio, ProveedorRepositorio>();
            services.AddTransient<IEventoRepositorio, EventoRepositio>();

            //agrega soporte MVC a mi proyecto
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            app.UseDeveloperExceptionPage();
            DataInicio.AgregarData(app);
        }
    }
}
