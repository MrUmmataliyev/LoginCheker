using LoginChecker.Application.Service.Check2;
using LoginChecker.Application.Service.Logins;
using LoginChecker.Application.Service.Registers;
using Microsoft.Extensions.DependencyInjection;


namespace LoginChecker.Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            services.AddScoped<ILogin, Login>();
            services.AddScoped<ICheck, Check>();
            services.AddScoped<IRegister, Register>();
            return services;
        }
    }
}
