
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/28/2019 22:04:26
-- Generated from EDMX file: D:\My_Project\ExtendClassLibrary\DataAccessLibrary\Model\DataEF.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Aoi];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CentralConfigHostContext]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HostContextSet] DROP CONSTRAINT [FK_CentralConfigHostContext];
GO
IF OBJECT_ID(N'[dbo].[FK_SolutionProject]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Projects] DROP CONSTRAINT [FK_SolutionProject];
GO
IF OBJECT_ID(N'[dbo].[FK_SolutionDataBase]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DataBases] DROP CONSTRAINT [FK_SolutionDataBase];
GO
IF OBJECT_ID(N'[dbo].[FK_PlcPlcList]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PlcLists] DROP CONSTRAINT [FK_PlcPlcList];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectProjectList]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectLists] DROP CONSTRAINT [FK_ProjectProjectList];
GO
IF OBJECT_ID(N'[dbo].[FK_DataBaseDataBaseList]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DataBaseLists] DROP CONSTRAINT [FK_DataBaseDataBaseList];
GO
IF OBJECT_ID(N'[dbo].[FK_SolutionPlc]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Plcs] DROP CONSTRAINT [FK_SolutionPlc];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CentralConfigSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CentralConfigSet];
GO
IF OBJECT_ID(N'[dbo].[HostContextSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HostContextSet];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Solutions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Solutions];
GO
IF OBJECT_ID(N'[dbo].[Plcs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Plcs];
GO
IF OBJECT_ID(N'[dbo].[Projects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Projects];
GO
IF OBJECT_ID(N'[dbo].[DataBases]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DataBases];
GO
IF OBJECT_ID(N'[dbo].[PlcLists]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PlcLists];
GO
IF OBJECT_ID(N'[dbo].[ProjectLists]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjectLists];
GO
IF OBJECT_ID(N'[dbo].[DataBaseLists]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DataBaseLists];
GO
IF OBJECT_ID(N'[dbo].[OptionTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OptionTypes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CentralConfigSet'
CREATE TABLE [dbo].[CentralConfigSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Host] nchar(4000)  NOT NULL,
    [ProjectName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HostContextSet'
CREATE TABLE [dbo].[HostContextSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CentralConfigId] int  NOT NULL,
    [ModelId] smallint  NOT NULL,
    [ModelType] nvarchar(max)  NOT NULL,
    [ModelParameter] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [IsAdmin] bit  NOT NULL
);
GO

-- Creating table 'Solutions'
CREATE TABLE [dbo].[Solutions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Plcs'
CREATE TABLE [dbo].[Plcs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SolutionId] int  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Projects'
CREATE TABLE [dbo].[Projects] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SolutionId] int  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DataBases'
CREATE TABLE [dbo].[DataBases] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SolutionId] int  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PlcLists'
CREATE TABLE [dbo].[PlcLists] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PlcId] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Paras] nvarchar(max)  NOT NULL,
    [Component] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProjectLists'
CREATE TABLE [dbo].[ProjectLists] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProjectId] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Paras] nvarchar(max)  NOT NULL,
    [Component] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DataBaseLists'
CREATE TABLE [dbo].[DataBaseLists] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DataBaseId] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Paras] nvarchar(max)  NOT NULL,
    [Component] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'OptionTypes'
CREATE TABLE [dbo].[OptionTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CentralConfigSet'
ALTER TABLE [dbo].[CentralConfigSet]
ADD CONSTRAINT [PK_CentralConfigSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HostContextSet'
ALTER TABLE [dbo].[HostContextSet]
ADD CONSTRAINT [PK_HostContextSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Solutions'
ALTER TABLE [dbo].[Solutions]
ADD CONSTRAINT [PK_Solutions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Plcs'
ALTER TABLE [dbo].[Plcs]
ADD CONSTRAINT [PK_Plcs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Projects'
ALTER TABLE [dbo].[Projects]
ADD CONSTRAINT [PK_Projects]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DataBases'
ALTER TABLE [dbo].[DataBases]
ADD CONSTRAINT [PK_DataBases]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PlcLists'
ALTER TABLE [dbo].[PlcLists]
ADD CONSTRAINT [PK_PlcLists]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProjectLists'
ALTER TABLE [dbo].[ProjectLists]
ADD CONSTRAINT [PK_ProjectLists]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DataBaseLists'
ALTER TABLE [dbo].[DataBaseLists]
ADD CONSTRAINT [PK_DataBaseLists]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OptionTypes'
ALTER TABLE [dbo].[OptionTypes]
ADD CONSTRAINT [PK_OptionTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CentralConfigId] in table 'HostContextSet'
ALTER TABLE [dbo].[HostContextSet]
ADD CONSTRAINT [FK_CentralConfigHostContext]
    FOREIGN KEY ([CentralConfigId])
    REFERENCES [dbo].[CentralConfigSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CentralConfigHostContext'
CREATE INDEX [IX_FK_CentralConfigHostContext]
ON [dbo].[HostContextSet]
    ([CentralConfigId]);
GO

-- Creating foreign key on [SolutionId] in table 'Projects'
ALTER TABLE [dbo].[Projects]
ADD CONSTRAINT [FK_SolutionProject]
    FOREIGN KEY ([SolutionId])
    REFERENCES [dbo].[Solutions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SolutionProject'
CREATE INDEX [IX_FK_SolutionProject]
ON [dbo].[Projects]
    ([SolutionId]);
GO

-- Creating foreign key on [SolutionId] in table 'DataBases'
ALTER TABLE [dbo].[DataBases]
ADD CONSTRAINT [FK_SolutionDataBase]
    FOREIGN KEY ([SolutionId])
    REFERENCES [dbo].[Solutions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SolutionDataBase'
CREATE INDEX [IX_FK_SolutionDataBase]
ON [dbo].[DataBases]
    ([SolutionId]);
GO

-- Creating foreign key on [PlcId] in table 'PlcLists'
ALTER TABLE [dbo].[PlcLists]
ADD CONSTRAINT [FK_PlcPlcList]
    FOREIGN KEY ([PlcId])
    REFERENCES [dbo].[Plcs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlcPlcList'
CREATE INDEX [IX_FK_PlcPlcList]
ON [dbo].[PlcLists]
    ([PlcId]);
GO

-- Creating foreign key on [ProjectId] in table 'ProjectLists'
ALTER TABLE [dbo].[ProjectLists]
ADD CONSTRAINT [FK_ProjectProjectList]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Projects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectProjectList'
CREATE INDEX [IX_FK_ProjectProjectList]
ON [dbo].[ProjectLists]
    ([ProjectId]);
GO

-- Creating foreign key on [DataBaseId] in table 'DataBaseLists'
ALTER TABLE [dbo].[DataBaseLists]
ADD CONSTRAINT [FK_DataBaseDataBaseList]
    FOREIGN KEY ([DataBaseId])
    REFERENCES [dbo].[DataBases]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DataBaseDataBaseList'
CREATE INDEX [IX_FK_DataBaseDataBaseList]
ON [dbo].[DataBaseLists]
    ([DataBaseId]);
GO

-- Creating foreign key on [SolutionId] in table 'Plcs'
ALTER TABLE [dbo].[Plcs]
ADD CONSTRAINT [FK_SolutionPlc]
    FOREIGN KEY ([SolutionId])
    REFERENCES [dbo].[Solutions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SolutionPlc'
CREATE INDEX [IX_FK_SolutionPlc]
ON [dbo].[Plcs]
    ([SolutionId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------