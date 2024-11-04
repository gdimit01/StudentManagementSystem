using Microsoft.Extensions.DependencyInjection;
using StudentManagementSystem.Repositories;
using StudentManagementSystem.Services;
using StudentManagementSystem.Data;
using StudentManagementSystem.Domain;  // Ensure this is here to resolve ITeacherRepository

namespace StudentManagementSystem.Infrastructure
{
    public static class DependencyInjection
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            // Register DatabaseConnection
            services.AddScoped<DatabaseConnection>();

            // Register repositories
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();

            // Register services
            services.AddScoped<TeacherService>();
            services.AddScoped<AuthService>();
        }
    }
}
