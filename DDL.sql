--Comentario de una linea

/*Comentario
de varias
lineas*/

/*DDL: Data Definition Language, son las instrucciones del lenguaje SQL
que se usan para la manipulacion de objetos de datos. Las instrucciones
mas usadas de DDL son: CREATE, ALTER, DROP, TRUNCATE*/

--Crear una base de datos
CREATE DATABASE Gerardo
GO
--Para instrucciones DDL se recomienda colocar GO luego de cada
--instrucciones; esto para evitar que se ejecuten las siguientes instrucciones
--sin antes haber terminado de ejecutar la anterior.

--borrar una base de datos (peligroso e irreversible)
--se recomienda reiniciar el servidor de base de datos antes de borrar una BD
--y avisar a los usuarios que no entren a la base de datos.

--lo primer que se hace es pasarse a la base de datos master:
USE master
GO
DROP DATABASE Gerardo
GO
--si la base de datos está en uso no se va a poder borrar

--Crear una tabla en la base de datos
--primer debe pasarse a la base de datos donde va a crear la tabla:
USE Gerardo
GO
CREATE TABLE Producto(
	ProductoID bigint NOT NULL IDENTITY(1,1), --aumentar de 1 en 1 iniciando en 1
	Codigo VARCHAR(30) NOT NULL,
	Nombre VARCHAR(200) NOT NULL,
	Costo DECIMAL(12,2) NOT NULL,
	PrecioVenta DECIMAL(12,2) NOT NULL,
	Existencias int NOT NULL,
	Comentarios TEXT NULL,
	PRIMARY KEY(ProductoID) --define que columna va a hacer unico a cada registro (llave primaria)
)
GO

--borrar una tabla (destruye la tabla con sus datos aunque esté en uso)
--selecciona la BD donde esta la tabla
Use Gerardo
GO
--ejecutar el borrado
DROP TABLE Producto
GO

--vaciar una tabla (borrarle sus datos sin destruirla y resetear el campo Identity o autonumerico)
Use Gerardo
GO
TRUNCATE TABLE Producto
GO

--Agregar una columna a una tabla existente
--ejemplo: agregue una columna llamada Color a la tabla Producto, esta sera VARCHAR(20) y si admite nulos
USE Gerardo
GO
ALTER TABLE Producto
ADD Color VARCHAR(20) NULL

--Borrar una columna de una tabla existente
USE Gerardo
GO
ALTER TABLE Producto
DROP COLUMN Color
GO

--Cambiar el tamaño a una columna existente sin borrar sus datos
USE Gerardo
GO
ALTER TABLE Producto
ALTER COLUMN Nombre VARCHAR(255) NOT NULL
GO
