using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Persistencia;

namespace Frontend
{
    public class Startup
    {
        private const string connectionString = @"Data Source=tcp:equiporocket.database.windows.net,1433;Initial Catalog=RocketDB;Persist Security Info=False;User ID=admijessie;Password=Teamrocket1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            /*services.AddRazorPages(options =>
            {
                options.Conventions.AuthorizePage("/ListMigrante");
                //options.Conventions.AuthorizeFolder("/Private");
                //options.Conventions.AllowAnonymousToPage("/Private/PublicPage");
                options.Conventions.AllowAnonymousToPage("/Index");
                //options.Conventions.AllowAnonymousToFolder("/Private/PublicPages");
            });*/
            services.AddScoped<IRepositorioMigrante,RepositorioMigrante>();
            services.AddScoped<IRepositorioEntidad,RepositorioEntidad>();
            services.AddScoped<IRepositorioServicio,RepositorioServicio>();
            services.AddDbContext<AplicationContext>(options => options.UseSqlServer(connectionString));
            services.AddControllersWithViews();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
