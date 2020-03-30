using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Movie.Infrastructure.DataBase;
using Movie.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using Movie.Application.Infrastructure.Queries;
using Movie.Application.Infrastructure.Commands;

namespace Movie
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDependencyInjections();
            services.AddRazorPages();
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

            app.UseBuilderEndpoints();
        }
    }

    public static class StartupExtensions
    {
        public static void UseBuilderEndpoints(this IApplicationBuilder builder)
        {
            builder.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                     name: "default",
                     pattern: "{controller=Movie}/{action=Create}");
            });
        }

        public static void AddDependencyInjections(this IServiceCollection services)
        {
            services.AddScoped<CommandExecutor, CommandExecutor>();
            services.AddScoped<QueryExecutor, QueryExecutor>();
            services.AddDbContext<MovieDbContext>();
            services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
