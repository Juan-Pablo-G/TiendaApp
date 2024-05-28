-- Crear la base de datos
CREATE DATABASE negocio;

-- Usar la base de datos
USE negocio;

-- Crear la tabla Articulo
CREATE TABLE Articulo 
(
    IdPro INT NOT NULL PRIMARY KEY,
    Nombre VARCHAR(40) NOT NULL,
    Categoria VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(50) NOT NULL,
    Cantidad INT NOT NULL,
    Precio INT NOT NULL
);

-- Crear la tabla Clientes
CREATE TABLE Clientes 
(
    Nombre VARCHAR(40) NOT NULL,
    Apellido VARCHAR(40) NOT NULL,
    Email VARCHAR(50) NOT NULL,
    Telefono VARCHAR(40) NOT NULL,
    Cedula VARCHAR(40) NOT NULL,
    Direccion VARCHAR(50) NOT NULL
);

-- Crear la tabla Usuarios
CREATE TABLE Usuarios 
(
    Id INT NOT NULL PRIMARY KEY,
    NombreUsuario VARCHAR(40) NOT NULL,
    Contraseña VARCHAR(40) NOT NULL
);

-- Insertar datos en la tabla Articulo
INSERT INTO Articulo (IdPro, Nombre, Categoria, Descripcion, Cantidad, Precio) VALUES
(1, 'Laptop', 'Electrónica', 'Laptop de alta gama', 10, 1500),
(2, 'Smartphone', 'Electrónica', 'Smartphone de última generación', 20, 800),
(3, 'Teclado', 'Accesorios', 'Teclado mecánico', 50, 100);

-- Insertar datos en la tabla Clientes
INSERT INTO Clientes (Nombre, Apellido, Email, Telefono, Cedula, Direccion) VALUES
('Juan', 'Pérez', 'juan.perez@example.com', '123456789', '1234567890', 'Calle Falsa 123'),
('María', 'González', 'maria.gonzalez@example.com', '987654321', '0987654321', 'Avenida Siempre Viva 456'),
('Carlos', 'López', 'carlos.lopez@example.com', '555555555', '1122334455', 'Boulevard de los Sueños 789');

-- Insertar datos en la tabla Usuarios
INSERT INTO Usuarios (Id, NombreUsuario, Contraseña) VALUES
(1, 'admin', 'admin123'),
(2, 'user1', 'user12345'),
(3, 'user2', 'pass54321');