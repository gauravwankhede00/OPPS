CREATE TABLE [dbo].[Sales] (
    [OrderID]    INT             IDENTITY (1, 1) NOT NULL,
    [CustomerID] INT             NOT NULL,
    [ProductID]  INT             NOT NULL,
    [Quantity]   INT             NOT NULL,
    [UnitPrice]  DECIMAL (10, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([OrderID] ASC)
);

