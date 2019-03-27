
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/27/2019 22:38:49
-- Generated from EDMX file: C:\facultate\an3\sem2\advanced-topics-net\project-3\CarService\CarService\CarServiceModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AUTO];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AutoSasiu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Automobile] DROP CONSTRAINT [FK_AutoSasiu];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientAuto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Automobile] DROP CONSTRAINT [FK_ClientAuto];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientComanda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comenzi] DROP CONSTRAINT [FK_ClientComanda];
GO
IF OBJECT_ID(N'[dbo].[FK_ComandaDetaliuComanda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetaliiComenzi] DROP CONSTRAINT [FK_ComandaDetaliuComanda];
GO
IF OBJECT_ID(N'[dbo].[FK_ImagineDetaliuComanda_DetaliuComanda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ImagineDetaliuComanda] DROP CONSTRAINT [FK_ImagineDetaliuComanda_DetaliuComanda];
GO
IF OBJECT_ID(N'[dbo].[FK_ImagineDetaliuComanda_Imagine]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ImagineDetaliuComanda] DROP CONSTRAINT [FK_ImagineDetaliuComanda_Imagine];
GO
IF OBJECT_ID(N'[dbo].[FK_MaterialDetaliuComanda_DetaliuComanda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MaterialDetaliuComanda] DROP CONSTRAINT [FK_MaterialDetaliuComanda_DetaliuComanda];
GO
IF OBJECT_ID(N'[dbo].[FK_MaterialDetaliuComanda_Material]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MaterialDetaliuComanda] DROP CONSTRAINT [FK_MaterialDetaliuComanda_Material];
GO
IF OBJECT_ID(N'[dbo].[FK_MecanicDetaliuComanda_DetaliuComanda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MecanicDetaliuComanda] DROP CONSTRAINT [FK_MecanicDetaliuComanda_DetaliuComanda];
GO
IF OBJECT_ID(N'[dbo].[FK_MecanicDetaliuComanda_Mecanic]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MecanicDetaliuComanda] DROP CONSTRAINT [FK_MecanicDetaliuComanda_Mecanic];
GO
IF OBJECT_ID(N'[dbo].[FK_OperatieDetaliuComanda_DetaliuComanda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OperatieDetaliuComanda] DROP CONSTRAINT [FK_OperatieDetaliuComanda_DetaliuComanda];
GO
IF OBJECT_ID(N'[dbo].[FK_OperatieDetaliuComanda_Operatie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OperatieDetaliuComanda] DROP CONSTRAINT [FK_OperatieDetaliuComanda_Operatie];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Automobile]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Automobile];
GO
IF OBJECT_ID(N'[dbo].[Clienti]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clienti];
GO
IF OBJECT_ID(N'[dbo].[Comenzi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comenzi];
GO
IF OBJECT_ID(N'[dbo].[DetaliiComenzi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetaliiComenzi];
GO
IF OBJECT_ID(N'[dbo].[ImagineDetaliuComanda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ImagineDetaliuComanda];
GO
IF OBJECT_ID(N'[dbo].[Imagini]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Imagini];
GO
IF OBJECT_ID(N'[dbo].[MaterialDetaliuComanda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MaterialDetaliuComanda];
GO
IF OBJECT_ID(N'[dbo].[Materiale]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Materiale];
GO
IF OBJECT_ID(N'[dbo].[MecanicDetaliuComanda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MecanicDetaliuComanda];
GO
IF OBJECT_ID(N'[dbo].[Mecanici]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Mecanici];
GO
IF OBJECT_ID(N'[dbo].[OperatieDetaliuComanda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OperatieDetaliuComanda];
GO
IF OBJECT_ID(N'[dbo].[Operatii]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Operatii];
GO
IF OBJECT_ID(N'[dbo].[Sasiuri]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sasiuri];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clienti'
CREATE TABLE [dbo].[Clienti] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(15)  NOT NULL,
    [Prenume] nvarchar(15)  NOT NULL,
    [Adresa] nvarchar(50)  NOT NULL,
    [Localitate] nvarchar(10)  NOT NULL,
    [Judet] nvarchar(10)  NOT NULL,
    [Telefon] nvarchar(13)  NOT NULL,
    [Email] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Automobile'
CREATE TABLE [dbo].[Automobile] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NumarAuto] nvarchar(8)  NOT NULL,
    [SerieSasiu] nvarchar(25)  NOT NULL,
    [SasiuId] int  NOT NULL,
    [ClientId] int  NOT NULL
);
GO

-- Creating table 'Sasiuri'
CREATE TABLE [dbo].[Sasiuri] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodSasiu] nchar(2)  NOT NULL,
    [Denumire] nvarchar(25)  NOT NULL
);
GO

-- Creating table 'Mecanici'
CREATE TABLE [dbo].[Mecanici] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(15)  NOT NULL,
    [Prenume] nvarchar(15)  NOT NULL
);
GO

-- Creating table 'Materiale'
CREATE TABLE [dbo].[Materiale] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Denumire] nvarchar(50)  NOT NULL,
    [Cantitate] decimal(10,2)  NOT NULL,
    [Pret] decimal(10,2)  NOT NULL,
    [DataAprovizionare] datetime  NOT NULL
);
GO

-- Creating table 'Imagini'
CREATE TABLE [dbo].[Imagini] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Titlu] nvarchar(15)  NOT NULL,
    [Data] datetime  NOT NULL,
    [Foto] varbinary(max)  NOT NULL,
    [Descriere] nvarchar(256)  NOT NULL
);
GO

-- Creating table 'Operatii'
CREATE TABLE [dbo].[Operatii] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Denumire] nvarchar(256)  NOT NULL,
    [TimpExecutie] decimal(6,2)  NOT NULL
);
GO

-- Creating table 'Comenzi'
CREATE TABLE [dbo].[Comenzi] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DataSystem] datetime  NOT NULL,
    [DataProgramare] datetime  NOT NULL,
    [DataFinalizare] datetime  NOT NULL,
    [KmBord] int  NOT NULL,
    [Descriere] nvarchar(1024)  NOT NULL,
    [ValoarePiese] decimal(10,2)  NOT NULL,
    [StareComanda] tinyint  NOT NULL,
    [AutoId] int  NOT NULL
);
GO

-- Creating table 'DetaliiComenzi'
CREATE TABLE [dbo].[DetaliiComenzi] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ComandaId] int  NOT NULL
);
GO

-- Creating table 'MaterialDetaliuComanda'
CREATE TABLE [dbo].[MaterialDetaliuComanda] (
    [Materiale_Id] int  NOT NULL,
    [DetaliiComenzi_Id] int  NOT NULL
);
GO

-- Creating table 'OperatieDetaliuComanda'
CREATE TABLE [dbo].[OperatieDetaliuComanda] (
    [Operatii_Id] int  NOT NULL,
    [DetaliiComenzi_Id] int  NOT NULL
);
GO

-- Creating table 'ImagineDetaliuComanda'
CREATE TABLE [dbo].[ImagineDetaliuComanda] (
    [Imagini_Id] int  NOT NULL,
    [DetaliiComenzi_Id] int  NOT NULL
);
GO

-- Creating table 'MecanicDetaliuComanda'
CREATE TABLE [dbo].[MecanicDetaliuComanda] (
    [Mecanici_Id] int  NOT NULL,
    [DetaliiComenzi_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Clienti'
ALTER TABLE [dbo].[Clienti]
ADD CONSTRAINT [PK_Clienti]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Automobile'
ALTER TABLE [dbo].[Automobile]
ADD CONSTRAINT [PK_Automobile]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sasiuri'
ALTER TABLE [dbo].[Sasiuri]
ADD CONSTRAINT [PK_Sasiuri]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Mecanici'
ALTER TABLE [dbo].[Mecanici]
ADD CONSTRAINT [PK_Mecanici]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Materiale'
ALTER TABLE [dbo].[Materiale]
ADD CONSTRAINT [PK_Materiale]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Imagini'
ALTER TABLE [dbo].[Imagini]
ADD CONSTRAINT [PK_Imagini]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Operatii'
ALTER TABLE [dbo].[Operatii]
ADD CONSTRAINT [PK_Operatii]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Comenzi'
ALTER TABLE [dbo].[Comenzi]
ADD CONSTRAINT [PK_Comenzi]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DetaliiComenzi'
ALTER TABLE [dbo].[DetaliiComenzi]
ADD CONSTRAINT [PK_DetaliiComenzi]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Materiale_Id], [DetaliiComenzi_Id] in table 'MaterialDetaliuComanda'
ALTER TABLE [dbo].[MaterialDetaliuComanda]
ADD CONSTRAINT [PK_MaterialDetaliuComanda]
    PRIMARY KEY CLUSTERED ([Materiale_Id], [DetaliiComenzi_Id] ASC);
GO

-- Creating primary key on [Operatii_Id], [DetaliiComenzi_Id] in table 'OperatieDetaliuComanda'
ALTER TABLE [dbo].[OperatieDetaliuComanda]
ADD CONSTRAINT [PK_OperatieDetaliuComanda]
    PRIMARY KEY CLUSTERED ([Operatii_Id], [DetaliiComenzi_Id] ASC);
GO

-- Creating primary key on [Imagini_Id], [DetaliiComenzi_Id] in table 'ImagineDetaliuComanda'
ALTER TABLE [dbo].[ImagineDetaliuComanda]
ADD CONSTRAINT [PK_ImagineDetaliuComanda]
    PRIMARY KEY CLUSTERED ([Imagini_Id], [DetaliiComenzi_Id] ASC);
GO

-- Creating primary key on [Mecanici_Id], [DetaliiComenzi_Id] in table 'MecanicDetaliuComanda'
ALTER TABLE [dbo].[MecanicDetaliuComanda]
ADD CONSTRAINT [PK_MecanicDetaliuComanda]
    PRIMARY KEY CLUSTERED ([Mecanici_Id], [DetaliiComenzi_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SasiuId] in table 'Automobile'
ALTER TABLE [dbo].[Automobile]
ADD CONSTRAINT [FK_AutoSasiu]
    FOREIGN KEY ([SasiuId])
    REFERENCES [dbo].[Sasiuri]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AutoSasiu'
CREATE INDEX [IX_FK_AutoSasiu]
ON [dbo].[Automobile]
    ([SasiuId]);
GO

-- Creating foreign key on [ClientId] in table 'Automobile'
ALTER TABLE [dbo].[Automobile]
ADD CONSTRAINT [FK_ClientAuto]
    FOREIGN KEY ([ClientId])
    REFERENCES [dbo].[Clienti]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientAuto'
CREATE INDEX [IX_FK_ClientAuto]
ON [dbo].[Automobile]
    ([ClientId]);
GO

-- Creating foreign key on [Materiale_Id] in table 'MaterialDetaliuComanda'
ALTER TABLE [dbo].[MaterialDetaliuComanda]
ADD CONSTRAINT [FK_MaterialDetaliuComanda_Material]
    FOREIGN KEY ([Materiale_Id])
    REFERENCES [dbo].[Materiale]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [DetaliiComenzi_Id] in table 'MaterialDetaliuComanda'
ALTER TABLE [dbo].[MaterialDetaliuComanda]
ADD CONSTRAINT [FK_MaterialDetaliuComanda_DetaliuComanda]
    FOREIGN KEY ([DetaliiComenzi_Id])
    REFERENCES [dbo].[DetaliiComenzi]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MaterialDetaliuComanda_DetaliuComanda'
CREATE INDEX [IX_FK_MaterialDetaliuComanda_DetaliuComanda]
ON [dbo].[MaterialDetaliuComanda]
    ([DetaliiComenzi_Id]);
GO

-- Creating foreign key on [Operatii_Id] in table 'OperatieDetaliuComanda'
ALTER TABLE [dbo].[OperatieDetaliuComanda]
ADD CONSTRAINT [FK_OperatieDetaliuComanda_Operatie]
    FOREIGN KEY ([Operatii_Id])
    REFERENCES [dbo].[Operatii]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [DetaliiComenzi_Id] in table 'OperatieDetaliuComanda'
ALTER TABLE [dbo].[OperatieDetaliuComanda]
ADD CONSTRAINT [FK_OperatieDetaliuComanda_DetaliuComanda]
    FOREIGN KEY ([DetaliiComenzi_Id])
    REFERENCES [dbo].[DetaliiComenzi]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OperatieDetaliuComanda_DetaliuComanda'
CREATE INDEX [IX_FK_OperatieDetaliuComanda_DetaliuComanda]
ON [dbo].[OperatieDetaliuComanda]
    ([DetaliiComenzi_Id]);
GO

-- Creating foreign key on [Imagini_Id] in table 'ImagineDetaliuComanda'
ALTER TABLE [dbo].[ImagineDetaliuComanda]
ADD CONSTRAINT [FK_ImagineDetaliuComanda_Imagine]
    FOREIGN KEY ([Imagini_Id])
    REFERENCES [dbo].[Imagini]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [DetaliiComenzi_Id] in table 'ImagineDetaliuComanda'
ALTER TABLE [dbo].[ImagineDetaliuComanda]
ADD CONSTRAINT [FK_ImagineDetaliuComanda_DetaliuComanda]
    FOREIGN KEY ([DetaliiComenzi_Id])
    REFERENCES [dbo].[DetaliiComenzi]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ImagineDetaliuComanda_DetaliuComanda'
CREATE INDEX [IX_FK_ImagineDetaliuComanda_DetaliuComanda]
ON [dbo].[ImagineDetaliuComanda]
    ([DetaliiComenzi_Id]);
GO

-- Creating foreign key on [Mecanici_Id] in table 'MecanicDetaliuComanda'
ALTER TABLE [dbo].[MecanicDetaliuComanda]
ADD CONSTRAINT [FK_MecanicDetaliuComanda_Mecanic]
    FOREIGN KEY ([Mecanici_Id])
    REFERENCES [dbo].[Mecanici]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [DetaliiComenzi_Id] in table 'MecanicDetaliuComanda'
ALTER TABLE [dbo].[MecanicDetaliuComanda]
ADD CONSTRAINT [FK_MecanicDetaliuComanda_DetaliuComanda]
    FOREIGN KEY ([DetaliiComenzi_Id])
    REFERENCES [dbo].[DetaliiComenzi]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MecanicDetaliuComanda_DetaliuComanda'
CREATE INDEX [IX_FK_MecanicDetaliuComanda_DetaliuComanda]
ON [dbo].[MecanicDetaliuComanda]
    ([DetaliiComenzi_Id]);
GO

-- Creating foreign key on [ComandaId] in table 'DetaliiComenzi'
ALTER TABLE [dbo].[DetaliiComenzi]
ADD CONSTRAINT [FK_ComandaDetaliuComanda]
    FOREIGN KEY ([ComandaId])
    REFERENCES [dbo].[Comenzi]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComandaDetaliuComanda'
CREATE INDEX [IX_FK_ComandaDetaliuComanda]
ON [dbo].[DetaliiComenzi]
    ([ComandaId]);
GO

-- Creating foreign key on [AutoId] in table 'Comenzi'
ALTER TABLE [dbo].[Comenzi]
ADD CONSTRAINT [FK_AutoComanda]
    FOREIGN KEY ([AutoId])
    REFERENCES [dbo].[Automobile]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AutoComanda'
CREATE INDEX [IX_FK_AutoComanda]
ON [dbo].[Comenzi]
    ([AutoId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------