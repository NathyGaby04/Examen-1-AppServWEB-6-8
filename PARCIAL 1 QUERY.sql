CREATE DATABASE [DB_vehiculos_itm];
GO


USE [DB_vehiculos_itm];
GO

CREATE TABLE [Agencia] (
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Nombre] NVARCHAR(255) NOT NULL,
	[Direccion] NVARCHAR(255) NOT NULL,
	CONSTRAINT [Pk_Agencia] PRIMARY KEY CLUSTERED ([Id])
);
GO

CREATE TABLE [Cliente] (
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Cedula] INT NOT NULL,
	[Nombre] NVARCHAR(255) NOT NULL,
	[Apellido] NVARCHAR(255) NOT NULL,
	[Fecha_Nacimiento] DATETIME NOT NULL,
	[Direccion] NVARCHAR(50) NOT NULL,
	[Celular] NVARCHAR(20) NOT NULL,
	[Correo] NVARCHAR(70) NOT NULL,
	CONSTRAINT [Pk_Cliente] PRIMARY KEY CLUSTERED ([Id])
);
GO

CREATE TABLE [Marca] (
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Nombre] NVARCHAR(100) NOT NULL,
	CONSTRAINT [Pk_Marca] PRIMARY KEY CLUSTERED ([Id])
);
GO

CREATE TABLE [Vehiculo] (
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Nombre] NVARCHAR(100) NOT NULL,
	[Motor] NVARCHAR(150) NOT NULL,
	[Num_Puertas] INT NOT NULL,
	[Tipo_Combustible] NVARCHAR(50) NOT NULL,
	[Marca] INT NOT NULL,
	[Accesorios] NVARCHAR(500) NOT NULL,
	CONSTRAINT [Pk_Vehiculo] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_Vehiculo_Marca] FOREIGN KEY ([Marca]) REFERENCES [Marca] ([Id]),
);
GO


CREATE TABLE [Venta] (
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Fecha_venta] DATETIME NOT NULL DEFAULT GETDATE(),
	[Agencia] INT NOT NULL,
	[Cliente] INT NOT NULL,
	[Vehiculo] INT NOT NULL,
	[Valor] DECIMAL(30,2) NOT NULL,
	CONSTRAINT [Pk_Venta] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_Venta_Agencia] FOREIGN KEY ([Agencia]) REFERENCES [Agencia] ([Id]),
	CONSTRAINT [FK_Venta_Cliente] FOREIGN KEY ([Cliente]) REFERENCES [Cliente] ([Id]),
	CONSTRAINT [FK_Venta_Vehiculo] FOREIGN KEY ([Vehiculo]) REFERENCES [Vehiculo] ([Id]),
);
GO

INSERT INTO [Marca] ([Nombre])
VALUES ('Porsche'),('Toyota'),('Mercedes'),('Chevrolet');
GO
