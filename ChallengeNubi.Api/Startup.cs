using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ChallengeNubi.Core.BusinessComponents;
using ChallengeNubi.Core.Interfaces;
using ChallengeNubi.Infrastructure.Data;
using ChallengeNubi.Infrastructure.Filters;
using ChallengeNubi.Infrastructure.Repositories;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ChallengeNubi.Api
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

            // dependency Injection
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ICountryRepository, CountryRepository>();
            services.AddTransient<ICountryBussiness, CountryBussiness>();
            services.AddTransient<ISearchRepository, SearchRepository>();
            services.AddTransient<ISearchBussiness, SearchBussiness>();

            // database connection
            services.AddDbContext<ChallengeNubiContext>(option => option.UseSqlServer(Configuration.GetConnectionString("ChallengeNubi")));

            // ignore circular reference
            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });

            // configuracion del automapper
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // se registra el filtro de validacion de la carpeta Filters en Infrastructure
            services.AddMvc(options =>
            {
                options.Filters.Add<ValidationFilter>();
            })
            // se registran las validaciones de la carpeta Validators en Infrastructure
            .AddFluentValidation(options => {
                options.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
            });

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
