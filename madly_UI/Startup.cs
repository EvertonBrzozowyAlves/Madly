using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using madly_BLL;
using madly_DAL;
using madly_DAL.DataSettings;
using madly_models;
using Microsoft.EntityFrameworkCore;

namespace madly_UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            //=> Injeção de dependência configurada 
            services.AddScoped<MadlyContext>();
            
            services.AddScoped<UserBLL>(); 
            services.AddScoped<AnnotationBLL>(); 

            services.AddScoped<UserDAL>(); 
            services.AddScoped<AnnotationDAL>(); 

            // services.AddRazorPages();
            // services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, MadlyContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                context.Database.Migrate(); //Automatically generates the migrations
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Team}/{action=Index}/{id?}");
            });
        }
    }
}