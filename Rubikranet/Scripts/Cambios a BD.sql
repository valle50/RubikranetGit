--Se ejecutan los siguientes comandos para hacer cambios a la BD
--Estos cambios vendrán incluidos en la BD final, por el momento la BD actual es beta
--mientras se siga desarrollando la aplicación.

--Se cambió el tipo de dato bigint por varchar(15) para los teléfonos
ALTER TABLE empleados ALTER COLUMN telefono varchar(15) NULL
ALTER TABLE clientes ALTER COLUMN telefono varchar(15) NULL

--Se agregaron campo para verificar la accesibilidad a los miebros familiares de acuerdo a su edad
alter table areas add codigo_edad_accesibilidad bit null

--se agregó campo para verificar el estatus del área
alter table areas add estatus bit null

--se agregó campo para quitar acceso a áreas a membresías.
alter table accesibilidad_areas add estatus bit null

--se agregó campo para ocultar categorias de membresías
alter table categorias_membresias add estatus_visible bit null

--se agrego para el "eliminar" el área
alter table areas add estatusEliminado bit null -- 0 = no eliminado. 1 = eliminado

--se agregaron los siguientes campos a categorias_membresias para reemplazar a la tabla de precios_membresias
alter table categorias_membresias add costo money
alter table categorias_membresias add id_promocion int foreign key(id_promocion) references promociones(id_promocion)
alter table categorias_membresias add iva tinyint
alter table categorias_membresias add estatus bit

--Por el momento solo se quitó el "not null" de la foránea "id_precio" a la tabla "precios_membresias", la cual se eliminará
--porque sus campos se pasaron a la tabla de categorias_membresias
alter table categorias_membresias alter column id_precio int null

--se agregó campo estatus a inventario_areas para "eliminación"
alter table inventario_areas add estatus bit



--Update para agregar valores a campos de tabla áreas
 update areas set estatusEliminado = 0
 update areas set estatus = 0
 update areas set codigo_edad_accesibilidad = 0

 --Update para agregar valores a campos de tabla categorias_membresias
 update categorias_membresias set costo = 1000
 update categorias_membresias set iva = 16
 update categorias_membresias set estatus = 0 --0 = no eliminado. 1= eliminado
 update categorias_membresias set estatus_visible = 1 -- 0 = no visible/inactivo.  1= visible/activo


 --Se agregaron campos de id y estatus a tabla inventario_areas (no afecta en nada), es necesario volverla a 
 --crear, correr los siguientes comandos
 drop table inventario_areas
 go
 create table inventario_areas(
id int identity(1,1) primary key,
id_area int foreign key(id_area) references areas(id_area),
nombre_item varchar(100) ,
cantidad_inicio int ,
cantidad_actual int ,
detalles text,
notas text,
estatus bit
)
go
 --update para agregar valores a campo estatus de inventario_areas
 update inventario_areas set estatus = 0

 -- quitar not null a columnas
 alter table areas_visitadas alter column hora_entrada time(7) null
 alter table areas_visitadas alter column hora_salida time(7) null
