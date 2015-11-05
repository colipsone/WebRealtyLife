CREATE TABLE [dbo].[Cities] (
    [Id]        UNIQUEIDENTIFIER NOT NULL,
    [Name]      NVARCHAR (MAX)   NULL,
    [CreatedBy] UNIQUEIDENTIFIER NULL,
    [UpdatedBy] UNIQUEIDENTIFIER NULL,
    [CreatedOn] DATETIME         NULL,
    [UpdatedOn] DATETIME         NULL,
    CONSTRAINT [PK_dbo.Cities] PRIMARY KEY CLUSTERED ([Id] ASC)
);

