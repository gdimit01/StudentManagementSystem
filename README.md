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
