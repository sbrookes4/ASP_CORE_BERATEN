using BeratenHealthcareDataAccessLib;
using BeratenHealthcareDataInterfaceLib;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;

namespace Positivity
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.AccessDeniedPath = new PathString("/User/Login");
                options.LoginPath = new PathString("/User/Login");
                options.LogoutPath = "/User/LogOff";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = System.TimeSpan.FromMinutes(60);
            });

            services.AddAuthorization();
            services.AddMemoryCache();
            services.AddSession(configure: s => s.IdleTimeout = System.TimeSpan.FromMinutes(60));

            services.AddSingleton<IDbLogger, DbLogManager>();
            services.AddSingleton<ILookup, LookupManager>();

            services.AddTransient<IClient, ClientManager>();
            services.AddTransient<IIntake, IntakeManager>();
            services.AddTransient<ISecurity, SecurityManager>();
            services.AddTransient<ITreatmentPlan, TreatmentPlanManager>();
            services.AddTransient<IDashboard, DashboardManager>();
            services.AddTransient<IProgressNotes, ProgressNotesManager>();
            services.AddTransient<IAssessment, AssessmentManager>();

            services.AddMvc()
            .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());
            services.AddKendo();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else if (env.IsProduction())
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseSession();
            app.UseStaticFiles(new StaticFileOptions
            {
                OnPrepareResponse = ctx =>
                {
                    const int durationInSeconds = 60 * 60 * 1;
                    ctx.Context.Response.Headers[Microsoft.Net.Http.Headers.HeaderNames.CacheControl] =
                        "public,max-age=" + durationInSeconds;
                }
            });

            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}/{title?}");
            });
        }
    }
}