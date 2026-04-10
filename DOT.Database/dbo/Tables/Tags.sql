CREATE TABLE [dbo].[Tags] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [Name]            NVARCHAR (50)  NOT NULL,
    [Description]     NVARCHAR (200) NULL,
    [CreatedBy]       NVARCHAR (255) NULL,
    [CreatedDate]     DATETIME2 (7)  DEFAULT (getutcdate()) NOT NULL,
    [LastModifiedBy]  NVARCHAR (255) NULL,
    [LastModifiedDate] DATETIME2 (7) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Name] ASC)
);

