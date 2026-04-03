# Employee Management System - Backend API

## Overview
This project is a backend application built using C# and .NET Web API to manage employee data. It provides APIs to perform basic operations like adding, viewing, updating, and deleting employees.

## What This API Does
- Add a new employee
- Get all employees
- Get employee details by ID
- Update employee information
- Soft delete an employee (marks as inactive instead of removing)

## API Endpoints
- GET    /api/employee        → Returns all employees
- GET    /api/employee/{id}   → Returns employee by ID
- POST   /api/employee        → Adds a new employee
- PUT    /api/employee/{id}   → Updates employee details
- DELETE /api/employee/{id}   → Marks employee as inactive

## Technologies Used
- C#
- .NET Web API
- Entity Framework Core
- SQL Server

## Key Points
- Uses a clean layered structure (Controller, Service, DTO, DbContext)
- Implements soft delete using `IsActive` flag
- Designed for easy understanding and maintainability

- ## Purpose
This project was developed to understand backend development, API design, and database interaction using .NET.
