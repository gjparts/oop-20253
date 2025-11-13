/*DML: Data Manipulation Language
Lenguaje de manipulación de datos: son las instrucciones
que le permiten interacturas con los datos almacenados
en las diferentes tablas de la base de datos.
Las instrucciones DML mas utilizadas son:
SELECT, INSERT, DELETE, UPDATE.

-> Las instrucciones DML no requiere de colocar GO despues de cada una.*/

--siempre es importante seleccionar la base de datos antes de comenzar
USE Gerardo
GO

--Instruccion INSERT
/*agrega uno o mas registros a una tabla.
1) en INSERT se debe incluir todos los campos/columnas que sean NOT NULL (obligatorios)
2) Los campos NULL son opcionales Usted decide si los incluye o no en INSERT
3) La columna IDENTITY no se incluye en INSERT porque esta es autonumerada por la base de datos*/

--INSERT que llena todos los campos de la tabla Producto:
INSERT Producto(Codigo, Nombre, Costo, PrecioVenta, Existencias, Comentarios)
VALUES('CC01','Coca Cola 3L',62,70,0,'Mala para la salud')

--INSERT no necesita que pongamos los campos en el orden que estan en la tabla
INSERT Producto(Costo, Codigo, PrecioVenta, Nombre, Comentarios, Existencias)
VALUES (61,'CC02',70,'Mirinda Naranja 3L','Tambien es mala para la salud',15)

--INSERT sin incluir campos opcionales (lo que son NULL)
INSERT Producto(Codigo, Nombre, Costo, PrecioVenta, Existencias)
VALUES('CC03','Sprite 2L',40,50,100)

--INSERT multiregistro:
INSERT Producto(Codigo, Nombre, Costo, PrecioVenta, Existencias, Comentarios)
VALUES
( 'FRU1','Manzana Unidad',7,8.9,200,'Bueno para la salud' ),
( 'FRU2','Pera Unidad',5.25,9,45,'Buena para la salud' ),
( 'VER1','Lechuga Unidad',15,23.8,67,'Muy buena para la salud' ),
( 'CH01','Doritos Queso',17,36,70,NULL ),
( 'CH02','Taqueritos',16,28,50,NULL ),
( 'AGUA','Agua en bolsa',2,3,1500,'Lo mas recomendado para beber' )

--SELECT: consulta la informacion de una o varias tablas. Su resultado depende de las clausulas
--que le coloquemos.
--Consulta todos los registros y todas las columnas de la tabla Producto
SELECT * FROM Producto

/*Importante: usar * en SELECT cuando ya se entra a un ambiente profesional es una mala practica.
ya que se recomienda colocar los nombres de las columnas a consultar.
El usar SELECT * le pone mas trabajo al DMBS ya que lo obliga a ir a consultar a las bases de datos de sistema
que columnas hay en la tabla y de que tipo.*/
--lo mas recomendado en un producto final es nombrar las columnas que desea proyectar en su consulta:
SELECT ProductoID, Codigo, Nombre, Costo, PrecioVenta, Existencias, Comentarios FROM Producto

--Mostrar algunas columnas de Producto
SELECT Codigo, Nombre, PrecioVenta FROM Producto

--Mostrar solo el producto cuyo codigo sea FRU2
SELECT ProductoID, Codigo, Nombre, Costo, PrecioVenta, Existencias, Comentarios
FROM Producto
WHERE Codigo = 'FRU2'

--Mostrar solo el producto cuyo ProductoID sea 4
SELECT ProductoID, Codigo, Nombre, Costo, PrecioVenta, Existencias, Comentarios
FROM Producto
WHERE ProductoID = 4

--Productos cuyos codigos sean CC02, VER1, CH02
SELECT ProductoID, Codigo, Nombre, Costo, PrecioVenta, Existencias, Comentarios
FROM Producto
WHERE Codigo IN ('CC02','VER1','CH02')
--se usa IN para hacer una lista de seleccion dentro de WHERE

--IN tambien soporta otros tipos de dato
--Productos cuyo ProductoID sea 5,1,3,8,100
SELECT ProductoID, Codigo, Nombre, Costo, PrecioVenta, Existencias, Comentarios
FROM Producto
WHERE ProductoID IN (5,1,3,8,100)

--se puede combinar IN con el operador NOT para que sea lo inverso
--Productos cuyo codigo NO sea CC02 y VER1
SELECT ProductoID, Codigo, Nombre, Costo, PrecioVenta, Existencias, Comentarios
FROM Producto
WHERE Codigo NOT IN ('CC02','VER1')

