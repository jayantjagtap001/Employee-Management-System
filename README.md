# Employee Management System

## Project Overview
The Employee Management System is a REST API built using ASP.NET Core with authentication implemented using JWT (JSON Web Token). 
This API allows users to manage employees and provides authentication for secure access.

## 🛠 Tech Stack
- **Backend:** ASP.NET Core Web API
- **Database:** SQL Server
- **Authentication:** JWT (JSON Web Token)
- **Documentation:** Swagger

## 🚀 Setup & Installation
- **1️⃣ Clone the Repository**
  - `git clone <repository-url>`
  - `cd Employee_Management_System`

- **2️⃣ Configure Database**
  Update `appsettings.json` with your SQL Server connection string:
  ```json
  "ConnectionStrings": {
    "DefaultString": "Server=DESKTOP-CBRLF96\\SQLEXPRESS;Database=EmployeeDB;Trusted_Connection=True;TrustServerCertificate=True"
  }
- **3️⃣ Apply Migrations & Update Database**
  - `dotnet ef migrations add InitialCreate`
  - `dotnet ef database update`
 
