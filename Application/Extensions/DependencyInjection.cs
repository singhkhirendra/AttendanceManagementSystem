using Application.Mappings;
using Application.Services.Implementations;
using Application.Services.Interfaces;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;

namespace Application.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // Register your application/business services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAttendanceService, AttendanceService>();
            services.AddScoped<IOrganizationService, OrganizationService>();
            services.AddScoped<IRoleService, RoleService>();

            // Register AutoMapper profiles from Application assembly
            // Replace this line:
            // services.AddAutoMapper(typeof(MappingProfile));
            // With the following line to fix CS1503:
            services.AddAutoMapper(configAction => configAction.AddProfile<MappingProfile>());

            // Register FluentValidation (if validators are in Application)
            services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);

            return services;
        }
    }
}
