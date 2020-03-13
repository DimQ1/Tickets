using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using TrainTickets.Api.Data;
using TrainTickets.Api.Data.Services;
using TrainTickets.Api.Infrastructure.Mapping;
using TrainTickets.Api.Services;

namespace TrainTickets.Api
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
            services.AddDbContext<TrainTicketDbContext>(opt =>
                opt.UseSqlite("Data Source = sqlitedemo.db"), ServiceLifetime.Singleton);

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "Train ticket API", Version = "v1"});
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
            });

            services.AddAutoMapper(x => x.AddProfile(new MappingProfile()), typeof(Startup));
            services.AddSingleton<TicketsService>();
            services.AddSingleton<Tikets>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseSwagger();

            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "Train API v1"); });

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthentication();
            // app.UseAuthorization();


            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}