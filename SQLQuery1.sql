CREATE TABLE Cars(
CarId int NOT NULL,
BrandId int NOT Null,
ColorId int NOT NULL,
ModelYear int NOT NULL,
DailyPrice int NOT NULL,
Description nvarchar(250) NOT NULL,
CONSTRAINT PK_Cars PRIMARY KEY (CarId)
);

CREATE TABLE Brands(
BrandId int NOT NULL,
BrandName nvarchar(250) NOT NULL,
CONSTRAINT PK_Brands PRIMARY KEY (BrandId)
);

CREATE TABLE Colors(
ColorId int NOT NULL,
ColorName nvarchar(250) NOT NULL,
CONSTRAINT PK_Colors PRIMARY KEY (ColorId)
);

INSERT INTO Cars(BrandId, ColorId, ModelYear, DailyPrice, Description)
Values
(1,1,2017,409000,'C 200'),
(2,3,2016,129500,'Egea'),
(3,2,2016,145500,'Fluence'),
(4,1,2018,300000,'A4'),
(5,3,2016,240000,'M3');

INSERT INTO Brands(BrandId,BrandName)
Values
(1,'Mercedes- Benz'),
(2,'Fıat'),
(3,'Renault'),
(4,'Audi'),
(5,'BMW');

INSERT INTO Colors(ColorId, ColorName)
Values
(1,'Siyah'),
(2,'Beyaz'),
(3,'Gri'),
(4,'Kırmızı'),
(5,'Lacivert')