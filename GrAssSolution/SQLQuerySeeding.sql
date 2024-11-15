-- Inserting data into the [Member] table
INSERT INTO [dbo].[Member] (Email, CompanyName, City, Country, Password)
VALUES 
('john.doe@example.com', 'Doe Enterprises', 'New York', 'USA', 'password123'),
('jane.smith@example.com', 'Smith Corp', 'Los Angeles', 'USA', 'password456'),
('alice.jones@example.com', 'Jones Ltd.', 'London', 'UK', 'password789'),
('bob.brown@example.com', 'Brown Inc.', 'Toronto', 'Canada', 'password000'),
('charlie.white@example.com', 'White Solutions', 'Sydney', 'Australia', 'passwordabc');

-- Inserting data into the [Product] table
INSERT INTO [dbo].[Product] (CategoryId, ProductName, Weight, UnitPrice, UnitsInStock)
VALUES
(1, 'Laptop', '1.5kg', 1200.00, 50),
(1, 'Smartphone', '0.2kg', 800.00, 100),
(2, 'Headphones', '0.3kg', 150.00, 200),
(2, 'Keyboard', '1kg', 50.00, 150),
(3, 'Office Chair', '7kg', 250.00, 30);

-- Inserting data into the [Order] table
INSERT INTO [dbo].[Order] (OrderId, MemberId, OrderDate, RequiredDate, ShippedDate, Freight)
VALUES
(1, 1, '2024-11-10', '2024-11-15', '2024-11-12', 30.00),
(2, 2, '2024-11-11', '2024-11-16', '2024-11-13', 15.00),
(3, 3, '2024-11-12', '2024-11-18', '2024-11-14', 10.00),
(4, 4, '2024-11-13', '2024-11-20', '2024-11-15', 25.00),
(5, 5, '2024-11-14', '2024-11-22', '2024-11-16', 20.00);

-- Inserting data into the [OrderDetail] table
INSERT INTO [dbo].[OrderDetail] (OrderId, ProductId, UnitPrice, Quantity, Discount)
VALUES
(1, 1, 1200.00, 1, 0.05),
(1, 3, 150.00, 2, 0.10),
(2, 2, 800.00, 1, 0.00),
(2, 4, 50.00, 3, 0.15),
(3, 5, 250.00, 1, 0.05);
