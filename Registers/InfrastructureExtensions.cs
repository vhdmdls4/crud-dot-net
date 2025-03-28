using crud_dot_net.DatabaseContext;
using crud_dot_net.Repository;
using crud_dot_net.Repository.Impl;
using Microsoft.EntityFrameworkCore;

namespace crud_dot_net.Registers;

public static class InfrastructureExtensions
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services, 
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            options.EnableSensitiveDataLogging();
        });

        services.Scan(scan => scan
            .FromAssemblies(typeof(BookRepository).Assembly)
            .AddClasses(classes => classes
                .Where(t => t.Name.EndsWith("Repository") && 
                            !t.IsAbstract && 
                            t.IsClass))
            .AsImplementedInterfaces()
            .WithScopedLifetime());
        
        return services;
    }
    
    // public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
    // {
    //     // Migration
    //     using var scope = app.ApplicationServices.CreateScope();
    //     var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    //     dbContext.Database.Migrate();
    //
    //     return app;
    // }
}