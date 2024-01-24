-- TO CREATE A DATABASE
CREATE DATABASE Demo

-- TO USE THE DATABASE
USE Demo

-- TO CREATE A TABLE
CREATE TABLE Info (
ID INT Primary Key not null Identity(10,1),
Username VARCHAR(250),
Password VARCHAR(250)
);

-- TO DISPLAY THE TABLE
SELECT * FROM INFO

-- TO INSERT VALUES INTO TABLE
INSERT INTO info (Username,Password) VALUES('Yousuf',12345)
INSERT INTO info (Username) VALUES('Zubair')
INSERT INTO info VALUES('Sadaf',543)

-- TO DELETE VALUES 
DELETE FROM Info WHERE ID = 11

-- SELECT QUERIES
SELECT * FROM INFO Where Password is null
SELECT * FROM INFO Where Password is not null
SELECT Username FROM INFO
SELECT * FROM Info WHERE Username = 'Yousuf'

-- TO UPDATE VALUES
Update Info Set Username = 'Kashif' WHERE ID = 12
Update Info Set Username = 'Yousuf Naveed', Password = '1255' WHERE ID = 10

-- TO DELETE ALL VALUES 
DELETE FROM Info


-- TO INSERT VALUES 
INSERT INTO Info VALUES ('Khuzaima', 123)
INSERT INTO Info VALUES ('Yousuf', 321)
INSERT INTO Info VALUES ('Shoaib', 543)
INSERT INTO Info VALUES ('Muneeb', 234)
INSERT INTO Info VALUES ('Huzaifa', 157)

-- TO DISPLAY THE TABLE IN ASC/DESC Order
Select * From Info Order By Username ASC
Select * From Info Order By Username DESC

-- TO CREATE A TABLE
Create Table info2 (
ID INT Identity(1,1) Primary Key Not Null,
Item VARCHAR(250),
Quantity INT,
Price INT
);

-- TO DISPLAY THE TABLE
SELECT * From Info2

-- TO INSERT VALUES
INSERT INTO Info2 VALUES ('Keyboard', 15, 650)
INSERT INTO Info2 VALUES ('Mousepad', 8, 150)
INSERT INTO Info2 VALUES ('Monitor', 3, 3200)

-- FUNCTIONS
Select SUM(Price) From Info2
Select Count(Price) From Info2
Select Avg(Price) From Info2
Select Min(Price) From Info2
Select Max(Price) From Info2
SELECT Lower(Username) From Info
SELECT Upper(Username) From Info
SELECT Username, Len(Username) From Info

