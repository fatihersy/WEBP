using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WEBP.BLL.Abstract;
using WEBP.BLL.Concrete;
using WEBP.DAL.Concrete.EntityFramework;
using WEBP.DAL.Interfaces;

namespace WEBP.WebAPI
{
    public class Startup
    {
        
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddTransient<IProductDal, EfProductDal>();
            services.AddTransient<ILoginDal, EfLoginDal>();
            services.AddTransient<ILoginService, LoginManager>();
            services.AddTransient<IUserDal, EfUserDal>();
            services.AddTransient<IMembershipsDal, EfMembershipsDal>();
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
                    pattern: "{controller=home}/{action=Index}/{page?}"
                    );
                endpoints.MapControllerRoute(
                    name: "secondary",
                    pattern: "{controller=home}/{action}"
                );
                endpoints.MapControllerRoute(
                    name: "secondary",
                    pattern: "{controller}/{action=Index}/{page?}"
                    );
                endpoints.MapControllerRoute(
                    name: "product",
                    pattern: "{controller=product}/{action=Index}/{id}"
                    );
                endpoints.MapControllerRoute(
                    name: "panel",
                    pattern: "{controller=admin}/{action}/"
                    );
            });
        }
    }
}
