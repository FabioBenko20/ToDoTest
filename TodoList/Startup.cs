using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TodoList.Controllers;
using TodoList.Helpers;
using TodoList.Helpers.Interfaces;
using TodoList.Interfaces;

namespace TodoList
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
            //services.AddCors();
            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Latest);

            //var appSection = Configuration.GetSection("AppSettings");
            //services.Configure<AppSettings>(appSection.);






            services.AddTransient<ILoginService, LoginService>();
            services.AddTransient<IUserHelper, UserHelper>();
            services.AddTransient<IJwtHelper, JwtHelper>();
            services.AddTransient<IConfigSettings, ConfigSettings>();
            services.AddTransient<IToDoHelper, ToDoHelper>();
            services.AddTransient<IToDoService, ToDoService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseMvc();
        }
    }
}
