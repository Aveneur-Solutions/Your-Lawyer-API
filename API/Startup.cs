using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.LawyerService;
using FluentValidation.AspNetCore;
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
using Persistence.DataContext;

namespace API
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
            services.AddDbContext<YourLawyerContext>(opt =>
            {
                opt.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
            });
            
            services.AddControllers()
            .AddFluentValidation(cfg => {
                cfg.RegisterValidatorsFromAssemblyContaining<UploadLawyer>();
            });

            services.AddCors(opt =>
       {
           opt.AddPolicy("CorsPolicy", policy =>
           {
               policy.AllowAnyHeader().AllowAnyMethod().
               WithOrigins("http://localhost:3000");
           });
       });
            services.AddMediatR(typeof(LawyerList.Handler).Assembly);
            services.AddAutoMapper(typeof(LawyerList.Handler));
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
            app.UseCors("CorsPolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
