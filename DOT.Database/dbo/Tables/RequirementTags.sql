CREATE TABLE [dbo].[RequirementTags] (
    [RequirementId] INT           NOT NULL,
    [TagId]         INT           NOT NULL,
    [CreatedDate]   DATETIME2 (7) DEFAULT (getutcdate()) NOT NULL,
    CONSTRAINT [PK_RequirementTags] PRIMARY KEY CLUSTERED ([RequirementId] ASC, [TagId] ASC),
    CONSTRAINT [FK_RT_Requirement] FOREIGN KEY ([RequirementId]) REFERENCES [dbo].[Requirements] ([Id]),
    CONSTRAINT [FK_RT_Tag] FOREIGN KEY ([TagId]) REFERENCES [dbo].[Tags] ([Id])
);

