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
  
- **3️⃣ Apply Migrations & Update Databas**e

- **Add the initial migration**
  ```bash
  dotnet ef migrations
  add InitialCreate

- **4️⃣ Run the Application**
  ```bash
  dotnet run

## 📌 API Endpoints

-### 1️⃣ Authentication API

- **Method:** `POST`
- **Endpoint:** `/api/Auth/Login`
- **Description:** Generates JWT token

**Example Login Request:**
-```json
{
  "User Name": "Jayant",
  "Password": "Pass123"
}

-### 2️⃣ Employee API (Protected)

- **Method:** `GET`
  - **Endpoint:** `/api/employees`
  - **Description:** Fetch all employees

- **Method:** `GET`
  - **Endpoint:** `/api/employees/{id}`
  - **Description:** Fetch employee by ID

- **Method:** `POST`
  - **Endpoint:** `/api/employees`
  - **Description:** Create a new employee

- **Method:** `PUT`
  - **Endpoint:** `/api/employees/{id}`
  - **Description:** Update an employee

- **Method:** `DELETE`
  - **Endpoint:** `/api/employees/{id}`
  - **Description:** Delete an employee
