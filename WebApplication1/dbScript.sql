create database test_db;

create table if not exists Invoice_Hed (
                                           Invoice_Hed_id INT NOT NULL ,
                                           Invoice_Hed_Date DATETIME,
                                           Invoice_Hed_Amount DOUBLE,
                                           Invoice_Hed_Customer VARCHAR(45),

                                            CONSTRAINT PRIMARY KEY (Invoice_Hed_id)
    );

create table if not exists Products (
                                        Products_id INT NOT NULL ,
                                        Product_Name varchar(45),
                                        Products_price VARCHAR(45),
                                        Products_qty INT,

                                        CONSTRAINT PRIMARY KEY (Products_id)
    );

create table if not exists Invoice_Details (
                                               Invoice_Details_Id INT NOT NULL ,
                                               Invoice_Details_qty INT,
                                               Invoice_Details_amount DOUBLE,
                                               Invoice_Hed_Invoice_Hed_id INT,
                                               Products_Products_id INT,

                                               CONSTRAINT PRIMARY KEY (Invoice_Details_Id),
                                               CONSTRAINT FOREIGN KEY (Invoice_Hed_Invoice_Hed_id) REFERENCES Invoice_Hed(Invoice_Hed_id) ON DELETE CASCADE ON UPDATE CASCADE,
                                               CONSTRAINT FOREIGN KEY (Products_Products_id) REFERENCES Products(Products_id) ON DELETE CASCADE ON UPDATE CASCADE
    );