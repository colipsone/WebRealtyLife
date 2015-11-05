CREATE TABLE [dbo].[ApartmentOwners] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Name]        NVARCHAR (MAX)   NULL,
    [PhoneNumber] NVARCHAR (MAX)   NULL,
    [ApartmentId] UNIQUEIDENTIFIER NOT NULL,
    [CreatedBy]   UNIQUEIDENTIFIER NULL,
    [UpdatedBy]   UNIQUEIDENTIFIER NULL,
    [CreatedOn]   DATETIME         NULL,
    [UpdatedOn]   DATETIME         NULL,
    CONSTRAINT [PK_dbo.ApartmentOwners] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.ApartmentOwners_dbo.Apartments_ApartmentId] FOREIGN KEY ([ApartmentId]) REFERENCES [dbo].[Apartments] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_ApartmentId]
    ON [dbo].[ApartmentOwners]([ApartmentId] ASC);

