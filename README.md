

---

# Order Management System

## Overview

This project is an **Order Management System** built using the **Northwind database**. It serves as a personal project to practice and expand my knowledge of software development technologies.

The system is designed with **Onion Architecture** principles to ensure flexibility, maintainability, and scalability. This architecture emphasizes a domain-centric approach, where the core business logic is independent of external dependencies.

## Features

- **Initial Focus:** Utilizing the Northwind database, the system provides functionality for managing orders, customers, suppliers, products, and categories.
- **Scalable Development:** As I learn new technologies, I will continue to enhance and update this project.
- **Open for Personal Use:** This project is intended for personal and non-commercial purposes only.

## Technologies Used

- **Architecture:**
  - **Onion Architecture:** A clean architecture pattern that promotes separation of concerns and dependency inversion.
- **Backend:**
  - **ASP.NET Core:** A cross-platform, high-performance framework for building modern, cloud-based, Internet-connected applications.
  - **Entity Framework Core:** An object-database mapper for .NET, enabling developers to work with a database using .NET objects.
- **Frontend:**
  - **Razor Pages:** A page-based programming model for building web UI in ASP.NET Core.
- **Database:**
  - **SQL Server:** Leveraging the Northwind database schema for managing relational data.
- **Development Tools:**
  - **Visual Studio:** An integrated development environment (IDE) from Microsoft.
  - **Git:** Version control for tracking changes in the source code.

## Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/cemserdar/OrderManagementSystem.git
   ```
2. **Navigate to the project directory:**
   ```bash
   cd OrderManagementSystem
   ```
3. **Configure the database connection:**
   - Ensure that SQL Server is installed and running on your machine.
   - Restore the Northwind database. You can download the Northwind database from Microsoft's official sources.
   - Update the connection string in the `appsettings.json` file to point to your SQL Server instance:
     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=Northwind;Trusted_Connection=True;"
     }
     ```
4. **Build and run the application:**
   - Open the solution in Visual Studio.
   - Restore the NuGet packages.
   - Build the solution to ensure all dependencies are resolved.
   - Run the application using IIS Express or your preferred web server.

## Usage

- **Accessing the Application:**
  - Once the application is running, navigate to `https://localhost:5001` in your web browser.
- **Managing Data:**
  - Use the navigation menu to access different sections such as Orders, Customers, Suppliers, Products, and Categories.
  - Perform CRUD (Create, Read, Update, Delete) operations as needed.

## Future Enhancements

- **Implementing a RESTful API:** To allow external applications to interact with the system.
- **Adding Modern Frontend Frameworks:** Such as React or Angular for a more dynamic user interface.
- **Implementing Authentication and Authorization:** To secure the application and manage user roles.
- **Exploring Deployment in Cloud Environments:** Such as Azure or AWS for scalability.

## Disclaimer

This project is for **personal use only** and is not intended for commercial purposes.

## Contact

If you have any questions or feedback, feel free to reach out:

- **Name:** Cem Serdar
- **Email:** [cemserdarakkocaoglu@hotmail.com](mailto:cemserdarakkocaoglu@hotmail.com)

--- 
