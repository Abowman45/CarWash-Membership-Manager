# Car Wash Membership Management System

A Windows Forms application built in VB.NET that manages customer memberships and vehicle RFID tracking for a car wash business.

## Overview

This project simulates a real-world car wash management system, allowing staff to track customers, manage memberships, and associate RFID tags with vehicles for automated identification and access.

## Features

* Customer account creation and management
* Vehicle tracking with RFID tag association
* Search functionality by name, RFID, or last 4 digits of credit card
* Edit customer and vehicle information
* Membership status tracking (Active / Canceled based on payment dates)
* Secure database operations using parameterized ADO.NET queries

## Tech Stack

* VB.NET
* Windows Forms (.NET Framework 4.7.2)
* MySQL
* ADO.NET
* Visual Studio

## Setup Instructions

1. Install MySQL Server and create a database named `CarWashDB`
2. Run `sql/schema.sql` to create tables
3. (Optional) Run `sql/seed.sql` to populate sample data
4. Copy `App.config.example` → `App.config`
5. Update connection string with your MySQL credentials
6. Open solution in Visual Studio and run

## Notes

* All SQL queries use parameterized commands to prevent SQL injection
* Designed as a learning project to demonstrate full-stack CRUD operations with a relational database