--puede usar operadores de comparacion >= > < <= <> =
--Productos cuyo costo sea >= 20
SELECT ProductoID, Codigo, Nombre, Costo, PrecioVenta, Existencias, Comentarios
FROM Producto
WHERE Costo >= 20

--Productos cuyo Precio de venta sea <= 10
SELECT ProductoID, Codigo, Nombre, Costo, PrecioVenta, Existencias, Comentarios
FROM Producto
WHERE PrecioVenta <= 10

--Productos cuyo Precio de venta esten entre 25 y 40
SELECT ProductoID, Codigo, Nombre, Costo, PrecioVenta, Existencias, Comentarios
FROM Producto
WHERE PrecioVenta BETWEEN 25 AND 40

-- Instruccion DELETE: elimna uno o mas registros de una tabla dependiendo del WHERE utilizado
/*Consideraciones:
-> esta instruccion no altera la numeracion del campo IDENTITY, si Usted borra registros
   el IDENTITY no regresara a la numeracion anterior.
-> Siempre es recomendado que antes de ejecutar un DELETE primero haga una vista previa
   usando SELECT para que tenga una idea de lo que va a eliminar.
-> Si algun registro de la tabla tiene asociacion con otra tabla por medio de una llave foranea
   entonces no se eliminará el registro.*/

--borrar todos los registros de una tabla
SELECT * FROM Producto --vista previa
DELETE FROM Producto --eliminacion

--eliminar todos los productos cuyo costo sea menor o igual que 10
--vista previa:
SELECT *
FROM Producto
WHERE Costo <= 10
--eliminacion:
DELETE
FROM Producto
WHERE Costo <= 10

--elimine el producto cuyo id sea 34
--vista previa:
SELECT *
FROM Producto
WHERE ProductoID = 34
--eliminacion:
DELETE
FROM Producto
WHERE ProductoID = 34

/*Recordatorio: DELETE no resetea ni afecta el campo IDENTITY en cambio TRUNCATE si lo hace
pero TRUNCATE no se puede combinar con WHERE.*/
TRUNCATE TABLE Producto

-- Instruccion UPDATE: Modifica uno o varios registros de una tabla.
/*Consideraciones:
-> Se recomienda combinarlo con WHERE
-> Al igual que con el DELETE se recomienda hacer una vista previa usando SELECT para saber
   que registros va a afectar.*/

--Dejar en CERO las existencias de todos los productos.
--Vista previa:
SELECT *
FROM Producto
--Actualización:
UPDATE Producto
SET Existencias = 0

--Coloque 100 existencias al producto cuyo Codigo sea FRU1
--Vista previa:
SELECT *
FROM Producto
WHERE Codigo = 'FRU1'
--Actualización:
UPDATE Producto
SET Existencias = 100
WHERE Codigo = 'FRU1'

--Tambien puede afectar varios campos:
--coloque el costo en 10 y las existencias en 80 para el producto con id = 2
--Vista previa:
SELECT *
FROM Producto
WHERE ProductoID = 2
--Actualización:
UPDATE Producto
SET Costo = 10, Existencias = 80
WHERE ProductoID = 2

--colocar en 150 las existencias para los productos con codigos: CC01, AGUA, CH01
--Vista previa:
SELECT *
FROM Producto
WHERE Codigo IN ('CC01','AGUA','CH01')
--Actualización:
UPDATE Producto
SET Existencias = 150
WHERE Codigo IN ('CC01','AGUA','CH01')

--UPDATE tambien puede realizar operaciones sobre valores previos
--aumentar en 1 las existencias del producto con codigo CC01
--Vista previa:
SELECT *
FROM Producto
WHERE Codigo = 'CC01'
--Actualización:
UPDATE Producto
SET Existencias = Existencias+1
WHERE Codigo = 'CC01'

--Otros ejemplos:
--subir los precios de todos los productos en un 10%
--Vista previa:
SELECT *
FROM Producto
--Actualización:
UPDATE Producto
SET PrecioVenta = PrecioVenta*1.10

--agregar la palabra REVISADO a los comentarios de todos los productos.
--Vista previa:
SELECT *
FROM Producto
--Actualización:
UPDATE Producto
SET Comentarios = CONCAT(Comentarios,' REVISADO')

--dejar en NULL el comentario del producto con codigo CC02
--Vista previa:
SELECT *
FROM Producto
WHERE Codigo = 'CC02'
--Actualización:
UPDATE Producto
SET Comentarios = NULL
WHERE Codigo = 'CC02'