# StudentManagement-EF-CodeFirst
Student Management System using EF Core Code-First with CRUD and migrations.

Overview
This is a console-based **Student Management System** built using **C#**, **.NET**, and **Entity Framework Core (Code-First approach)**.  
The project demonstrates how a database can be generated directly from C# classes using migrations and how CRUD operations are performed using EF Core.


Technologies Used
- C#
- .NET
- Entity Framework Core
- SQL Server Express
- Visual Studio
- LINQ


Features
- Automatic database & table creation using EF Core migrations


Project Structure
- `Student` – Entity model
- `StudentContext` – DbContext for EF Core
- `Program.cs` – Application entry point
- Migrations – Database versioning


How It Works (Code-First)
1. C# classes define the database structure
2. EF Core migrations generate SQL automatically
3. Database and tables are created in SQL Server
4. CRUD operations are performed using DbContext


How to Run
1. Clone the repository
2. Open the project in Visual Studio
3. Update the SQL Server connection string
4. Run migrations
5. Start the console application


Learning Outcomes
- Understanding Code-First approach
- Working with DbContext and migrations
- Performing CRUD using EF Core
- Connecting .NET applications to SQL Server

## ⚡ Fun Fact
This project creates the entire database without writing SQL manually 🚀
