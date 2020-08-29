using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Portfolio.Core.Models;
using Portfolio.Business;
using Portfolio.Business.DataAccess;
using AutoMapper;
using Portfolio.Core.Mappings;
using Portfolio.Business.Models;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Options;
using MongoCrud;

namespace Portfolio.Core
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
           // services.Configure<AppSettings>(options => configuration.Bind(nameof(AppSettings), options));

            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
           
            //get database settting from 
            services.Configure<DatabaseSettings>(Configuration.GetSection(nameof(DatabaseSettings)));

            //add caching services
           

            //add database setting object to service
            services.AddSingleton<IDatabaseSettings>(s=>s.GetRequiredService<IOptions<DatabaseSettings>>().Value);
            //add business service to app serive and DI
            services.AddScoped<ISkillService, SkillService>();


            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new SkillMapping());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);


            services.AddAntiforgery(options =>
            {
                // Set Cookie properties using CookieBuilder properties†.
                options.FormFieldName = "AntiforgeryFieldname";
                options.HeaderName = "X-CSRF-TOKEN-HEADERNAME";
                options.SuppressXFrameOptionsHeader = false;
            });

            services.AddRazorPages();

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
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

           
           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
