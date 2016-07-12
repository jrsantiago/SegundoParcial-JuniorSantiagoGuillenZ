CREATE TABLE Empleados(
IdEmpleado int IDENTITY(1,1),
Fecha datetime ,
Nombres varchar(80) ,
Direccion varchar(100) ,
Telefono varchar(12) ,
Celular varchar(12) ,
Cedula varchar(13) ,
Cargo varchar(50) ,
Sueldo float ,
Incentivo float ,
Activo bit,

primary key(IdEmpleado)
 )﻿;