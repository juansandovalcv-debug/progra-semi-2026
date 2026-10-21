-- ============================================================
-- Script SQL para crear la tabla usuarios_usss009925
-- Base de datos: db_academica.mdf (LocalDB SQL Server)
-- ============================================================

-- Crear la tabla de usuarios
CREATE TABLE usuarios_usss009925 (
    idUsuario   INT IDENTITY(1,1) PRIMARY KEY,
    usuario     VARCHAR(35) NOT NULL,
    clave       VARCHAR(35) NOT NULL,
    nombre      VARCHAR(65) NOT NULL,
    direccion   VARCHAR(85),
    telefono    VARCHAR(9)
);
GO

-- Insertar 3 registros de prueba
INSERT INTO usuarios_usss009925 (usuario, clave, nombre, direccion, telefono)
VALUES ('admin01', 'Admin123', 'Administrador del Sistema', 'Tegucigalpa, Honduras', '99887766');

INSERT INTO usuarios_usss009925 (usuario, clave, nombre, direccion, telefono)
VALUES ('jperez2024', 'Juan1234', 'Juan Alberto Pérez López', 'San Pedro Sula, Cortés', '98765432');

INSERT INTO usuarios_usss009925 (usuario, clave, nombre, direccion, telefono)
VALUES ('mgarcia99', 'Maria567', 'María García Hernández', 'La Ceiba, Atlántida', '33445566');
GO
