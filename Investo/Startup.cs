using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Investo.Domain.Repository;
using Investo.Domain.Services;
using Investo.Interface.Repository;
using Investo.Interface.Services;
using Investo.Models.ApplicationContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Investo
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
            services.AddRazorPages();
            services.AddDbContext<InvestorDBContext>(Options => Options.UseMySQL(Configuration.GetConnectionString("ApplicationContextConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<InvestorDBContext>();


            //this will use global authorization

            //services.AddMvc(options =>
            //{
            //    var policy = new AuthorizationPolicyBuilder()
            //    .RequireAuthenticatedUser().Build();
            //    options.Filters.Add(new AuthorizeFilter(policy));
            //}).AddXmlSerializerFormatters();



            //services.AddDefaultIdentity<IdentityUser>().
            //  AddEntityFrameworkStores<InvestorDBContext>();


            services.AddScoped<IInvestorRepository, InvestorRepository>();
            services.AddScoped<IInvestorService, InvestorService>();

            //services.AddScoped<IAdminRepository, AdminRepository>();
            //services.AddScoped<IAdminService, AdminService>();

            services.AddScoped<IManagerRepository, ManagerRepository>();
            services.AddScoped<IManagerService, ManagerService>();

            services.AddScoped<IInvestmentRepository, InvestmentRepository>();
            services.AddScoped<IInvestmentService, InvestmentService>();


            services.AddScoped<IAccountRepository, AccountRepository>();







            //UseMySQL
            //UseSQLServer

            //------//files to be downloaded and installed each time you setup a new project:-------:

            //"entity frame work core" inorder to use "DbContext" (from NuGET Packages)

            //"MYSQL.data"   and  "MYSQL entityframeWork" inorder to use "UseMySQL" (from NuGET Packages)

            //"UseSqlServer" to use this install from nuget packages "sql server"



            //"ENtityFrameWorkTools" "design" in order to migrate to your database (from NuGET Packages)

            //"ENtityFrameWorkTools" in order to migrate to your database (from command line prompt)


            //dotnet tool install --global dotnet-ef
            //dotnet add package Microsoft.EntityFrameworkCore.Design


            //after installation: run migration
            //(dotnet ef migrations add -p investo  -s investo thirdMigrate)

            //after migration run update
            // (dotnet ef database update -p investo -s investo secondproject)

            //dotnet add <PROJECT> package [options] <PACKAGE_NAME>



            //after migration run update
            //migration and update for identity

            //(dotnet ef migrations add -p investo  -s investo AddingIdentity)
            // (dotnet ef database update -p investo -s investo AddingIdentity)



            //after installation: run migration (dotnet ef migrations add -p BankManagwmwntSystemEFWeb  -s BankManagwmwntSystemEFWeb thirdwebinitial)

            //after migration run update        (dotnet ef database update -p BankManagwmwntSystemEFWeb -s BankManagwmwntSystemEFWeb thirdwebinitial)


            //--------------------------------  BankManagwmwntSystemEFWeb

            //files to be downloaded and installed each time you setup a new project

            //"entity frame work core" inorder to use "DbContext" (from NuGET Packages)

            //"MYSQL.data"   and  "MYSQL entityframeWork" inorder to use "UseMySQL" (from NuGET Packages)

            //"ENtityFrameWorkTools" in order to migrate to your database (from NuGET Packages)

            //"ENtityFrameWorkTools" in order to migrate to your database (from command line prompt)


            //dotnet tool install --global dotnet-ef
            //dotnet add package Microsoft.EntityFrameworkCore.Design

            //dotnet add <PROJECT> package [options] <PACKAGE_NAME>


            //after installation: run migration (dotnet ef migrations add -p scorebankefweb  -s scorebankefweb secondproject)

            //after migration run update(dotnet ef database update -p scorebankefweb -s scorebankefweb secondproject)

            //lastly install from nuget packages ("dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design")

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
