using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApi_Livros.Domain.Repositories;
using WebApi_Livros.Domain.Service;
using WebApi_Livros.Persistence;
using WebApi_Livros.Persistence.Repositories;
using WebApi_Livros.Services;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        // Aqui você adiciona os serviços da sua aplicação
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseInMemoryDatabase("MyDBApiFluent");
        });

        services.AddControllers();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<ICategoryService, CategoryService>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        } 
        else
        {
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseMvc();

    }
}

