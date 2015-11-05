CREATE TABLE [dbo].[SubwayStations] (
    [Id]        UNIQUEIDENTIFIER NOT NULL,
    [Name]      NVARCHAR (MAX)   NULL,
    [RegionId]  UNIQUEIDENTIFIER NOT NULL,
    [CreatedBy] UNIQUEIDENTIFIER NULL,
    [UpdatedBy] UNIQUEIDENTIFIER NULL,
    [CreatedOn] DATETIME         NULL,
    [UpdatedOn] DATETIME         NULL,
    CONSTRAINT [PK_dbo.SubwayStations] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.SubwayStations_dbo.Regions_RegionId] FOREIGN KEY ([RegionId]) REFERENCES [dbo].[Regions] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_RegionId]
    ON [dbo].[SubwayStations]([RegionId] ASC);

