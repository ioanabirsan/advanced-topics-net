
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/19/2019 15:58:08
-- Generated from EDMX file: C:\facultate\an3\sem2\advanced-topics-net\project-2\CarServiceProject\CarServiceProject\CarServiceModel.edmx
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


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
    [Prenume] nvarchar(15)  NOT NULL,
    [DetaliuComandaId] int  NOT NULL
);
GO

-- Creating table 'Materiale'
CREATE TABLE [dbo].[Materiale] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Denumire] nvarchar(50)  NOT NULL,
    [Cantitate] decimal(10,2)  NOT NULL,
    [Pret] decimal(10,2)  NOT NULL,
    [DataAprovizionare] datetime  NOT NULL,
    [DetaliuComanda_Id] int  NOT NULL
);
GO

-- Creating table 'Imagini'
CREATE TABLE [dbo].[Imagini] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Titlu] nvarchar(15)  NOT NULL,
    [Data] datetime  NOT NULL,
    [Foto] tinyint  NOT NULL,
    [DetaliuComandaId] int  NOT NULL
);
GO

-- Creating table 'Operatii'
CREATE TABLE [dbo].[Operatii] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Denumire] nvarchar(256)  NOT NULL,
    [TimpExecutie] decimal(6,2)  NOT NULL,
    [DetaliuComandaId] int  NOT NULL
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
    [AutoId] int  NOT NULL,
    [ClientId] int  NOT NULL,
    [DetaliuComanda_Id] int  NOT NULL
);
GO

-- Creating table 'DetaliiComenzi'
CREATE TABLE [dbo].[DetaliiComenzi] (
    [Id] int IDENTITY(1,1) NOT NULL
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

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SasiuId] in table 'Automobile'
ALTER TABLE [dbo].[Automobile]
ADD CONSTRAINT [FK_AutoSasiu]
    FOREIGN KEY ([SasiuId])
    REFERENCES [dbo].[Sasiuri]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
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
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientAuto'
CREATE INDEX [IX_FK_ClientAuto]
ON [dbo].[Automobile]
    ([ClientId]);
GO

-- Creating foreign key on [AutoId] in table 'Comenzi'
ALTER TABLE [dbo].[Comenzi]
ADD CONSTRAINT [FK_AutoComanda]
    FOREIGN KEY ([AutoId])
    REFERENCES [dbo].[Automobile]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AutoComanda'
CREATE INDEX [IX_FK_AutoComanda]
ON [dbo].[Comenzi]
    ([AutoId]);
GO

-- Creating foreign key on [ClientId] in table 'Comenzi'
ALTER TABLE [dbo].[Comenzi]
ADD CONSTRAINT [FK_ClientComanda]
    FOREIGN KEY ([ClientId])
    REFERENCES [dbo].[Clienti]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientComanda'
CREATE INDEX [IX_FK_ClientComanda]
ON [dbo].[Comenzi]
    ([ClientId]);
GO

-- Creating foreign key on [DetaliuComandaId] in table 'Imagini'
ALTER TABLE [dbo].[Imagini]
ADD CONSTRAINT [FK_ImagineDetaliuComanda]
    FOREIGN KEY ([DetaliuComandaId])
    REFERENCES [dbo].[DetaliiComenzi]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ImagineDetaliuComanda'
CREATE INDEX [IX_FK_ImagineDetaliuComanda]
ON [dbo].[Imagini]
    ([DetaliuComandaId]);
GO

-- Creating foreign key on [DetaliuComandaId] in table 'Operatii'
ALTER TABLE [dbo].[Operatii]
ADD CONSTRAINT [FK_OperatieDetaliuComanda]
    FOREIGN KEY ([DetaliuComandaId])
    REFERENCES [dbo].[DetaliiComenzi]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OperatieDetaliuComanda'
CREATE INDEX [IX_FK_OperatieDetaliuComanda]
ON [dbo].[Operatii]
    ([DetaliuComandaId]);
GO

-- Creating foreign key on [DetaliuComanda_Id] in table 'Materiale'
ALTER TABLE [dbo].[Materiale]
ADD CONSTRAINT [FK_MaterialDetaliuComanda]
    FOREIGN KEY ([DetaliuComanda_Id])
    REFERENCES [dbo].[DetaliiComenzi]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MaterialDetaliuComanda'
CREATE INDEX [IX_FK_MaterialDetaliuComanda]
ON [dbo].[Materiale]
    ([DetaliuComanda_Id]);
GO

-- Creating foreign key on [DetaliuComandaId] in table 'Mecanici'
ALTER TABLE [dbo].[Mecanici]
ADD CONSTRAINT [FK_MecanicDetaliuComanda]
    FOREIGN KEY ([DetaliuComandaId])
    REFERENCES [dbo].[DetaliiComenzi]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MecanicDetaliuComanda'
CREATE INDEX [IX_FK_MecanicDetaliuComanda]
ON [dbo].[Mecanici]
    ([DetaliuComandaId]);
GO

-- Creating foreign key on [DetaliuComanda_Id] in table 'Comenzi'
ALTER TABLE [dbo].[Comenzi]
ADD CONSTRAINT [FK_ComandaDetaliuComanda]
    FOREIGN KEY ([DetaliuComanda_Id])
    REFERENCES [dbo].[DetaliiComenzi]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComandaDetaliuComanda'
CREATE INDEX [IX_FK_ComandaDetaliuComanda]
ON [dbo].[Comenzi]
    ([DetaliuComanda_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------