using Microsoft.Extensions.DependencyInjection;
using StudentManagementSystem.Repositories;
using StudentManagementSystem.Services;

namespace StudentManagementSystem.DependencyInjection;

public static class DepdendencyInjection
{
    public static void RegisterDependencies(this IServiceCollection services)
    {
        services.AddScoped<IStudentRepository, StudentRepository>();
        services.AddScoped<ITeacherRepository, TeacherRepository>();
        services.AddScoped<IStudentRepository, StudentRepository>();
        services.AddScoped<StudentService>(); // Register Student Service
        services.AddScoped<TeacherService>(); // Register TeacherService
        services.AddScoped<AuthService>(); // Register AuthService
    }
}