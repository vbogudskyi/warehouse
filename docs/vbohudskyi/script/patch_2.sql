ALTER TABLE ProductInventory
ADD Name VARCHAR(25) NOT NULL UNIQUE;

ALTER TABLE ProductDocument
ADD Description VARCHAR(100);

ALTER TABLE ProductInventory
DROP COLUMN Description;

ALTER TABLE ProductDocument
ADD CreationDate SMALLDATETIME DEFAULT GETDATE();

EXEC sp_helpconstraint Company;

ALTER TABLE Company
ADD CONSTRAINT df_company_id DEFAULT ('COM-'+CONVERT(VARCHAR(10), NEWID())) FOR CID;

ALTER TABLE ProductDocument
ADD CONSTRAINT df_document_id DEFAULT ('DOC-'+CONVERT(VARCHAR(10), NEWID())) FOR DocumentID;

ALTER TABLE ProductInventory
ADD CONSTRAINT df_product_id DEFAULT ('PROD'+CONVERT(VARCHAR(5), NEWID())) FOR PrID;

ALTER TABLE Users
ADD Telephone varchar(15);

ALTER TABLE Users 
WITH CHECK ADD 
CONSTRAINT ck_login_email
CHECK
(
	CHARINDEX(' ',LTRIM(RTRIM(LOGIN))) = 0 
AND 	LEFT(LTRIM(LOGIN),1) <> '@' 
AND 	RIGHT(RTRIM(LOGIN),1) <> '.' 
AND 	CHARINDEX('.',LOGIN,CHARINDEX('@',LOGIN)) - CHARINDEX('@',LOGIN) > 1 
AND 	LEN(LTRIM(RTRIM(LOGIN))) - LEN(REPLACE(LTRIM(RTRIM(LOGIN)),'@','')) = 1
AND 	CHARINDEX('.',REVERSE(LTRIM(RTRIM(LOGIN)))) >= 3 
AND 	(CHARINDEX('.@',LOGIN) = 0 AND CHARINDEX('..',LOGIN) = 0) 
);

INSERT INTO ROLE VALUES('Employee');

EXEC sp_helpconstraint Users;

ALTER TABLE Users
DROP CONSTRAINT DF__Users__RID__5441852A; --Nicolae, enter your RID default constraint name here

ALTER TABLE Users
ADD CONSTRAINT df_role_id DEFAULT 2 FOR RID;


