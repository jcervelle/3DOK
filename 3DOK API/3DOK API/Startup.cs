using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _3DOK_API.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;
using _3DOK_API.Services;

namespace _3DOK_API
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
            services.AddControllers();

            string MYSQL_HOST = "localhost";
            string MYSQL_PORT = "3306";
            string MYSQL_DBNAME = "3DOK";
            string MYSQL_USER = "root";
            string MYSQL_PWD = "";

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseMySQL($"server ={MYSQL_HOST} ; port = {MYSQL_PORT}; database ={MYSQL_DBNAME}; user = {MYSQL_USER}; password = {MYSQL_PWD}");
            });

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IGameService, GameService>();
            services.AddScoped<IGameTableService, GameTableService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
