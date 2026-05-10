CREATE DATABASE CarWashDB;
USE CarWashDB;

CREATE TABLE Customer (
    CustomerID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    CCLast4 VARCHAR(4) CHECK (CCLast4 REGEXP '[0-9]{4}$'),
    PlanType ENUM('Medium', 'Spicy', 'Cajun Hot') NOT NULL,
    LastPayment DATE,
    NextPayment DATE
);

ALTER TABLE Customer AUTO_INCREMENT = 1000000000;

CREATE TABLE Memberships (
    RFIDNumber VARCHAR(9),
    CustomerID INT NOT NULL,
    LicensePlate VARCHAR(50),
    PRIMARY KEY (RFIDNumber),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);