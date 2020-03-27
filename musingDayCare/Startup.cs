using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using musingDayCareComman.Interfaces;
using musingDayCareCore;
using musingDayCareCore.Common.AutoMapper;
using musingDayCareDataBase;
using Microsoft.OpenApi.Models;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace musingDayCare
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
            
            services.AddDataBase(Configuration);
            services.AddApplication();

            services.AddControllers();
            
            services.AddMvc().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<ProfileMapping>());
            services.AddCors();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("musing-daycare-api", new Microsoft.OpenApi.Models.OpenApiInfo()
                {
                    Title = "Musing Daycare Api",
                    Version = "1"
                }) ;
                var xmlFilePath = Path.Combine(AppContext.BaseDirectory, Assembly.GetExecutingAssembly().GetName().Name + ".xml");
                options.IncludeXmlComments(xmlFilePath);
            }
                );
            services.AddAuthentication(options =>
           {
               options.DefaultAuthenticateScheme = "JwtBearer";
               options.DefaultChallengeScheme = "JwtBearer";
               
           }).AddJwtBearer("JwtBearer", jwtoption =>
           {
               jwtoption.TokenValidationParameters = new TokenValidationParameters()
               {
                   ValidateIssuerSigningKey = true,
                   IssuerSigningKey = new SymmetricSecurityKey(
                       Encoding.UTF8.GetBytes("thisIsOnlyForTestingAndWillBeReplaced")),
                   ValidateIssuer = false,
                   ValidateAudience = false,
                   ValidateLifetime = true,
                   ClockSkew = TimeSpan.FromMinutes(3)
               };
           }
                );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)

        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint(@"/swagger/musing-daycare-api/swagger.json", "musing-daycare api");
                c.RoutePrefix = "";
            });
            
            app.UseRouting();
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            
            app.UseAuthentication();
            app.UseAuthorization();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
