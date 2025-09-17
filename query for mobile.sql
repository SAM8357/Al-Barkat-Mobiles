CREATE TABLE ADD_MOBILE (
    MobileID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100),
    Model VARCHAR(100),
    Stock INT,
    Price DECIMAL(10, 2),
    Concession DECIMAL(10, 2)
);