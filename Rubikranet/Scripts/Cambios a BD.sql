--Se ejecutan los siguientes comandos para hacer cambios a la BD
--Estos cambios vendr�n incluidos en la BD final, por el momento la BD actual es beta
--mientras se siga desarrollando la aplicaci�n.

--Se cambi� el tipo de dato bigint por varchar(15) para los tel�fonos
ALTER TABLE empleados ALTER COLUMN telefono varchar(15) NULL
--Se agregaron campo para verificar la accesibilidad a los miebros familiares de acuerdo a su edad
alter table areas add codigo_edad_accesibilidad bit null
--se agreg� campo para verificar el estatus del �rea
alter table areas add estatus bit null
--se agreg� campo para quitar acceso a �reas a membres�as.
alter table accesibilidad_areas add estatus bit null
--se agreg� campo para ocultar categorias de membres�as
alter table categorias_membresias add estatus_visible bit null
--se agrego para el "eliminar" el �rea
alter table areas add estatusEliminado bit null
--se agregaron los siguientes campos a categorias_membresias para reemplazar a la tabla de precios_membresias
alter table categorias_membresias add costo money
alter table categorias_membresias add id_promocion int foreign key(id_promocion) references promociones(id_promocion)
alter table categorias_membresias add iva tinyint
alter table categorias_membresias add estatus bit



--Update para agregar valores a campos de tabla �reas
 update areas set estatusEliminado = 0
 update areas set estatus = 0
 update areas set codigo_edad_accesibilidad = 0
 --Update para agregar valores a campos de tabla categorias_membresias
 update categorias_membresias set costo = 1000
 update categorias_membresias set iva = 16