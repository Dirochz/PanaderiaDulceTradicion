
CREATE DATABASE Panaderia
GO

USE Panaderia
GO


create table Productos
(ID int identity primary key not null, 
 Nombre varchar(100) null, 
 Tamaño varchar(50) null, 
 Cantidad int null,
 Precio float null)

create table Factura
(ID int identity primary key not null, 
 Nombre varchar(100) null, 
 RFC varchar(50) null,
 Producto varchar(100) null,
 Fecha varchar(50) null,
 Precio float null,
 Cantidad int null,
 Descuento int null,
 Subtotal float null,
 IVA float null,
 Total float null)

select * from Productos
select * from Factura