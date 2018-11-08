<<<<<<< HEAD
DROP DATABASE INFT3050

CREATE DATABASE INFT3050
DROP TABLE Product
DROP TABLE UserAccount
DROP TABLE Invoice
DROP TABLE ShoppingCart

CREATE TABLE Product (
ProductID INT PRIMARY KEY NOT NULL,
Name VARCHAR(50) NOT NULL,
Brand VARCHAR(50) NOT NULL,
ImageFile VARCHAR(50) NULL,
Price DECIMAL (10,2) NOT NULL,
LongDescription VARCHAR(300) NOT NULL)

CREATE TABLE UserAccount (
userId INT PRIMARY KEY NOT NULL,
Email VARCHAR(50) NOT NULL,
userPassword VARCHAR(50) NOT NULL,
FirstName VARCHAR(50) NOT NULL,
LastName VARCHAR(50) NOT NULL,
PhoneNumber INT NOT NULL,
userAddress VARCHAR(50) NOT NULL)


CREATE TABLE Invoice (
InvoiceID INT PRIMARY KEY NOT NULL,
userId INT NULL,
OrderDate VARCHAR(200) NULL,
ShippingAddress VARCHAR(50) NULL,
CreditCardType VARCHAR(50)  NULL,
CardNumber BIGINT NULL,
ExpirationDate VARCHAR(50) NULL,
CVV INT NULL,
FOREIGN KEY (userId) REFERENCES UserAccount(userId))


CREATE TABLE ShoppingCart (
InvoiceID INT NOT NULL,
ProductID INT NOT NULL,
SubTotal DECIMAL (10,2) NOT NULL,
ItemQuantity INT NOT NULL,
FOREIGN KEY (InvoiceID) REFERENCES Invoice(InvoiceID),
FOREIGN KEY (ProductID) REFERENCES Product(ProductID))

INSERT INTO Product VALUES ('1','New','Tooheys','Images/old.PNG','16.00','4.5%, Tooheys Old is a robustly flavoured Ale made with top fermentation Ale yeast. The beer is lightly hopped, and gets its darker colour from black malt.')
INSERT INTO Product VALUES ('2','Old Dark Ale','Tooheys','Images/new.PNG','18.00','4.5%, Tooheys Old is a robustly flavoured Ale made with top fermentation Ale yeast.')
INSERT INTO Product VALUES ('3','Dry','Carlton','Images/dry.PNG','45.00','The beer is lightly hopped, and gets its darker colour from black malt.')

INSERT INTO UserAccount VALUES ('1','wade.carmichael@uon.edu.au','password','Wade','Carmichael','0449784755','Australia')
INSERT INTO UserAccount VALUES ('2','luke.mckenzie@uon.edu.au','password','Luke','McKenzie','0374832991','Australia')
INSERT INTO UserAccount VALUES ('3','nathan.haigh@uon.edu.au','password','Nathan','Haigh','0457458475','Australia')

SELECT * FROM UserAccount
SELECT * FROM Invoice
DELETE FROM ShoppingCart
=======
DROP DATABASE INFT3050

CREATE DATABASE INFT3050
DROP TABLE Product
DROP TABLE UserAccount
DROP TABLE Invoice
DROP TABLE ShoppingCart

CREATE TABLE Product (
ProductID INT PRIMARY KEY NOT NULL,
Name VARCHAR(50) NOT NULL,
Brand VARCHAR(50) NOT NULL,
ImageFile VARCHAR(50) NULL,
Price DECIMAL (10,2) NOT NULL,
LongDescription VARCHAR(300) NOT NULL)

CREATE TABLE UserAccount (
userId INT PRIMARY KEY NOT NULL,
Email VARCHAR(50) NOT NULL,
userPassword VARCHAR(50) NOT NULL,
FirstName VARCHAR(50) NOT NULL,
LastName VARCHAR(50) NOT NULL,
PhoneNumber INT NOT NULL,
userAddress VARCHAR(50) NOT NULL)


CREATE TABLE Invoice (
InvoiceID INT PRIMARY KEY NOT NULL,
userId INT NULL,
OrderDate VARCHAR(200) NULL,
ShippingAddress VARCHAR(50) NULL,
CreditCardType VARCHAR(50)  NULL,
CardNumber BIGINT NULL,
ExpirationDate VARCHAR(50) NULL,
CVV INT NULL,
FOREIGN KEY (userId) REFERENCES UserAccount(userId))


CREATE TABLE ShoppingCart (
InvoiceID INT NOT NULL,
ProductID INT NOT NULL,
SubTotal DECIMAL (10,2) NOT NULL,
ItemQuantity INT NOT NULL,
FOREIGN KEY (InvoiceID) REFERENCES Invoice(InvoiceID),
FOREIGN KEY (ProductID) REFERENCES Product(ProductID))

INSERT INTO Product VALUES ('1','New','Tooheys','Images/old.PNG','16.00','4.5%, Tooheys Old is a robustly flavoured Ale made with top fermentation Ale yeast. The beer is lightly hopped, and gets its darker colour from black malt.')
INSERT INTO Product VALUES ('2','Old Dark Ale','Tooheys','Images/new.PNG','18.00','4.5%, Tooheys Old is a robustly flavoured Ale made with top fermentation Ale yeast.')
INSERT INTO Product VALUES ('3','Dry','Carlton','Images/dry.PNG','45.00','The beer is lightly hopped, and gets its darker colour from black malt.')

INSERT INTO UserAccount VALUES ('1','wade.carmichael@uon.edu.au','password','Wade','Carmichael','0449784755','Australia')
INSERT INTO UserAccount VALUES ('2','luke.mckenzie@uon.edu.au','password','Luke','McKenzie','0374832991','Australia')
INSERT INTO UserAccount VALUES ('3','nathan.haigh@uon.edu.au','password','Nathan','Haigh','0457458475','Australia')

SELECT * FROM UserAccount
SELECT * FROM Invoice
DELETE FROM ShoppingCart
>>>>>>> 66481548e9307732a65ba95bd31dc949950e47cb
DELETE FROM Invoice