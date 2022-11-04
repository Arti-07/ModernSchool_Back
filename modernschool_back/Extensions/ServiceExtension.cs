using modernschool_back;
using modernschool_back.Interfaces;
namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceExtension
{
    public static IServiceCollection ServiceExtensionConfigure(this IServiceCollection services,
        WebApplicationBuilder builder)
    {
        
        builder.Services.AddTransient<IStudent, EFStudentRepository>();
        
        return services;
    }
}
