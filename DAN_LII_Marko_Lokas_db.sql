IF DB_ID('BirthdayCake') IS NULL
CREATE DATABASE BirthdayCake
GO

USE BirthdayCake

ALTER DATABASE BirthdayCake COLLATE Croatian_CI_AS;
GO


-- Drop Foreign Keys
IF OBJECT_ID('tblOrder', 'U') IS NOT NULL 
	ALTER TABLE tblOrder DROP CONSTRAINT FK_Order_Guest;

--===================================================================

-- Drop Primary Keys
IF OBJECT_ID('tblCake', 'U') IS NOT NULL 
	ALTER TABLE tblCake DROP CONSTRAINT PK_Cake;
IF OBJECT_ID('tblGuest', 'U') IS NOT NULL 
	ALTER TABLE tblGuest DROP CONSTRAINT PK_Guest;
IF OBJECT_ID('tblOrder', 'U') IS NOT NULL 
	ALTER TABLE tblOrder DROP CONSTRAINT PK_Order;
--===================================================================

-- Drop tables
IF OBJECT_ID('tblCake', 'U') IS NOT NULL 
	DROP TABLE tblCake;
IF OBJECT_ID('tblOrder', 'U') IS NOT NULL 
	DROP TABLE tblOrder;
IF OBJECT_ID('tblGuest', 'U') IS NOT NULL 
	DROP TABLE tblGuest;

--===================================================================


-- Create tables
CREATE TABLE tblGuest(
	GuestID			int identity(1,1) NOT NULL,
	GuestNameSurname	nvarchar (70) NOT NULL,
	GuestAddress		nvarchar (70) NOT NULL,
	PhoneNumber			char(10) NOT NULL,
	GuestUsername				nvarchar(100) NOT NULL,
	GuestPassword				nvarchar(100) NOT NULL,
	NumberOrder			int
	)
CREATE TABLE tblCake(
	CakeID			int identity(1,1) NOT NULL,
	ProductName			nvarchar (50) NOT NULL,
	PurchasePrice		decimal(18,2) NOT NULL,
	SellingPrice		decimal(18,2) NOT NULL
	)
CREATE TABLE tblOrder(
	OrderID				int identity(1,1) NOT NULL,
	DateTimeOrder		datetime NOT NULL,
	Guest				int NOT NULL,
	TotalPrice			int NOT NULL,
	TotalCake			int NOT NULL,
	CakeList			nvarchar(200) NOT NULL
	)
--===================================================================

-- Add constraints for PK
ALTER TABLE tblGuest 
	ADD CONSTRAINT PK_Guest
	PRIMARY KEY (GuestID)

ALTER TABLE tblCake 
	ADD CONSTRAINT PK_Cake
	PRIMARY KEY (CakeID)

ALTER TABLE tblOrder 
	ADD CONSTRAINT PK_Order 
	PRIMARY KEY (OrderID)
--===================================================================

-- Add constraints for FK
ALTER TABLE tblOrder 
	ADD CONSTRAINT FK_Order_Guest
	FOREIGN KEY (Guest) 
	REFERENCES tblGuest (GuestID)
--===================================================================



INSERT INTO tblCake(ProductName, PurchasePrice, SellingPrice)
	VALUES ('Ljubavno gnezdo', 1000.00, 1000.00*1.2)
INSERT INTO tblCake(ProductName, PurchasePrice, SellingPrice)
	VALUES ('Lincer', 2000.00, 2000.00*1.2)
INSERT INTO tblCake(ProductName, PurchasePrice, SellingPrice)
	VALUES ('Cheese cake', 1200.00, 1200.00*1.2)
INSERT INTO tblCake(ProductName, PurchasePrice, SellingPrice)
	VALUES ('Doboš', 2500.00, 2500.00*1.2)
INSERT INTO tblCake(ProductName, PurchasePrice, SellingPrice)
	VALUES ('Bomba', 800.00, 800.00*1.2)
INSERT INTO tblCake(ProductName, PurchasePrice, SellingPrice)
	VALUES ('Kinder', 1100.00, 1100.00*1.2)
