CREATE TABLE [dbo].[RequirementsAttachments] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [RequirementId] INT            NOT NULL,
    [FileName]      NVARCHAR (255) NOT NULL,
    [FilePath]      NVARCHAR (500) NOT NULL,
    [FileSize]      INT            NULL,
    [ContentType]   NVARCHAR (100) NULL,
    [UploadedDate]  DATETIME2 (7)  DEFAULT (getutcdate()) NOT NULL,
    [UploadedBy]    INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Attachment_Requirement] FOREIGN KEY ([RequirementId]) REFERENCES [dbo].[Requirements] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Attachment_Requirement]
    ON [dbo].[RequirementsAttachments]([RequirementId] ASC);

