--Se ejecutan los siguientes comandos para hacer cambios a la BD
--Estos cambios vendrán incluidos en la BD final, por el momento la BD actual es beta
--mientras se siga desarrollando la aplicación.

--Se cambió el tipo de dato bigint por varchar(15) para lo teléfonos
ALTER TABLE empleados ALTER COLUMN telefono varchar(15) NULL
--Se agregaron campo para verificar la accesibilidad a los miebros familiares de acuerdo a su edad
alter table areas add codigo_edad_accesibilidad bit null
--se agregó campo para verificar el estatus del área
alter table areas add estatus bit null
--se agregó campo para quitar acceso a áreas a membresías.
alter table accesibilidad_areas add estatus bit null
--se agregó campo para ocultar categorias de membresías
alter table categorias_membresias add estatus_visible bit null
