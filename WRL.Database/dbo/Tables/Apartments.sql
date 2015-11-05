CREATE TABLE [dbo].[Apartments] (
    [Id]              UNIQUEIDENTIFIER NOT NULL,
    [FloorNumber]     INT              NOT NULL,
    [FloorsAmount]    INT              NOT NULL,
    [Square]          INT              NOT NULL,
    [HouseNumber]     NVARCHAR (MAX)   NULL,
    [RoomsNumber]     INT              NOT NULL,
    [Price]           NVARCHAR (MAX)   NULL,
    [Note]            NVARCHAR (MAX)   NULL,
    [StreetId]        UNIQUEIDENTIFIER NOT NULL,
    [ApartmentTypeId] UNIQUEIDENTIFIER NULL,
    [SubwayStationId] UNIQUEIDENTIFIER NULL,
    [CreatedBy]       UNIQUEIDENTIFIER NULL,
    [UpdatedBy]       UNIQUEIDENTIFIER NULL,
    [CreatedOn]       DATETIME         NULL,
    [UpdatedOn]       DATETIME         NULL,
    CONSTRAINT [PK_dbo.Apartments] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Apartments_dbo.ApartmentTypes_ApartmentTypeId] FOREIGN KEY ([ApartmentTypeId]) REFERENCES [dbo].[ApartmentTypes] ([Id]),
    CONSTRAINT [FK_dbo.Apartments_dbo.Streets_StreetId] FOREIGN KEY ([StreetId]) REFERENCES [dbo].[Streets] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.Apartments_dbo.SubwayStations_SubwayStationId] FOREIGN KEY ([SubwayStationId]) REFERENCES [dbo].[SubwayStations] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_StreetId]
    ON [dbo].[Apartments]([StreetId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_ApartmentTypeId]
    ON [dbo].[Apartments]([ApartmentTypeId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_SubwayStationId]
    ON [dbo].[Apartments]([SubwayStationId] ASC);

