CREATE TABLE [dbo].[Users] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Email]       NVARCHAR (255) NOT NULL,
    [FirstName]   NVARCHAR (100) NULL,
    [LastName]    NVARCHAR (100) NULL,
    [FullName]    NVARCHAR (200) NOT NULL,
    [IsActive]    BIT            DEFAULT ((1)) NULL,
    [CreatedDate] DATETIME2 (7)  DEFAULT (getutcdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Email] ASC)
);

