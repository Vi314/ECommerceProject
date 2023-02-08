using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetEcommerce.DAL.Context;
using NetECommerce.BLL.Abstract;
using NetECommerce.BLL.AbstractService;
using NetECommerce.BLL.Concrete;
using NetECommerce.BLL.Service;
using NetECommerce.Entity.Entity;
using System;

namespace NetECommerce.MVC
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

            //DbContext
            services.AddDbContext<ProjectContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //Service Services(someone get a better name please)
            services.AddTransient(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<ISupplierService, SupplierService>();

            //Identity
            services.
                AddIdentity<AppUser, AppUserRole>().
                AddEntityFrameworkStores<ProjectContext>();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 4;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            });

            //Cookies
            services.ConfigureApplicationCookie(cookie =>
            {
                cookie.Cookie.Name = "E-Commerce_LoginCookie";
                cookie.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Home/Login");
                cookie.AccessDeniedPath = new Microsoft.AspNetCore.Http.PathString("/Home/Login");
                cookie.SlidingExpiration = true;
                cookie.ExpireTimeSpan = TimeSpan.FromMinutes(15);
            });

            //Session
            services.AddSession(session =>
            {
                session.Cookie.Name = "product_cart";
                session.IdleTimeout = TimeSpan.FromMinutes(1);
            });
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
            app.UseSession();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {

                //Dashboard Route

                endpoints.MapControllerRoute(
                     name: "areas",
                       pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                    );

                //Default Route

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
