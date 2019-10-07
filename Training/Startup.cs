using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Training.API.Contracts;
using Training.API.Operations;
using Training.Data;
using Training.Data.Repositories;

namespace Training
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
            //Conexion con sql server
            var connectionSQLServer = Configuration.GetConnectionString("sqlserver");

            //var connection = Configuration.GetConnectionString("sqlite");
            services.AddDbContext<StoreContext>
                (options => options.UseSqlServer(connectionSQLServer));

            ConfigureOperations(services);
            ConfigureRepositories(services);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }


        public void ConfigureOperations(IServiceCollection services)
        {
            services.AddTransient<GetUsers>();
            services.AddTransient<GetProducts>();
            services.AddTransient<GetOrders>();
            services.AddTransient<GetOrdersProducts>();
        }

        public void ConfigureRepositories(IServiceCollection services)
        {
            services.AddTransient<IUsersRepository, UsersRepository>();
            services.AddTransient<IOrdersRepository, OrdersRepository>();
            services.AddTransient<IProductsRepository, ProductsRepository>();
            services.AddTransient<IOrderProductRepository, OrdersProductsRepository>();


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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
