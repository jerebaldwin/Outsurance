CREATE PROC usp_insert_record
    @first_name NVARCHAR(50) ,
    @last_name NVARCHAR(50) ,
    @address NVARCHAR(250) ,
    @phone_number NVARCHAR(50)
AS
    BEGIN


        INSERT  dbo.Detail
                ( FirstName ,
                  LastName ,
                  Address ,
                  PhoneNumber
                )
        VALUES  ( @first_name , -- FirstName - nvarchar(50)
                  @last_name , -- LastName - nvarchar(50)
                  @address , -- Address - nvarchar(250)
                  @phone_number  -- PhoneNumber - nvarchar(50)
                );

        SELECT  SCOPE_IDENTITY() AS [inserset];

    END;