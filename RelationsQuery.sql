CREATE TABLE [dbo].[RelationsTabel] (
    [Chauffør_ID] INT          NOT NULL,
    [Rute_Nummer] VARCHAR (50) NULL,
    [Person_ID]   INT          NULL,
    [Bil_ID]      INT          NULL,
    [Log_ID]      INT          NULL,
    PRIMARY KEY CLUSTERED ([Chauffør_ID] ASC),
    FOREIGN KEY ([Person_ID]) REFERENCES [dbo].[stamdata] ([Person_ID]),
    FOREIGN KEY ([Bil_ID]) REFERENCES [dbo].[BilData] ([Bil_ID]),
    FOREIGN KEY ([Log_ID]) REFERENCES [dbo].[LogData] ([Log_ID])
);

