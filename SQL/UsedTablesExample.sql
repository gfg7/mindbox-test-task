CREATE TABLE Product (
  Id int NOT NULL PRIMARY KEY IDENTITY(1,1),
  Name varchar(200) NOT NULL
);
INSERT INTO Product (Name) VALUES
  ('1product'),
  ('2product'),  
  ('3product'),  
  ('4product'),  
  ('5product');
  
CREATE TABLE Category (
  Id int NOT NULL PRIMARY KEY IDENTITY(1,1),
  Name varchar(200) NOT NULL
);
INSERT INTO Category (Name) VALUES
  ('1categ'),
  ('2categ'),  
  ('3categ');
  
CREATE TABLE ProductCategory (
  Id int NOT NULL PRIMARY KEY IDENTITY(1,1),
  ProductId int NOT NULL,
  CategoryId int NOT NULL,
  FOREIGN KEY (ProductId) REFERENCES Product(Id),
  FOREIGN KEY (CategoryId) REFERENCES Category(Id)
);
INSERT INTO ProductCategory (ProductId, CategoryId) VALUES
  (1, 1),  
  (2, 2),
  (1, 3),
  (2, 2),  
  (2, 1), 
  (3, 3);