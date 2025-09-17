ALTER TABLE add_customer
ADD Purchase_data DATETIME; 
ALTER TABLE add_customer
ALTER COLUMN ID_No VARCHAR(13);
ALTER TABLE add_customer
DROP CONSTRAINT PK_add_customer;
SELECT name 
FROM sys.key_constraints 
WHERE type = 'PK' AND parent_object_id = OBJECT_ID('add_customer');
ALTER TABLE add_customer
ALTER COLUMN ID_No VARCHAR(13);
ALTER TABLE add_customer
ADD CONSTRAINT PK_add_customer PRIMARY KEY (ID_No);
ALTER TABLE add_customer
ALTER COLUMN ID_No VARCHAR(13) NOT NULL;
ALTER TABLE add_customer
ADD CONSTRAINT PK_add_customer PRIMARY KEY (ID_No);
ALTER TABLE add_customer
DROP CONSTRAINT PK_add_customer;
ALTER TABLE add_customer
ADD CustomerID INT IDENTITY(1,1) PRIMARY KEY;





