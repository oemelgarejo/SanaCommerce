IF NOT EXISTS (SELECT *
FROM sys.databases
WHERE name = 'SanaCommerceDB')
BEGIN
    EXEC sp_executesql N'CREATE DATABASE SanaCommerceDB';
END;

USE SanaCommerceDB;

--Category
CREATE TABLE dbo.Categories
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Name NVARCHAR(100) NOT NULL
);

--Customer
CREATE TABLE dbo.Customers
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    FullName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE
);
CREATE INDEX IX_Customers_Email
ON dbo.Customers (Email);

--Product
CREATE TABLE dbo.Products
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Title NVARCHAR(255) NOT NULL,
    ProductCode NVARCHAR(50),
    Description NVARCHAR(500),
    Price DECIMAL(18, 2) NOT NULL,
    Stock INT NOT NULL,
    CreatedAt DATETIMEOFFSET DEFAULT SYSDATETIME()
);
CREATE INDEX IX_Products_ProductCode
ON dbo.Products (ProductCode);

CREATE TABLE dbo.Orders
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    OrderDate DATETIMEOFFSET NOT NULL,
    CustomerId UNIQUEIDENTIFIER NOT NULL,
    FOREIGN KEY (CustomerId) REFERENCES dbo.Customers(Id)
);

CREATE TABLE dbo.OrderItems
(
    OrderId UNIQUEIDENTIFIER NOT NULL,
    ProductId UNIQUEIDENTIFIER NOT NULL,
    Quantity INT NOT NULL,
    PRIMARY KEY (OrderId),
    FOREIGN KEY (OrderId) REFERENCES dbo.Orders(Id),
    FOREIGN KEY (ProductId) REFERENCES dbo.Products(Id)
);
CREATE INDEX IX_OrderItems_ProductId
ON dbo.OrderItems (ProductId);
CREATE INDEX IX_OrderItems_OrderId
ON dbo.OrderItems (OrderId);
CREATE INDEX IX_Orders_CustomerId
ON dbo.Orders (CustomerId);

CREATE TABLE dbo.ProductCategories
(
    ProductId UNIQUEIDENTIFIER NOT NULL,
    CategoryId UNIQUEIDENTIFIER NOT NULL,
    PRIMARY KEY (ProductId, CategoryId),
    FOREIGN KEY (ProductId) REFERENCES dbo.Products(Id),
    FOREIGN KEY (CategoryId) REFERENCES dbo.Categories(Id)
);

INSERT INTO dbo.Categories
    (Id, Name)
VALUES
    (NEWID(), 'Electronics'),
    (NEWID(), 'Books'),
    (NEWID(), 'Clothing');

--Create products
INSERT INTO dbo.Products
    (Title, ProductCode, Description, Price, Stock)
VALUES
    ('Product 1', 'P001', 'Description for Product 1', 19.99, 100),
    ('Product 2', 'P002', 'Description for Product 2', 29.99, 150),
    ('Product 3', 'P003', 'Description for Product 3', 39.99, 200),
    ('Product 4', 'P004', 'Description for Product 4', 49.99, 250),
    ('Product 5', 'P005', 'Description for Product 5', 59.99, 300),
    ('Product 6', 'P006', 'Description for Product 6', 69.99, 350),
    ('Product 7', 'P007', 'Description for Product 7', 79.99, 400),
    ('Product 8', 'P008', 'Description for Product 8', 89.99, 450),
    ('Product 9', 'P009', 'Description for Product 9', 99.99, 500),
    ('Product 10', 'P010', 'Description for Product 10', 109.99, 550),
    ('Product 11', 'P011', 'Description for Product 11', 119.99, 600),
    ('Product 12', 'P012', 'Description for Product 12', 129.99, 650),
    ('Product 13', 'P013', 'Description for Product 13', 139.99, 700),
    ('Product 14', 'P014', 'Description for Product 14', 149.99, 750),
    ('Product 15', 'P015', 'Description for Product 15', 159.99, 800),
    ('Product 16', 'P016', 'Description for Product 16', 169.99, 850),
    ('Product 17', 'P017', 'Description for Product 17', 179.99, 900),
    ('Product 18', 'P018', 'Description for Product 18', 189.99, 950),
    ('Product 19', 'P019', 'Description for Product 19', 199.99, 1000),
    ('Product 20', 'P020', 'Description for Product 20', 209.99, 1050),
    ('Product 21', 'P021', 'Description for Product 21', 219.99, 1100),
    ('Product 22', 'P022', 'Description for Product 22', 229.99, 1150),
    ('Product 23', 'P023', 'Description for Product 23', 239.99, 1200),
    ('Product 24', 'P024', 'Description for Product 24', 249.99, 1250),
    ('Product 25', 'P025', 'Description for Product 25', 259.99, 1300),
    ('Product 26', 'P026', 'Description for Product 26', 269.99, 1350),
    ('Product 27', 'P027', 'Description for Product 27', 279.99, 1400),
    ('Product 28', 'P028', 'Description for Product 28', 289.99, 1450),
    ('Product 29', 'P029', 'Description for Product 29', 299.99, 1500),
    ('Product 30', 'P030', 'Description for Product 30', 309.99, 1550);