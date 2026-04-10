CREATE TABLE [dbo].[Requirements] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [Title]           NVARCHAR (200) NOT NULL,
    [Description]     NVARCHAR (MAX) NULL,
    [PriorityLevel]   INT            DEFAULT ((0)) NOT NULL,
    [PriorityLabel]   NVARCHAR (50)  NULL,
    [Status]          NVARCHAR (50)  DEFAULT ('Active') NOT NULL,
    [CategoryId]      INT            NULL,
    [Category]        NVARCHAR (100) NULL,
    [AssignedToId]    INT            NULL,
    [AssignedTo]      NVARCHAR (100) NULL,
    [CreatedDate]     DATETIME2 (7)  DEFAULT (getutcdate()) NOT NULL,
    [UpdatedDate]     DATETIME2 (7)  DEFAULT (getutcdate()) NOT NULL,
    [DueDate]         DATETIME2 (7)  NULL,
    [EstimationHours] DECIMAL (8, 2) NULL,
    [ActualHours]     DECIMAL (8, 2) NULL,
    [Version]         INT            DEFAULT ((1)) NULL,
    [IsDeleted]       BIT            DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_Requirements_PriorityStatus]
    ON [dbo].[Requirements]([PriorityLevel] ASC, [Status] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Requirements_Category]
    ON [dbo].[Requirements]([CategoryId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Requirements_DueDate]
    ON [dbo].[Requirements]([DueDate] ASC) WHERE ([IsDeleted]=(0));

