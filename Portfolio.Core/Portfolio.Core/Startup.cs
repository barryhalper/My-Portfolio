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
using Microsoft.Extensions.FileProviders;
using System.IO;
using Portfolio.Core.Utils;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.FileProviders.Embedded;
using Portfolio.Core.Models.Appsettings;

namespace Portfolio.Core
{
    public class Startup
    {
       // private string applicationRoot;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           
            //get config sections
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
           
            //get database settting fro config
            services.Configure<DatabaseSettings>(Configuration.GetSection(nameof(DatabaseSettings)));

            services.Configure<BlogSettings>(Configuration.GetSection("BlogSettings"));

            //add caching services


            //add database setting object to service
            services.AddSingleton<IDatabaseSettings>(s=>s.GetRequiredService<IOptions<DatabaseSettings>>().Value);

            services.AddSingleton<IConfiguration>(Configuration);
            //add business service to app serive and DI
            services.AddScoped<ISkillService, SkillService>();

            services.AddScoped<ITestimonialService, TestimonialService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<IRssService, RssService>();
            services.AddScoped<ICourseService, CourseService>();
            //render service used to call view for email
            //render service used to call view for email
            services.AddTransient<IRenderViewService, RenderViewService>();

            // Add the embedded file provider
           


            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new SkillMapping());
                mc.AddProfile(new ProjectMapping());
                mc.AddProfile(new TestimonialMapping());
                mc.AddProfile(new ContactMapping());
                mc.AddProfile(new AboutMapping());
                mc.AddProfile(new ArticleMapping());
                mc.AddProfile(new CourseMapping());
            });


            //preload AutoMapper and DI to controllers
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            //inject http context
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            // read email settinsg to 
            services.AddSingleton<IEmailConfiguration>(Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>());
            //enable anti forgery tokens to ensure secutity of requests
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
                //set up error pages in live
                app.UseStatusCodePagesWithReExecute("/error/404");
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
