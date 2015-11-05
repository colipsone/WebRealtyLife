CREATE TABLE [dbo].[Regions] (
    [Id]        UNIQUEIDENTIFIER NOT NULL,
    [Name]      NVARCHAR (MAX)   NULL,
    [CityId]    UNIQUEIDENTIFIER NOT NULL,
    [CreatedBy] UNIQUEIDENTIFIER NULL,
    [UpdatedBy] UNIQUEIDENTIFIER NULL,
    [CreatedOn] DATETIME         NULL,
    [UpdatedOn] DATETIME         NULL,
    CONSTRAINT [PK_dbo.Regions] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Regions_dbo.Cities_CityId] FOREIGN KEY ([CityId]) REFERENCES [dbo].[Cities] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_CityId]
    ON [dbo].[Regions]([CityId] ASC);

