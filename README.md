# Employee Management System - Backend API

## Overview
This project is a backend application built using C# and .NET Web API to manage employee data. It provides APIs to perform CRUD operations with a structured and maintainable design.

## Features
- Create employee
- Get all employees
- Get employee by ID
- Update employee details
- Soft delete (mark employee as inactive)

## API Endpoints
- GET    /api/employee        → Get all employees
- GET    /api/employee/{id}   → Get employee by ID
- POST   /api/employee        → Create new employee
- PUT    /api/employee/{id}   → Update employee
- DELETE /api/employee/{id}   → Soft delete employee

## Technologies
- C#
- .NET Web API
- Entity Framework Core
- SQL Server

## Key Highlights
- Layered architecture (Controller, Service, DTO, DbContext)
- Soft delete using `IsActive` flag
- Clean and scalable design
