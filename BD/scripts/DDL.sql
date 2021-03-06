CREATE DATABASE BLOCKTIME
GO

USE BLOCKTIME 
GO

CREATE TABLE TIPOUSUARIO (
	id SMALLINT PRIMARY KEY IDENTITY,
	titulo VARCHAR(70) NOT NULL UNIQUE
)
GO

CREATE TABLE USUARIO (
	id INT PRIMARY KEY IDENTITY,
	idTipoUsuario SMALLINT FOREIGN KEY REFERENCES TIPOUSUARIO (id),
	nome VARCHAR(50),
	email VARCHAR(255) NOT NULL UNIQUE,
	senha VARCHAR(200) NOT NULL
)
GO

CREATE TABLE TIPOCHAVE (
	id SMALLINT PRIMARY KEY IDENTITY,
	titulo VARCHAR(100) NOT NULL
)
GO

CREATE TABLE CLIENTE (
	id INT PRIMARY KEY IDENTITY,
	nome VARCHAR(100) NOT NULL,
	descricao VARCHAR(255)
)
GO

CREATE TABLE TELEFONE (
	id INT PRIMARY KEY IDENTITY,
	idCliente  INT FOREIGN KEY REFERENCES CLIENTE (id),
	telefone VARCHAR(40) NOT NULL
)
GO

CREATE TABLE EMAIL (
	id INT PRIMARY KEY IDENTITY,
	idCliente INT FOREIGN KEY REFERENCES CLIENTE (id),
	email VARCHAR(255) NOT NULL 
)
GO


/* CHAVE ACESSO */

CREATE TABLE CHAVEACESSO (
	id INT PRIMARY KEY IDENTITY,
	idTipoChave SMALLINT FOREIGN KEY REFERENCES TIPOCHAVE(id),
	idCliente INT FOREIGN KEY REFERENCES CLIENTE (id),
	usuario VARCHAR(255) NOT NULL,
	senha VARCHAR(255) NOT NULL
)
GO

CREATE TABLE usuarioZabbix (
	id INT PRIMARY KEY IDENTITY,
	idUsuario INT FOREIGN KEY REFERENCES USUARIO (id),
	usuario VARCHAR(60) NOT NULL,
	senha VARCHAR(100) NOT NULL
)
GO