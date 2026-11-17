

# Petra Wheels – Car Rental System

A console-based Car Rental Management System developed using C# and .NET as part of a C# programming assignment.

## Overview

Petra Wheels is a simple vehicle rental management application that allows users to manage cars and motorcycles, process rental and return operations, and generate basic vehicle status reports.

The application demonstrates fundamental Object-Oriented Programming (OOP) concepts and basic input validation in C#.

## Features

- **User Authentication**
  - Fixed administrator credentials.
  - Maximum of three login attempts.
  - Program exits after three unsuccessful attempts.

- **Vehicle Management**
  - Add cars and motorcycles.
  - Assign unique IDs automatically.
  - Prevent duplicate vehicle license plates.
  - Validate daily rental rates and vehicle information.
  - Display all registered vehicles.

- **Rental Management**
  - Rent available vehicles.
  - Prevent renting vehicles that are already rented.
  - Validate customer age (18 or older).
  - Validate rental duration.
  - Calculate rental costs automatically.
  - Apply a 10% discount for rentals of seven days or more.

- **Vehicle Returns**
  - Return rented vehicles using their license plate.
  - Update vehicle availability status.
  - Prevent returning vehicles that are not currently rented.

- **Reports**
  - Display the total number of vehicles.
  - Show available and rented vehicle counts.
  - Display vehicle details and current statuses.

## Technologies Used

- C#
- .NET 10
- Visual Studio
- Object-Oriented Programming (OOP)
- Generic Collections (`List<T>`)

## Project Structure

```text
Petra Wheels/
│
├── Program.cs
├── LoginManager.cs
├── Vehicle.cs
├── Car.cs
├── Motorcycle.cs
├── VehicleManager.cs
├── VehicleInput.cs
├── RentalInput.cs
├── ReturnInput.cs
└── ReportManager.cs
```

## Default Login Credentials

| Field | Value |
|---|---|
| Username | admin |
| Password | 1234 |

## Getting Started

### Prerequisites

- Visual Studio 2022 or later.
- .NET 10 SDK.

### Running the Application

1. Clone or download the repository.
2. Open the solution file (`.sln`) in Visual Studio.
3. Build the solution.
4. Run the application using `Ctrl + F5`.
5. Log in using the default administrator credentials.

## Main Menu

```text
===== PETRA WHEELS =====

1. Add Vehicle
2. Show Vehicles
3. Rent Vehicle
4. Return Vehicle
5. Reports
6. Exit
```

## OOP Concepts Demonstrated

The project applies several fundamental OOP principles:

- **Abstraction:** An abstract `Vehicle` class defines the common structure and behavior of vehicles.
- **Inheritance:** `Car` and `Motorcycle` inherit from the `Vehicle` base class.
- **Polymorphism:** Each vehicle type provides its own implementation of the `ShowInfo()` method.
- **Encapsulation:** Properties and validation logic control access to vehicle data.
- **Enums:** `VehicleStatus` represents the available and rented states.

## Notes

- Vehicle and rental information is maintained in memory during application execution.
- Data is not persisted in a database or external file.
- The application is designed as a console-based learning project.


Developed as part of a C# Programming Assignment for [Dalil Information Technology](https://www.linkedin.com/company/dalil-information-technology-jo).

<img width="1128" height="191" alt="image" src="https://github.com/user-attachments/assets/0e1b05a0-3036-422a-9669-48575e4fb930" />

