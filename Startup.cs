using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using ContactBookAPI.Models;

namespace ContactBookAPI
{
  public class Startup
  {
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
      // Configura o DbContext para usar o SQLite
      services.AddDbContext<ContactBookContext>(options =>
          options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
      services.AddSwaggerGen(c =>
                  {
                    c.SwaggerDoc("v1", new OpenApiInfo { Title = "ContactBookAPI", Version = "v1" });
                  });


      services.AddControllers();
      services.AddCors(options =>
    {
        options.AddPolicy("AllowLocalhost",
            builder =>
            {
                builder.WithOrigins("http://localhost:8080") // Permita apenas solicitações deste origin
                       .AllowAnyHeader()
                       .AllowAnyMethod();
            });
    });
}
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
        app.UseSwagger();
        app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "ContactBookAPI V1");
    c.RoutePrefix = string.Empty;
});
      }
      else
      {
        app.UseExceptionHandler("/error");
        app.UseHsts();
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
