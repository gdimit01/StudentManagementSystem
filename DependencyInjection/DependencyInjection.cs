using Microsoft.Extensions.DependencyInjection;
using StudentManagementSystem.Repositories;
using StudentManagementSystem.Services;

namespace StudentManagementSystem.DependencyInjection;

public static class DependencyInjection
{
    public static void RegisterDependencies(this IServiceCollection services)
    {
        services.AddScoped<IStudentRepository, StudentRepository>();
        services.AddScoped<ITeacherRepository, TeacherRepository>();
        services.AddScoped<TeacherService>(); // Register TeacherService
        services.AddScoped<StudentService>();
        services.AddScoped<AuthService>(); // Register AuthService
    }
}