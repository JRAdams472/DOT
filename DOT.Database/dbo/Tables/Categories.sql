CREATE TABLE [dbo].[Categories] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [Name]            NVARCHAR (100) NOT NULL,
    [Description]     NVARCHAR (MAX) NULL,
    [SortOrder]       INT            DEFAULT ((0)) NULL,
    [IsActive]        BIT            DEFAULT ((1)) NULL,
    [CreatedBy]       NVARCHAR (255) NULL,
    [CreatedDate]     DATETIME2 (7)  DEFAULT (getutcdate()) NOT NULL,
    [LastModifiedBy]  NVARCHAR (255) NULL,
    [LastModifiedDate] DATETIME2 (7) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Name] ASC)
);

