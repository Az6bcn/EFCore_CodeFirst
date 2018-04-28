using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BuisnessLayer;
using DataAccessLayer.Context;
using DataAccessLayer.IdentityCore;
using DataAccessLayer.Repository;
using DataAccessLayer.Repository.BaseRepository;
using DataAccessLayer.Repository.RepositoryAbstraction;
using DataAccessLayer.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Repository.Abstraction;

namespace EF_DTO_CODEFIRST
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
            // Add framework services
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<ICoursesRepository, CoursesRepository>();
            services.AddScoped<CoursesManager, CoursesManager>();

            services.AddAutoMapper(typeof(Startup));

            // Add EF Core For API
            services.AddDbContext<ApplicationDBContext>( 
                            options => options.UseSqlServer(Configuration.GetConnectionString("ConnectionString"),
                            // options2: to specify the library/assembly/project where Migrations are maintained and storedfor  my DBContext
                            options2 => options2.MigrationsAssembly("DataAccessLayer")));

            // Add EF Core For Identity passing it the IdentityDbContext
            services.AddDbContext<IdentityDbContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("ConnectionString"),
                    // options2: to specify the library/assembly/project where Migrations are maintained and storedfor  my DBContext
                    options2 => options2.MigrationsAssembly("DataAccessLayer")));


            // ASP.NET Identity
            services.AddIdentity<ApplicationUser, IdentityRole>() // tells Identity class to use for IdentityUser & IdentityRole
                .AddEntityFrameworkStores<IdentityDbContext>()              
                .AddDefaultTokenProviders();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //does all log levels
            logger.AddConsole(); 

            // add Identity core above into the pipeline
            app.UseAuthentication();

            app.UseMvc();
        }
    }
}
