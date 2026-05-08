# Zak International Airport Management System

A C# Windows Forms application designed to manage airport operations, including flights, staff, and customer services. This project uses a custom GUI and integrates with a database for data persistence.

## Features
* **Authentication:** Secure login forms for both Staff and Customers.
* **Flight Management:** Tools to view existing flights and create new flight entries.
* **Route Tracking:** Dedicated module for managing airport routes.
* **Customer Services:** Dashboard for passenger management and new card registration.
* **Staff Portal:** Internal system for airport personnel to manage daily operations.
* **UI Enhancements:** Includes custom "Toast" notifications for a better user experience.

## Technologies Used
* C# (.NET Framework)
* Windows Forms (WinForms)
* MySQL / SQL Server (Database)
* Visual Studio

## Project Structure
* `LOGIN FORM.cs` - Main entry point for user access.
* `STAFF FORM.cs` & `STAFF.cs` - Management interface for employees.
* `FLIGHTS.cs` & `NEW FLIGHT.cs` - Flight schedule and creation logic.
* `ROUTES.cs` - Handling of flight paths and destinations.
* `MAIN CUSTOMER.cs` & `CUSTOMER PAGE.cs` - The passenger-facing interface.
* `Toast.cs` - Custom notification logic.

## Setup
1. Open `Zak International Airport.sln` in Visual Studio.
2. Configure your database connection string in `App.config`.
3. Restore any missing NuGet packages via the Package Manager.
4. Build and Run the project.