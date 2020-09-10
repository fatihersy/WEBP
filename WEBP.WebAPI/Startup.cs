using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
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
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddTransient<IBlogDal, EfBlogDal>();
            services.AddTransient<ITagService, TagManager>();
            services.AddTransient<ITagDal, EfTagDal>();
            services.AddTransient<IAuthorService, AuthorManager>();
            services.AddTransient<IAuthorDal, EfAuthorDal>();
            services.AddTransient<IAuthorService, AuthorManager>();
            services.AddTransient<IBlogtagDal, EfBlogtagDal>();
            services.AddTransient<IBlogtagService, BlogtagManager>();
            services.AddTransient<ICategoryDal, EfCategoryDal>();
            services.AddTransient<ICategoryService, CategoryManager>();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
                    pattern: "{controller=Home}/{action=Index}"
                    );
            });
        }
    }
}
