DROP DATABASE INFT3050

CREATE DATABASE INFT3050
DROP TABLE Product
DROP TABLE UserAccount
DROP TABLE CardType
DROP TABLE ShippingLocation
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


CREATE TABLE CardType (
CreditCardType VARCHAR(10) PRIMARY KEY NOT NULL,
cardName VARCHAR(50) NOT NULL)


CREATE TABLE ShippingMethod (
ShippingId INT PRIMARY KEY NOT NULL,
method VARCHAR(50) NOT NULL,
Price DECIMAL (10,2) NOT NULL)



CREATE TABLE Invoice (
InvoiceID INT PRIMARY KEY NOT NULL,
userId INT NOT NULL,
OrderDate date NOT NULL,
ShippingMethod INT NOT NULL,
ShippingAddress VARCHAR(50) NOT NULL,
GST INT NOT NULL,
Subtotal DECIMAL (10,2) NOT NULL,
totalcost DECIMAL (10,2) NOT NULL,
CreditCardType VARCHAR(10) NOT NULL,
CardNumber INT NOT NULL,
ExpirationDate date NOT NULL,
CVV SMALLINT NOT NULL,
FOREIGN KEY (userId) REFERENCES UserAccount(userId),
FOREIGN KEY (CreditCardType) REFERENCES CardType(CreditCardType),
FOREIGN KEY (ShippingMethod) REFERENCES ShippingMethod(ShippingId))


CREATE TABLE ShoppingCart (
InvoiceID INT NOT NULL,
ProductID INT NOT NULL,
Price DECIMAL (10,2) NOT NULL,
ItemQuantity INT NOT NULL,
FOREIGN KEY (InvoiceID) REFERENCES Invoice(InvoiceID),
FOREIGN KEY (ProductID) REFERENCES Product(ProductID))



INSERT INTO Product VALUES ('1','New','Tooheys','Images/old.PNG','16.00','4.5%, Tooheys Old is a robustly flavoured Ale made with top fermentation Ale yeast. The beer is lightly hopped, and gets its darker colour from black malt.')
INSERT INTO Product VALUES ('2','Old Dark Ale','Tooheys','Images/new.PNG','18.00','4.5%, Tooheys Old is a robustly flavoured Ale made with top fermentation Ale yeast.')
INSERT INTO Product VALUES ('3','Dry','Carlton','Images/dry.PNG','45.00','The beer is lightly hopped, and gets its darker colour from black malt.')

INSERT INTO UserAccount VALUES ('1','wade.carmichael@uon.edu.au','password','Wade','Carmichael','0449784755','Australia')
INSERT INTO UserAccount VALUES ('2','luke.mckenzie@uon.edu.au','password','Luke','McKenzie','0374832991','Australia')
INSERT INTO UserAccount VALUES ('3','nathan.haigh@uon.edu.au','password','Nathan','Haigh','0457458475','Australia')

INSERT INTO CardType VALUES ('VISA','CREDITCARD1')
INSERT INTO CardType VALUES ('MasterCard','CREDITCARD2')

INSERT INTO ShippingMethod VALUES ('1','Normal Delivery','3.00')
INSERT INTO ShippingMethod VALUES ('2','Express Delivery','10.00')

INSERT INTO Invoice VALUES ('1','1','1999-12-25','1','Australia','10','40.00','50.00','VISA','3434334','2019-08-25','432')
INSERT INTO Invoice VALUES ('2','3','1999-12-25','2','Australia','5','40.00','45.00','VISA','34547676','2019-08-25','466')


INSERT INTO ShoppingCart VALUES ('1','2','35.00','2')
INSERT INTO ShoppingCart VALUES ('2','2','20.00','1')
INSERT INTO ShoppingCart VALUES ('1','1','14.00','1')

SELECT * FROM Product

SELECT * FROM UserAccount
SELECT * FROM CardType
SELECT * FROM ShippingMethod
SELECT * FROM Invoice
SELECT * FROM ShoppingCart


