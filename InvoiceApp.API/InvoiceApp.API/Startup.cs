
using InvoiceApp.API.Data;
using InvoiceApp.API.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace InvoiceApp.API
{
    public class Startup
    {
        string Cors = "any val";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>(o =>
                    o.UseSqlServer(Configuration.GetConnectionString("InvoiceAppConnectionString")));
            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddPolicy(Cors,
                builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });

            services.AddScoped<IUnitRepository, UnitRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IStoreRepository, StoreRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseCors(Cors);
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
