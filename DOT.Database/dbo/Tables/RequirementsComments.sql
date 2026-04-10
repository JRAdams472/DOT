CREATE TABLE [dbo].[RequirementsComments] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [RequirementId]    INT            NOT NULL,
    [UserId]          INT            NULL,
    [Comment]         NVARCHAR (MAX) NOT NULL,
    [CreatedBy]       NVARCHAR (255) NULL,
    [CreatedDate]     DATETIME2 (7)  DEFAULT (getutcdate()) NOT NULL,
    [LastModifiedBy]  NVARCHAR (255) NULL,
    [LastModifiedDate] DATETIME2 (7) NULL,
    [IsDeleted]       BIT            DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Comments_Requirement] FOREIGN KEY ([RequirementId]) REFERENCES [dbo].[Requirements] ([Id]),
    CONSTRAINT [FK_Comments_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Comments_Requirement]
    ON [dbo].[RequirementsComments]([RequirementId] ASC);

