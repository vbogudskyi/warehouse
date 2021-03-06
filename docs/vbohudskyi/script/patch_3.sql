ALTER TABLE SignIn
ALTER COLUMN COOKIE varchar(15) NOT NULL;

ALTER TABLE SignIn
ADD CONSTRAINT uq_cookie UNIQUE(COOKIE); --Msg 2714, Level 16, State 5, Line 1
									--There is already an object named 'uq_cookie' in the database.

EXEC sp_helpconstraint SignIn;

ALTER TABLE SignIn
DROP CONSTRAINT DF__SignIn__COOKIE__36B12243; --Nicolae, please enter your name of cookie default constraint here

ALTER TABLE SignIn
ADD CONSTRAINT df_cookie DEFAULT('USRCOOK:'+SUBSTRING(CAST(NEWID() AS VARCHAR(50)), 1, 6))
FOR COOKIE;

EXEC sp_helpconstraint SignIn;