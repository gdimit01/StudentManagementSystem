# Student Management System API

## Overview

The **Student Management System API** is a RESTful API designed for managing various aspects of a student management system, including students, teachers, courses, and departments. The API supports CRUD operations and uses Dapper as an ORM to interact with a SQL database. It also includes authentication and authorization using JWT tokens.

### Table of Contents

- [Features](#features)
- [Technologies Used](#technologies-used)
- [Project Structure](#project-structure)
- [Setup and Installation](#setup-and-installation)
- [Environment Configuration](#environment-configuration)
- [API Documentation](#api-documentation)
- [Testing](#testing)
- [Development Guidelines](#development-guidelines)
- [Contributing](#contributing)

## Features

- **Authentication and Authorization**: Secure login and registration using JWT tokens.
- **CRUD Operations**:
  - Manage students, teachers, courses, and departments.
  - Enroll students in courses.
- **Swagger Integration**: API documentation with interactive testing using Swagger.
- **Dapper for Data Access**: Efficient database interactions with minimal overhead.
- **Environment-based Configuration**: Separate configurations for development and production.

## Technologies Used

- **.NET 8.0**: The latest version of the .NET framework for building the API.
- **ASP.NET Core**: A powerful framework for building web APIs.
- **Dapper**: A lightweight ORM for database operations.
- **Swashbuckle**: For Swagger API documentation.
- **JWT**: For secure authentication and authorization.
- **SQL Server**: For data storage and management.

## Project Structure

```plaintext
StudentManagementSystem/
├── Controllers/        # API Controllers
│   ├── AuthController.cs
│   ├── TeachersController.cs
│   └── StudentsController.cs
├── DTOs/               # Data Transfer Objects
├── Models/             # Domain models
│   ├── Student.cs
│   ├── Teacher.cs
│   ├── Course.cs
│   └── Department.cs
├── Repositories/       # Data access repositories
│   ├── IStudentRepository.cs
│   ├── StudentRepository.cs
│   ├── ITeacherRepository.cs
│   └── TeacherRepository.cs
├── Services/           # Business logic and services
│   ├── AuthService.cs
│   └── TeacherService.cs
├── Data/               # Database connection and seeding
│   ├── DatabaseConnection.cs
│   └── DatabaseSeeder.cs
├── Program.cs          # Application entry point and middleware setup
├── appsettings.json    # Configuration file for environment settings
└── README.md           # Project documentation
```
## Setup and Installation
Prerequisites
Ensure you have the following installed:

.NET SDK 8.0
SQL Server (local or remote instance)
Visual Studio or another code editor (e.g., Visual Studio Code)

## Installation Steps
Clone the repository:

git clone https://github.com/yourusername/StudentManagementSystem.git
cd StudentManagementSystem

Restore the project dependencies:
dotnet restore

Update the database connection string in appsettings.json:

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=your_server;Database=StudentDB;User Id=your_user;Password=your_password;"
  }
}

Run database migrations and seed the database if needed:
dotnet ef database update

Run the application:
dotnet run

The API will be available at https://localhost:5001.

## Environment Configuration
This project supports environment-based configurations. The configuration files are:

appsettings.Development.json: For development environment settings.
appsettings.Production.json: For production settings.

Ensure the correct environment is set when running the application:
dotnet run --environment Development

API Documentation
Swagger is used for API documentation and is accessible at:

https://localhost:5001/swagger or whatever localhost it shows up when you dotnet run the project
Here, you can explore all the endpoints, view request and response formats, and test the API interactively.

Testing
Unit Tests

The project uses xUnit for unit testing services and repositories. Run tests using the following command:
dotnet test

Integration Tests
Integration tests are implemented using an in-memory database to simulate real-world scenarios. Ensure the environment is set to testing before running integration tests.

## Development Guidelines

Code Style
Follow .NET and C# coding conventions.
Ensure all new features have corresponding unit and integration tests.
Use dependency injection to manage services and repositories.

## Common Questions to Ask During Development
Controller Implementation:

Is the controller following RESTful conventions?
Are status codes correctly returned for each response?

Service Layer:
Is the service layer decoupled from the controller?
Are business rules and logic handled here instead of the controller?

Repository Layer:
Are queries optimized for performance?
Does the repository handle edge cases (e.g., null results)?

Security:
Are endpoints properly secured with JWT authorization?
Are sensitive data fields being logged or exposed?

Contributing
We welcome contributions from the community! Please follow the steps below to contribute:

## Fork the repository.
Create a new branch for your feature or bug fix.
Commit your changes and push to your fork.
Create a pull request with a detailed explanation of your changes.
Coding Standards
Follow SOLID principles when developing new features.
Ensure that each pull request includes tests that cover the new or modified functionality.
Document any new APIs or changes in the README.md or API documentation.

License
This project is licensed under MIT License.

Support
For any questions or support, please contact our support team or create an issue in the GitHub repository.

Thank you for contributing the Student Management System! 🎉
