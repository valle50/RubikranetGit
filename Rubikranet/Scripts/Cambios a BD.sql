--Se ejecutan los siguientes comandos para hacer cambios a la BD
--Estos cambios vendr�n incluidos en la BD final, por el momento la BD actual es beta
--mientras se siga desarrollando la aplicaci�n.

--Se cambi� el tipo de dato bigint por varchar(15) para lo tel�fonos
ALTER TABLE empleados ALTER COLUMN telefono varchar(15) NULL
--Se agregaron campo para verificar la accesibilidad a los miebros familiares de acuerdo a su edad
alter table areas add codigo_edad_accesibilidad bit null
--se agreg� campo para verificar el estatus del �rea
alter table areas add estatus bit null
--se agreg� campo para quitar acceso a �reas a membres�as.
alter table accesibilidad_areas add estatus bit null
--se agreg� campo para ocultar categorias de membres�as
alter table categorias_membresias add estatus_visible bit null
