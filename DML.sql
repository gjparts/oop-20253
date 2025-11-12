/*DML: Data Manipulation Language
Lenguaje de manipulación de datos: son las instrucciones
que le permiten interacturas con los datos almacenados
en las diferentes tablas de la base de datos.
Las instrucciones DML mas utilizadas son:
SELECT, INSERT, DELETE, UPDATE.

-> Las instrucciones DML no requiere de colocar GO despues de cada una.*/

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