ALTER TABLE SignIn
ALTER COLUMN COOKIE varchar(15) NOT NULL;

ALTER TABLE SignIn
ADD CONSTRAINT uq_cookie UNIQUE(COOKIE);

EXEC sp_helpconstraint SignIn;

ALTER TABLE SignIn
DROP CONSTRAINT DF__SignIn__COOKIE__5CD6CB2B; --Nicolae, please enter your name of cookie default constraint here

ALTER TABLE SignIn
ADD CONSTRAINT df_cookie DEFAULT('USRCOOK:'+SUBSTRING(CAST(NEWID() AS VARCHAR(50)), 1, 6))
FOR COOKIE;

EXEC sp_helpconstraint SignIn;