CREATE TABLE [dbo].[Apartments] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [CreatedBy] INT            NOT NULL,
    [UpdatedBy] INT            NOT NULL,
    [CreatedOn] DATETIME       NOT NULL,
    [UpdatedOn] DATETIME       NOT NULL,
    [Address]   NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Apartments] PRIMARY KEY CLUSTERED ([Id] ASC)
);

