# Student Portal

This project demonstrates CRUD (Create, Read, Update, Delete) operations on a PostgreSQL database using ASP.NET Core MVC with .NET 8 and Entity Framework Core.

## Features

* **Create:** Add new students with name, email, phone number, and subscribed status.
* **Read:** View a list of all students with their ID, name, and email.
* **Update:** Edit existing student information.
* **Delete:** Remove students from the database.

## Technologies Used

* ASP.NET Core MVC
* .NET 8
* Entity Framework Core
* PostgreSQL
* Bootstrap

## Getting Started

### Clone the Repository

git clone https://github.com/VishalViswanathan03/StudentPortal.git

### Configure Connection String

Update `appsettings.json`:

"ConnectionStrings": {
"DefaultConnection": "Host=your_postgres_server_address;Port=5432;Database=your_database_name;Username=your_username;Password=your_password;"
}

### Database Migrations

dotnet ef migrations drop -c DataContext
dotnet ef migrations add InitialMigration -c DataContext

### Run the Application

dotnet run

Access the application at `https://localhost:5001/`

## Project Structure

* **Controllers:** Contains the StudentsController class
* **Models:** Contains the Student entity and AddStudentViewModel
* **Views:** Contains views for StudentsController actions
* **Data:** Contains the DataContext class