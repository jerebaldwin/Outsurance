CREATE  PROC usp_order_names
AS
    BEGIN

        SELECT  FirstName
        INTO    #TempTable
        FROM    dbo.Detail; 

        INSERT  INTO #TempTable
                SELECT  LastName
                FROM    dbo.Detail; 

        SELECT  FirstName ,
                COUNT(*)
        FROM    #TempTable
        GROUP BY FirstName
        ORDER BY COUNT(*) DESC ,
                FirstName ASC; 

DROP TABLE #TempTable
    END;