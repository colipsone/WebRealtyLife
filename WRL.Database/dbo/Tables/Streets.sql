CREATE TABLE [dbo].[Streets] (
    [Id]        UNIQUEIDENTIFIER NOT NULL,
    [Name]      NVARCHAR (MAX)   NULL,
    [RegionId]  UNIQUEIDENTIFIER NOT NULL,
    [CreatedBy] UNIQUEIDENTIFIER NULL,
    [UpdatedBy] UNIQUEIDENTIFIER NULL,
    [CreatedOn] DATETIME         NULL,
    [UpdatedOn] DATETIME         NULL,
    CONSTRAINT [PK_dbo.Streets] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Streets_dbo.Regions_RegionId] FOREIGN KEY ([RegionId]) REFERENCES [dbo].[Regions] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_RegionId]
    ON [dbo].[Streets]([RegionId] ASC);

