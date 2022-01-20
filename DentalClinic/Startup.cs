using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DentalClinic.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DentalClinic
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        private IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<DentalClinicContext>(option =>
                                 option.UseSqlServer(_config.GetConnectionString("DentalClinicConnection")));
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<DentalClinicContext>();

            services.AddMvc();

            //services.AddMvc(options =>
            //{
            //    var policy = new AuthorizationPolicyBuilder()
            //                   .RequireAuthenticatedUser()
            //                   .Build();
            //    options.Filters.Add(new AuthorizeFilter(policy));
            //}).AddXmlSerializerFormatters();
        }

        public static IWebHost BuildWebHost(string[] args) =>

        //For development
        //WebHost.CreateDefaultBuilder(args)
        //    .UseUrls("https://*:9000")
        //    .UseContentRoot(Directory.GetCurrentDirectory())
        //    .UseStartup<Startup>()
        //    .UseSetting("detailedErrors", "true")
        //    .CaptureStartupErrors(true)
        //    .Build();

        //For production
        WebHost.CreateDefaultBuilder(args)
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseIISIntegration()
            .UseStartup<Startup>()
            .Build();

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider services)
        {
            if (env.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
            }

            app.UseStaticFiles();
            app.UseAuthentication();
            //app.UseMvcWithDefaultRoute();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Account}/{action=Login}/{id?}");
            });

            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<DentalClinicContext>();
                context.Database.Migrate();

                if (context.Gender.Count() == 0)
                {
                    int[] id = { 1, 2, 3 };
                    string[] name = { "Male", "Female", "General" };

                    for (int i = 0; i < id.Length; i++)
                    {
                        Gender gender = new Gender
                        {
                            Id = id[i],
                            Name = name[i]
                        };
                        context.Gender.Add(gender);
                    }
                }

                if (context.FeeType.Count() == 0)
                {
                    FeeType feeType = new FeeType
                    {
                        FeeTypeId = 1,
                        Name = "Registration"
                    };
                    context.FeeType.Add(feeType);
                }

                if (context.FeeElement.Count() == 0)
                {
                    FeeElement feeElement = new FeeElement
                    {
                        FeeElementId = 1,
                        FeeTypeId = 1,
                        Name = "Registration Fee",
                        Fee=50
                    };
                    context.FeeElement.Add(feeElement);
                }

                if (context.TeethNumber.Count() == 0)
                {
                    int[] id = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14,
                        15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 };

                    int[] number = { 18, 17, 16, 15, 14, 13, 12, 11, 41, 42, 43, 44, 45, 46, 47,
                        48, 21, 22, 23, 24, 25, 26, 27, 28, 31, 32, 33, 34, 35, 36, 37, 38 };

                    string[] leftortight = { "Left", "Left", "Left", "Left", "Left", "Left", "Left", "Left",
                        "Left", "Left", "Left", "Left", "Left", "Left", "Left", "Left", "Right", "Right",
                        "Right", "Right", "Right", "Right", "Right", "Right", "Right", "Right", "Right",
                        "Right", "Right", "Right", "Right", "Right", };

                    string[] toporbuttom = { "Upper", "Upper", "Upper", "Upper", "Upper", "Upper", "Upper",
                        "Upper", "Lower", "Lower", "Lower", "Lower", "Lower", "Lower", "Lower", "Lower",
                        "Upper", "Upper", "Upper", "Upper", "Upper", "Upper", "Upper", "Upper", "Lower",
                        "Lower", "Lower", "Lower", "Lower", "Lower", "Lower", "Lower" };

                    string[] adultorchild = { "Adult", "Adult", "Adult", "Adult", "Adult", "Adult", "Adult",
                        "Adult", "Adult", "Adult", "Adult", "Adult", "Adult", "Adult", "Adult", "Adult",
                        "Adult", "Adult", "Adult", "Adult", "Adult", "Adult", "Adult", "Adult", "Adult",
                        "Adult", "Adult", "Adult", "Adult", "Adult", "Adult", "Adult" };

                    for (int i = 0; i < id.Length; i++)
                    {
                        TeethNumber teethNumber = new TeethNumber
                        {
                            TeethNumberId = id[i],
                            Number=number[i],
                            LeftOrRight=leftortight[i],
                            TopOrButtom=toporbuttom[i],
                            AduOrChd=adultorchild[i]
                        };
                        context.TeethNumber.Add(teethNumber);
                    }
                }

                context.SaveChanges();
            }                                

            CreateUserRoles(services).Wait();
        }

        private async Task CreateUserRoles(IServiceProvider serviceProvider)
        {           
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            IdentityResult roleResult;

            var roleCheck = await RoleManager.RoleExistsAsync("Admin");
            var userExist = UserManager.Users.Count();
                    
            if (!roleCheck)
            {
                if (userExist == 0)
                {                    
                    var admin = new IdentityUser
                    {
                        UserName = "Admin",
                        Email = "mirwaisdoost@hotmail.com"
                    };

                    var result1 = await UserManager.CreateAsync(admin, "Admin@123");
                    roleResult = await RoleManager.CreateAsync(new IdentityRole("Admin"));
                    IdentityUser user1 = await UserManager.FindByNameAsync("Admin");
                    var User1 = new IdentityUser();
                    await UserManager.AddToRoleAsync(user1, "Admin");

                    var hamedi = new IdentityUser
                    {
                        UserName = "drhamedi",
                        Email = "hamedi@somethings.com"
                    };

                    var result2 = await UserManager.CreateAsync(hamedi, "Hamedi@123");
                    roleResult = await RoleManager.CreateAsync(new IdentityRole("Admin"));
                    IdentityUser user2 = await UserManager.FindByNameAsync("drhamedi");
                    var User2 = new IdentityUser();
                    await UserManager.AddToRoleAsync(user2, "Admin");

                    var receiption = new IdentityUser
                    {
                        UserName = "Receiption",
                        Email = "receiption@somethings.com"
                    };

                    var result3 = await UserManager.CreateAsync(receiption, "Receiption@123");
                    roleResult = await RoleManager.CreateAsync(new IdentityRole("Admin"));
                    IdentityUser user3 = await UserManager.FindByNameAsync("Receiption");
                    var User3 = new IdentityUser();
                    await UserManager.AddToRoleAsync(user3, "Admin");

                }
            }         
        }
    }
}
