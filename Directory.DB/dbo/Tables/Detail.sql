CREATE TABLE [dbo].[Detail] (
    [id]          INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]   NVARCHAR (50)  NOT NULL,
    [LastName]    NVARCHAR (50)  NOT NULL,
    [Address]     NVARCHAR (250) NOT NULL,
    [PhoneNumber] NVARCHAR (50)  NOT NULL
);

