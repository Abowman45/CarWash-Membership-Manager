# Car Wash Membership Management System

A Windows Forms CRUD application built in VB.NET for managing car wash customer memberships and RFID vehicle tracking.

## Features
- Add and manage customer accounts
- Track RFID stickers linked to customer vehicles
- Search customers by first name, last name, RFID, or CC last 4
- Edit customer details and manage vehicles
- Active/Canceled status based on payment dates
- Parameterized queries throughout to prevent SQL injection

## Technologies Used
- VB.NET
- Windows Forms
- MySQL
- ADO.NET
- Visual Studio

## Setup
1. Install MySQL Server and create a database called `CarWashDB`
2. Run `sql/schema.sql` in MySQL Workbench to create the tables, then optionally run `sql/seed.sql` to populate with sample data
3. Copy `App.config.example` to `App.config`
4. Update `App.config` w
