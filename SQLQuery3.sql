CREATE TABLE [dbo].[BilData] (
    [Bil_ID]      INT          IDENTITY (1, 1) NOT NULL,
    [Navn]    VARCHAR (20) NULL,
    [NrPlade] VARCHAR (20) NULL,
    [Dato]    DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([Bil_ID] ASC)
);

