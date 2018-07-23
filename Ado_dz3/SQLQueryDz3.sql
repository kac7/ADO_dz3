--CREATE DATABASE StoreRefrigerators
USE StoreRefrigerators
go
CREATE TABLE Product
(ID int NOT NULL PRIMARY KEY IDENTITY(1,1),
IDSeller int not null FOREIGN KEY REFERENCES Seller(ID) ON DELETE CASCADE,
NameProduct nvarchar(30) NOT NULL,
PriceProduct decimal NOT NULL,
QuantityProduct int NOT NULL,
ColorProduct nvarchar(30) NOT NULL)

go
CREATE TABLE Seller
(ID int NOT NULL PRIMARY KEY IDENTITY(1,1),
NameSeller nvarchar(30) NOT NULL,
SumProduct decimal NOT NULL)

go
CREATE TABLE Buyer
(ID int NOT NULL PRIMARY KEY IDENTITY(1,1),
NameBuyer nvarchar(30) NOT NULL,
SumBuyer decimal NOT NULL)
go
CREATE TABLE CheckSale
(ID int NOT NULL PRIMARY KEY IDENTITY(1,1),
IDProduct int not null FOREIGN KEY REFERENCES Product(ID) ON DELETE CASCADE,
IDSeller int not null FOREIGN KEY REFERENCES Seller(ID) ON DELETE CASCADE,
IDBuyer int not null FOREIGN KEY REFERENCES Buyer(ID) ON DELETE CASCADE,
DateSale date not null,
Price decimal NOT NULL)

go
INSERT Product VALUES
(1,'SAMSUNG',12999,10,'Серый'),
(2,'BOSCH',17299,10,'Белый'),
(1,'SNAIGE',5333,10,'Белый'),
(2,'LIEBHERR',17399,10,'Серый'),
(1,'CANDY',12399,10,'Белый'),
(2,'HITACHI',17999,10,'Серый')

go
INSERT Seller VALUES
('Rozetka‎',0),
('Comfy',0)

go
INSERT Buyer VALUES
('Виктор‎ Б',50000),
('Сергей Ф',40000),
('Артем‎ А',30000),
('Евгений Ж',40000),
('Роман К‎',20000),
('Сергей П',50000)

