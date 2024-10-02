CREATE TABLE [dbo].[rooms] (
    [id]               INT            NOT NULL,
    [roomDescription]  NVARCHAR (MAX) NULL,
    [roomAvailability] BIT            NULL,
    [roomNumber]       NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

