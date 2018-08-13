create database membresias_club
go
use membresias_club
go

create table estados(
id_estado int identity(1,1) primary key,
nombre_estado text 
)
go

create table municipios(
id_municipio int identity(1,1) primary key,
id_estado int foreign key(id_estado) references estados(id_estado),
nombre_municipio text 
)
go

create table areas(
id_area int identity(1,1) primary key,
nombre varchar(80) ,
mensaje_cliente text ,
normas text,
edad_accesibilidad bit,
cupo_maximo int ,
cupo_actual int ,
horario varchar(60),
codigo_edad_accesibilidad bit,
estatus bit,
estatusEliminado bit 
)
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

create table turnos(
id_turno tinyint identity(1,1) primary key,
nombre varchar(50),
hora_entrada time(7),
hora_salida time(7)
)
go

create table estatus_empleados(
id_estatus tinyint identity(1,1) primary key,
nombre_estatus varchar(60)
)
go

create table cargos(
id_cargo tinyint identity(1,1) primary key,
nombre varchar(60) ,
actividades text 
)
go

create table privilegios(
id_privilegio tinyint identity(1,1) primary key,
privilegio varchar(60) 
)

create table empleados(
num int identity(1,1) ,
id_empleado varchar(30) primary key ,
nombre varchar(50) ,
apellido_p varchar(50),
apellido_m varchar(50),
sexo char(1),
fecha_nacimiento date ,
direccion text ,
codigo_postal int,
id_estado int foreign key(id_estado) references estados(id_estado),
id_municipio int foreign key(id_municipio) references municipios(id_municipio),
telefono varchar(15) ,
correo varchar(80) ,
rfid varchar(30) ,
nip int ,
fecha_registro date ,
fecha_retiro date ,
id_estatus tinyint foreign key(id_estatus) references estatus_empleados(id_estatus) ,
id_cargo tinyint foreign key(id_cargo) references cargos(id_cargo) ,
id_privilegio tinyint foreign key(id_privilegio) references privilegios(id_privilegio) ,
id_area int foreign key(id_area) references areas(id_area) 
)
go

create table entradas_salidas(
id_empleado varchar(30) foreign key(id_empleado) references empleados(id_empleado) ,
fecha date ,
hora_entrada time(7) ,
hora_salida time(7) 
)

create table turnos_empleados(
id_empleado varchar(30) foreign key(id_empleado) references empleados(id_empleado) ,
id_turno tinyint foreign key(id_turno) references turnos(id_turno) ,
dia_inicio date ,
dia_fin date 
)
go

create table promociones(
id_promocion int identity(1,1) primary key,
nombre varchar(50) ,
descripcion text ,
porcentaje_descuento tinyint ,
estatus bit ,
estatus_visible bit ,
fecha_inicio date ,
fecha_fin date 
)
go

--create table precios_membresias(
--id_precio int identity(1,1) primary key,
--estatus bit ,
--costo money ,
--id_promocion int foreign key(id_promocion) references promociones(id_promocion),
--iva tinyint ,
--fecha_registro datetime 
--)
--go

create table categorias_membresias(
id_categoria int identity(1,1) primary key,
categoria varchar(50),
costo money,
id_promocion int foreign key(id_promocion) references promociones(id_promocion),
iva tinyint,
estatus bit,
estatus_visible bit,
fecha_registro datetime
)
go

create table membresias(
num int identity(1,1) ,
id_membresia varchar(30) primary key ,
id_categoria int foreign key(id_categoria) references categorias_membresias(id_categoria) ,
id_empleado varchar(30) foreign key(id_empleado) references empleados(id_empleado) ,
vigencia_inicio date ,
vigencia_fin date ,
estatus bit ,
fecha_registro datetime ,
fecha_modificacion datetime 
)
go

create table clientes(
id_cliente int identity(1,1) primary key,
id_membresia varchar(30) foreign key(id_membresia) references membresias(id_membresia) ,
nombre varchar(50) ,
apellido_p varchar(50),
apellido_m varchar(50),
sexo char(1) ,
fecha_nacimiento date ,
direccion text ,
codigo_postal int,
id_estado int foreign key(id_estado) references estados(id_estado),
id_municipio int foreign key(id_municipio) references municipios(id_municipio),
telefono varchar(15),
correo varchar(80),
fecha_registro date ,
fecha_retiro date,
estatus bit
)
go

create table precio_por_miembro(
id_precio_miembro tinyint identity(1,1) primary key,
tipo_edad bit,
precio_extra money,
estatus bit
)
go

create table membresia_familiar_miembros(
id_membresia varchar(30) foreign key(id_membresia) references membresias(id_membresia) ,
id_membresia_familiar varchar(30) primary key,
nombre varchar(50) ,
apellido_p varchar(50),
apellido_m varchar(50),
sexo char(1) ,
id_precio_miembro tinyint foreign key(id_precio_miembro) references precio_por_miembro(id_precio_miembro) ,
estatus bit 
)
go

create table accesibilidad_areas(
id_categoria int foreign key(id_categoria) references categorias_membresias(id_categoria) ,
id_area int foreign key(id_area) references areas(id_area) 
)
go

create table areas_visitadas(
id_cliente int foreign key(id_cliente) references clientes(id_cliente) ,
id_membresia_familiar varchar(30) foreign key(id_membresia_familiar) references membresia_familiar_miembros(id_membresia_familiar),
id_area int foreign key(id_area) references areas(id_area) ,
hora_entrada time(7) ,
hora_salida time(7) ,
fecha date 
)

create table ventas(
id int identity(1,1) primary key,
id_cliente int foreign key(id_cliente) references clientes(id_cliente),
id_empleado varchar(30) foreign key(id_empleado) references empleados(id_empleado),
costo_membresia money,
descuento_promocion int,
iva int,
total money,
fecha datetime,
estatus_venta bit
)

create table detalle_venta(
id_venta int foreign key(id_venta) references ventas(id),
id_membresia_familiar varchar(30) foreign key(id_membresia_familiar) references membresia_familiar_miembros(id_membresia_familiar),
costo money
)
--select DATEDIFF(year,getdate(),'2019-06-24')
--select DATEDIFF(month,getdate(),'2019-06-24')
--select DATEDIFF(DAY,getdate(),'2019-06-24')
--select CURRENT_TIMESTAMP