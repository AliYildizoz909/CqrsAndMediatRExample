using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using Example.Business.Application.Commands.ProductCommands;
using Example.Business.Application.Mapper;
using Example.Business.Application.Queries.ProductQueries;
using Example.Business.Command.CommandHandler;
using Example.Business.IoC.AutoFac;
using Example.DataAccess.Database;
using Example.DataAccess.EntityRepositories.Product;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Example.Api
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

            services.AddMediatR(typeof(ICommandHandler<,>).GetTypeInfo().Assembly);

            services.AddAutoMapper(expression => expression.AddProfile(new AutoMapperProfiles()));

            services.AddEntityFrameworkNpgsql().AddDbContext<ProductContext>(builder =>
                builder.UseNpgsql(Configuration.GetConnectionString("TestDb")), ServiceLifetime.Singleton);


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
