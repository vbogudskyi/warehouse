CREATE DATABASE ProductWarehouse
ON
( 
    NAME = "PWarehouse", 
	FILENAME = "C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ProductWarehouse.mdf",
	SIZE = 10MB,
	MAXSIZE = 100MB,
	FILEGROWTH = 10MB
)
LOG ON
(
   NAME = "PLog",
   FILENAME = "C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ProductWarehouseLog.ldf",
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

