SELECT *
FROM AbsoluteGarbage;

--11/21/2017
DROP TABLE [User]

CREATE TABLE [User] (
	CustId int IDENTITY(10000,1) PRIMARY KEY,
	FirstName varchar(100),
	LastName varchar(100),
	PhoneNum char(12),
	EmailAddress varchar(100),
	Pw varchar(256))

DROP TABLE Items;

CREATE TABLE Items (
	ProductId int IDENTITY(1,1) PRIMARY KEY,
	ProductName varchar(100),
	ProductDesc varchar(1000),
	Qty int,
	price float,
	imgName varchar(max)
	)

DECLARE @pw1 varchar(20);
SET @pw1 = 'aBcD1234'

USE Groundswell;
INSERT INTO [User]
VALUES ('Stephen', 'Scobie', '777-777-7777', 'spscobie@gmail.com', HASHBYTES('SHA2_256', CONVERT(nvarchar(4000), 'aBcD1234'))),
	   ('Grant', 'Chirpus', '888-888-8888', 'gChirpz@gmail.com', HASHBYTES('SHA2_256', CONVERT(nvarchar(4000), 'a1b2c3d4'))),
	   ('Chuck', 'Norris', '666-666-6666', 'nunchucks@aol.com', HASHBYTES('SHA2_256', CONVERT(nvarchar(4000), 'd4c3b2a1'))),
	   ('John R', 'Dequindre', '999-999-9999', 'smashmcgavin@irishfightinghouse.com', CONVERT(varchar(4000), 'zZzZ2134')));

DELETE FROM [User]

SELECT HASHBYTES('SHA2_256',CONVERT(nvarchar(4000), 'aBcD1234'))

USE Groundswell
SELECT *
FROM [User]

DELETE FROM Items;

USE Groundswell;
INSERT INTO [User]
VALUES ('Stephen', 'Scobie', '777-777-7777', 'spscobie@gmail.com', 'aBcD1234'),
	   ('Grant', 'Chirpus', '888-888-8888', 'gChirpz@gmail.com', 'a1b2c3d4'),
	   ('Chuck', 'Norris', '666-666-6666', 'nunchucks@aol.com', 'd4c3b2a1'),
	   ('John R', 'Dequindre', '999-999-9999', 'smashmcgavin@irishfightinghouse.com', 'zZzZ2134');

USE Groundswell;
INSERT INTO Items
VALUES ('Chemex 9000', 'Science meets coffee.', 100, 79.99, null),
	   ('Hario ''Steve''-60', 'Sophisticated brewing experience. Unsophisticated price.', 100, 49.99, null),
	   ('My Name is Luca A53', 'Make the highest quality Italian espresso locally.', 20, 2999.99, null),
	   ('Kona Peaberry (1lb.)', 'The champagne of coffees.', 250, 29.99, null);

SELECT *
FROM Items

INSERT INTO Items
VALUES ('Chemex 9000', 'Science meets coffee.', 100, 79.99, null)

SELECT *
FROM [User]
WHERE EmailAddress = 'jimsmith@gmail.com'

--11/25/17
DROP TABLE [User]

CREATE TABLE Users (
	CustId int IDENTITY(10000,1) PRIMARY KEY,
	FirstName varchar(100),
	LastName varchar(100),
	ShiptToAddress varchar(100),
	ShipToCity varchar(100),
	ShipToState char(2),
	ShipToZip varchar(10),
	PhoneNum char(12),
	EmailAddress varchar(100),
	Pw varchar(256))

USE Groundswell;
INSERT INTO Users
VALUES ('Stephen', 'Scobie', '1111 Awesome St', 'Kalamaziggedy', 'MI', '49999', '777-777-7777', 'spscobie@gmail.com', 'aBcD1234'),
	   ('Grant', 'Chirpus', '1570 Woodward Ave', 'Detroit', 'MI', '48223', '888-888-8888', 'gChirpz@gmail.com', 'a1b2c3d4'),
	   ('Chuck', 'Norris', '1234 Foot Fist Way', 'Walker', 'TX', '75666', '666-666-6666', 'nunchucks@aol.com', 'd4c3b2a1'),
	   ('John R', 'Dequindre', '1 Unknown Ln', 'Detroit', 'MI', '48000', '999-999-9999', 'smashmcgavin@irishfightinghouse.com', 'zZzZ2134');

SELECT *
FROM Users

DROP TABLE Items;

CREATE TABLE Items (
	ProductId int IDENTITY(1,1) PRIMARY KEY,
	ProductName varchar(100),
	ProductDesc varchar(1000),
	Qty int,
	Price float,
	ImgName varchar(1000)
	)

USE Groundswell;
INSERT INTO Items
VALUES ('Chemex 9000', 'Science meets coffee.', 100, 79.99, 'chemex2.jpg'),
	   ('Hario ''Steve''-60', 'Sophisticated brewing experience. Unsophisticated price.', 100, 49.99, 'hario1.jpg'),
	   ('My Name is Luca A53', 'Make the highest quality Italian espresso locally.', 20, 2999.99, 'lucca1.jpg'),
	   ('Kona Peaberry (1lb.)', 'The champagne of coffees.', 250, 29.99, 'kona1.jpg');

SELECT *
FROM Items