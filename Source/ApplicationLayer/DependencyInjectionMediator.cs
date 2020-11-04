using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using MediatR;
using System.Reflection;

namespace ApplicationLayer
{
    public static class DependencyInjectionMediator
    {
        public static IServiceCollection AddMediator(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddMediatR(typeof(Startup).GetTypeInfo().Assembly);
            services.AddMediatR(Assembly.GetExecutingAssembly());
           
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(PerformanceBehaviour<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));

            return services;
        }
    }
}
