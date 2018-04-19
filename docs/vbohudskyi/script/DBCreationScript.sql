CREATE DATABASE ProductWarehouse
ON
( 
    NAME = "PWarehouse", 
	FILENAME = "C:\Program Files\Microsoft SQL Server\MSSQL11.MYSQLSERVER\MSSQL\DATA\ProductWareHouse.mdf",
	SIZE = 10MB,
	MAXSIZE = 100MB,
	FILEGROWTH = 10MB
)
LOG ON
(
   NAME = "PLog",
   FILENAME = "C:\Program Files\Microsoft SQL Server\MSSQL11.MYSQLSERVER\MSSQL\DATA\ProductWareHouse.ldf",
   SIZE = 10MB,
   MAXSIZE = 50MB,
   FILEGROWTH = 10MB
);

CREATE TABLE ROLE
(
   RID int IDENTITY PRIMARY KEY,
   NAME varchar(25) NOT NULL UNIQUE
)

EXEC sp_helpconstraint ROLE;

CREATE TABLE PERMISSIONS
(
    PID int IDENTITY PRIMARY KEY,
	NAME varchar(15) NOT NULL UNIQUE
);

EXEC sp_helpconstraint PERMISSIONS;

CREATE TABLE RolePermissions
(
   RPID int IDENTITY PRIMARY KEY,
   RID int NOT NULL,
   PID int NOT NULL,
   CONSTRAINT fk_RoleID FOREIGN KEY(RID) REFERENCES ROLE(RID),
   CONSTRAINT fk_PermissionID FOREIGN KEY(PID) REFERENCES Permissions(PID)
);

EXEC sp_helpconstraint RolePermissions;

CREATE TABLE Users
(
   ID int IDENTITY NOT NULL,
   UID varchar(10) PRIMARY KEY,
   RID int NOT NULL DEFAULT 1,
   LNAME varchar(25) NOT NULL,
   FNAME varchar(25) NOT NULL,
   RSA varchar(256) NOT NULL UNIQUE,
   LOGIN varchar(50) NOT NULL,
   PSW varchar(25) NOT NULL,
   ACTIVE bit NOT NULL DEFAULT 1,
   CREATION_DATE smalldatetime DEFAULT GETDATE(),
   CONSTRAINT ck_psw CHECK(DATALENGTH(PSW)>=8),
   CONSTRAINT fk_UserRoleID FOREIGN KEY(RID) REFERENCES ROLE(RID)
);

EXEC sp_helpconstraint Users;

CREATE TABLE SignIn
(
   ID int IDENTITY PRIMARY KEY,
   UID varchar(10) NOT NULL UNIQUE,
   SIGN_IN_DATE smalldatetime DEFAULT GETDATE(),
   IP varchar(15),
   COOKIE varchar(15) DEFAULT CONVERT(varchar(15), NEWID())
   CONSTRAINT fk_userID FOREIGN KEY (UID) REFERENCES Users(UID)
);

EXEC sp_helpconstraint SignIn;

ALTER TABLE SignIn
ADD CONSTRAINT ck_ip_address CHECK(IP LIKE '%[0-9]%.%[0-9]%.%[0-9]%.%[0-9]%');

ALTER TABLE Users
ADD CONSTRAINT uq_login UNIQUE(LOGIN);

CREATE TABLE Company
(
   ID int IDENTITY NOT NULL,
   CID varchar(15) PRIMARY KEY,
   NAME varchar(50) NOT NULL UNIQUE,
   DESCRIPTION varchar(100)
) 

ALTER TABLE Users
ADD CID varchar(15) NOT NULL;

ALTER TABLE Users
ADD CONSTRAINT fk_companyID FOREIGN KEY (CID) REFERENCES Company(CID);

EXEC sp_helpconstraint Users;

CREATE TABLE ProductType
(
   TID int IDENTITY PRIMARY KEY,
   Name varchar(20) NOT NULL UNIQUE
)

CREATE TABLE ProductInventory
(
   ID int IDENTITY NOT NULL,
   PrID varchar(10) PRIMARY KEY,
   Description varchar(100),
   Active bit DEFAULT 1,
)

ALTER TABLE ProductInventory
ADD TID int NOT NULL FOREIGN KEY REFERENCES ProductType(TID)

EXEC sp_helpconstraint ProductInventory;

CREATE TABLE ProductDocument
(
   ID int IDENTITY NOT NULL,
   DocumentID varchar(15) PRIMARY KEY,
   Name varchar(25) NOT NULL,
   PrID varchar(10) NOT NULL,
   CONSTRAINT fk_prodID FOREIGN KEY(PrID) REFERENCES ProductInventory(PrID),
);

CREATE TABLE InventoryDocumetation
(
   ID int IDENTITY PRIMARY KEY,
   UID varchar(10) NOT NULL,
   DocumentID varchar(15) NOT NULL,
   CONSTRAINT fk_inv_userID FOREIGN KEY(UID) REFERENCES Users(UID),
   CONSTRAINT fk_inv_documentID FOREIGN KEY(DocumentID) REFERENCES ProductDocument(DocumentID)
)

ALTER TABLE ProductDocument
ADD Quantity int NOT NULL DEFAULT 0;

ALTER TABLE ProductInventory
ADD TotalQuantity int NOT NULL DEFAULT 0;

ALTER TABLE Users
ADD CONSTRAINT df_userCompanyID DEFAULT 'COM-001' FOR CID;

ALTER TABLE ProductInventory
ADD CONSTRAINT df_defult_product_type DEFAULT 1 FOR TID;

ALTER TABLE Users
ADD CONSTRAINT df_userID DEFAULT 'USR'+ CONVERT(varchar(10), NEWID()) FOR UID;

EXEC sp_helpconstraint Users;

ALTER TABLE SignIn
ADD CONSTRAINT uq_ip_address UNIQUE(IP);