CREATE PROC usp_clear_records
AS
    BEGIN


        TRUNCATE TABLE dbo.Detail;

    END;