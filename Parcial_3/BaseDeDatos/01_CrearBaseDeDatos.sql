-- =====================================================================
-- Parcial 3 - Punto 3: Login con BCrypt  (MySQL 8 / MySQL Workbench)
-- Script 01: crea la base de datos y sus dos tablas.
-- En Workbench: pega todo y ejecuta con el rayo (Ctrl + Shift + Enter).
-- Se puede ejecutar varias veces: solo crea lo que todavía no existe.
-- =====================================================================

CREATE DATABASE IF NOT EXISTS LoginBCryptDB
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_0900_ai_ci;

USE LoginBCryptDB;

-- ---------------------------------------------------------------------
-- Tabla 1: Usuarios
-- NUNCA se guarda la contraseña, solo su hash BCrypt (siempre 60 caracteres).
-- ---------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS Usuarios
(
    Id             INT          NOT NULL AUTO_INCREMENT,
    NombreUsuario  VARCHAR(50)  NOT NULL,
    NombreCompleto VARCHAR(100) NOT NULL,
    PasswordHash   CHAR(60)     NOT NULL,
    FechaCreacion  DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT PK_Usuarios PRIMARY KEY (Id),
    CONSTRAINT UQ_Usuarios_NombreUsuario UNIQUE (NombreUsuario)
);

-- ---------------------------------------------------------------------
-- Tabla 2: IntentosLogin
-- Guarda TODOS los intentos (exitosos y fallidos), el usuario y la fecha,
-- para un análisis posterior.
--   UsuarioId = NULL cuando escribieron un usuario que no existe.
--   Exitoso: 1 = entró, 0 = falló.
-- ---------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS IntentosLogin
(
    Id                     INT          NOT NULL AUTO_INCREMENT,
    UsuarioId              INT          NULL,
    NombreUsuarioIngresado VARCHAR(50)  NOT NULL,
    Exitoso                BOOLEAN      NOT NULL,
    FechaIntento           DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP,
    Detalle                VARCHAR(100) NULL,
    CONSTRAINT PK_IntentosLogin PRIMARY KEY (Id),
    CONSTRAINT FK_IntentosLogin_Usuarios FOREIGN KEY (UsuarioId) REFERENCES Usuarios (Id),
    INDEX IX_IntentosLogin_FechaIntento (FechaIntento)
);

-- ---------------------------------------------------------------------
-- (Opcional) Usuario de prueba:  admin / Admin123*
-- Este hash lo generó BCrypt.Net-Next desde C# con
-- BCrypt.Net.BCrypt.HashPassword("Admin123*", 11).
-- MySQL NO sabe calcular BCrypt: el hash siempre lo genera el programa.
-- INSERT IGNORE no hace nada si 'admin' ya existe.
-- ---------------------------------------------------------------------
INSERT IGNORE INTO Usuarios (NombreUsuario, NombreCompleto, PasswordHash)
VALUES ('admin', 'Administrador del Sistema',
        '$2a$11$ahVWUzTV88L0jQk0i86A.OkOmIUOw01hgeu7A98bYNeSpl0JEsnhm');

SELECT Id, NombreUsuario, NombreCompleto, PasswordHash, FechaCreacion
FROM Usuarios;
