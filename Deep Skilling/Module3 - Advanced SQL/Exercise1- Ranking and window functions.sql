CREATE DATABASE OnlineRetailStores;
GO

USE OnlineRetailStores;
GO
CREATE TABLE Products
(
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

INSERT INTO Products VALUES
(101,'Laptop','Electronics',80000),
(102,'Mobile','Electronics',50000),
(103,'Headphones','Electronics',3000),
(104,'Smart Watch','Electronics',15000),
(105,'Shirt','Fashion',1500),
(106,'Jeans','Fashion',2500),
(107,'Jacket','Fashion',4000),
(108,'Shoes','Fashion',4000),
(109,'Rice Bag','Grocery',1200),
(110,'Cooking Oil','Grocery',1800),
(111,'Sugar','Grocery',900),
(112,'Dry Fruits','Grocery',1800);

SELECT
    ProductID,
    ProductName,
    Category,
    Price,

    ROW_NUMBER() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RowNumber,

    RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RankNumber,

    DENSE_RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS DenseRank

FROM Products;
