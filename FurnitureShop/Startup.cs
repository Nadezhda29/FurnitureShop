using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using FurnitureShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace FurnitureShop
{
    public class Startup
    {
        private IConfiguration Configuration;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddTransient<IFurnitureRepository, FurnitureRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                    Configuration["Data:FurnitureShop:ConnectionString"]));

            services.AddDbContext<AppIdentityDbContext>(options =>
                options.UseSqlServer(
                    Configuration["Data:FurnitureShopIdentity:ConnectionString"]));

            services.AddIdentity<IdentityUser, IdentityRole>()
               .AddEntityFrameworkStores<AppIdentityDbContext>()
               .AddDefaultTokenProviders();

            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddMemoryCache();
            services.AddSession();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseSession();

            app.UseAuthentication();


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: null,
                    template: "{category}",
                    defaults: new
                    {
                        controller = "Home",
                        action = "ListFurniture",
                    });

                routes.MapRoute(name: null, template: "{controller}/{action}/{id?}");
                routes.MapRoute(name: null, template: "{controller=Home}/{action=Index}/{id?}");
            });

            //IdentitySeedData.EnsurePopulated(app);

            //SeedData.Fill(app);
        }
    }
}
