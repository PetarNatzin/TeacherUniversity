using Microsoft.EntityFrameworkCore;
using TeacherUniversity.Core.Contracts;
using TeacherUniversity.Core.Services;
using TeacherUniversity.Infrastructure.Data;
using TeacherUniversity.Infrastructure.Data.Repositories;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IApplicatioDbRepository, ApplicatioDbRepository>();
            services.AddScoped<ITeacherService, TeacherService>();

            return services;
        }

    }
}
