

-- create schemas
CREATE SCHEMA list;
--drop schema list;
go

--Parent table
CREATE TABLE list (
    	list_id INT IDENTITY (1, 1) PRIMARY KEY,
	name VARCHAR (255) NOT NULL,
	purchase_date DATE NOT NULL
);

--Parent table
CREATE TABLE item (
    	item_id INT IDENTITY (1, 1) PRIMARY KEY,
	name VARCHAR (255) NOT NULL,
	category VARCHAR (255) NOT NULL
);

--Linking table
-- Create the junction table for the many-to-many relationship

CREATE TABLE list_item ( 
	list_id INT NOT NULL,
	item_id INT NOT NULL,
	price DECIMAL (5,2) NOT NULL,
--important to annotate the decimal type (5,2) and not just the name Decimal 

	FOREIGN KEY (list_id) REFERENCES list (list_id) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (item_id) REFERENCES item (item_id) ON DELETE CASCADE ON UPDATE CASCADE
);

--remember to use lower case everywhere in the code of thats the schema your going for
--otherwize sql server will throw an error for case sensetive and you have to go through
--to find where the issue is... throw error if different case names all over