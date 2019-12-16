using CrudPrefeitura.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CrudPrefeitura
{
    public class Startup
    {
        public IConfiguration configuration { get;  }

        public Startup(IConfiguration _configutarion)
        {
            configuration = _configutarion;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            var connection = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DatabaseContext>(options => options.UseMySql(connection));
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
