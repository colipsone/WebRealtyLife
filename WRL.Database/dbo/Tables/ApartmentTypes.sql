CREATE TABLE [dbo].[ApartmentTypes] (
    [Id]        UNIQUEIDENTIFIER NOT NULL,
    [Name]      NVARCHAR (MAX)   NULL,
    [CreatedBy] UNIQUEIDENTIFIER NULL,
    [UpdatedBy] UNIQUEIDENTIFIER NULL,
    [CreatedOn] DATETIME         NULL,
    [UpdatedOn] DATETIME         NULL,
    CONSTRAINT [PK_dbo.ApartmentTypes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

