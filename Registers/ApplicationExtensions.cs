using System.Reflection;
using crud_dot_net.Services;
using crud_dot_net.Services.Impl;
using FluentValidation;

namespace crud_dot_net.Registers;

public static class ApplicationExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.Scan(scan => scan
            .FromAssemblies(typeof(BookService).Assembly)
            .AddClasses(classes => classes
                .Where(t => t.Name.EndsWith("Service") && 
                            !t.IsAbstract && 
                            t.IsClass))
            .AsImplementedInterfaces()
            .WithScopedLifetime());
        
        services.AddAutoMapper(typeof(Program));

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        return services;
    }
}