create procedure empleados_aa
@check varchar(30),
@id_empleado varchar(30),
@nombre varchar(50),
@apellido_p varchar(50),
@apellido_m varchar(50),
@sexo char(1),
@fecha_nacimiento date,
@direccion text,
@codigo_postal int,
@id_estado int,
@id_municipio int,
@telefono varchar(15),
@correo varchar(30),
@rfid varchar(30),
@nip int,
@id_estatus int,
@id_cargo int,
@id_privilegio int,
@id_area int,
@id_turno int,
@dia_inicio date,
@dia_fin date
as
begin
  if @check = '0'	
	begin
		insert into empleados(id_empleado, nombre, apellido_p, apellido_m, sexo, fecha_nacimiento, direccion, codigo_postal, id_estado, id_municipio, telefono, correo, rfid, nip, fecha_registro, id_estatus, id_cargo, id_privilegio, id_area)
		values(@id_empleado, @nombre, @apellido_p, @apellido_m, @sexo, @fecha_nacimiento, @direccion, @codigo_postal, @id_estado, @id_municipio, @telefono, @correo, @id_empleado, @nip, getdate(), @id_estatus, @id_cargo, @id_privilegio, @id_area)
		insert into turnos_empleados(id_empleado, id_turno, dia_inicio, dia_fin)
		values(@id_empleado, @id_turno, @dia_inicio, @dia_fin)
	end
  else
    update empleados
	set nombre = @nombre,
	apellido_p = @apellido_p,
	apellido_m = @apellido_m,
	sexo = @sexo, 
	fecha_nacimiento = @fecha_nacimiento,
	direccion = @direccion,
	codigo_postal = @codigo_postal,
	id_estado = @id_estado,
	id_municipio = @id_municipio,
	telefono = @telefono,
	correo = @correo,
	rfid = @rfid,
	nip = @nip,
	id_estatus = @id_estatus,
	id_cargo = @id_cargo,
	id_privilegio = @id_privilegio,
	id_area = @id_area
	where id_empleado = @id_empleado
	update turnos_empleados 
	set id_empleado = @id_empleado,
	id_turno = @id_turno,
	dia_inicio = @dia_inicio, 
	dia_fin = @dia_fin
	where id_empleado = @id_empleado
end
go

create view listarEmpleados
as
select e.num,
   e.id_empleado,
   e.nombre Nombre, 
   e.apellido_p 'Apellido paterno', 
   e.apellido_m 'Apellido materno', 
   e.sexo Sexo, 
   e.fecha_nacimiento 'Fecha de nacimiento', 
   e.direccion Dirección, 
   e.codigo_postal 'Código postal', 
   (select top(1) nombre_estado from estados es where e.id_estado = es.id_estado) Estado, 
   (select top(1) nombre_municipio from municipios m where e.id_municipio = m.id_municipio) Municipio, 
   e.telefono Teléfono, 
   e.correo Correo, 
   e.rfid RFID, 
   e.nip NIP,
   (select top(1) t.nombre from turnos_empleados te, turnos t where te.id_empleado = e.id_empleado and t.id_turno = te.id_turno) Turno,
   (select top(1) t.hora_entrada from turnos_empleados te, turnos t where te.id_empleado = e.id_empleado and t.id_turno = te.id_turno) 'Hora de entrada',
   (select top(1) t.hora_salida from turnos_empleados te, turnos t where te.id_empleado = e.id_empleado and t.id_turno = te.id_turno) 'Hora de salida',  
   (select top(1) te.dia_inicio from turnos_empleados te, turnos t where te.id_empleado = e.id_empleado and t.id_turno = te.id_turno) 'Día inicio',
   (select top(1) te.dia_fin from turnos_empleados te, turnos t where te.id_empleado = e.id_empleado and t.id_turno = te.id_turno) 'Día fin',   
   e.fecha_registro 'Fecha de registro', 
   (select top(1) nombre_estatus from estatus_empleados ee where ee.id_estatus = e.id_estatus) Estatus,
   (select top(1) nombre from cargos c where c.id_cargo = e.id_cargo) Cargo,
   (select top(1) privilegio from privilegios p where p.id_privilegio = e.id_privilegio) Privilegio,
   (select top(1) nombre from areas a where a.id_area = e.id_area) Área 
   from empleados e where e.id_estatus <> 1
   go


  create procedure buscaEmpleados
  @parametro varchar(max)
  as
  select * from listarEmpleados le
	where 
	le.id_empleado like '%'+@parametro+'%' or
	CONCAT(le.Nombre,' ',le.[Apellido paterno],' ',le.[Apellido materno]) like '%'+@parametro+'%' or
	le.Sexo like '%'+@parametro+'%' or
	le.[Fecha de nacimiento] like '%'+@parametro+'%' or
	le.Dirección like '%'+@parametro+'%' or
	le.[Código postal] like '%'+@parametro+'%' or
	le.Estado like '%'+@parametro+'%' or
	le.Municipio like '%'+@parametro+'%' or
	le.Teléfono like '%'+@parametro+'%' or
	le.Correo like '%'+@parametro+'%' or
	le.RFID like '%'+@parametro+'%' or
	le.NIP like '%'+@parametro+'%' or
	le.[Fecha de registro] like '%'+@parametro+'%' or
	le.Estatus like '%'+@parametro+'%' or
	le.Cargo like '%'+@parametro+'%' or
	le.Privilegio like '%'+@parametro+'%' or
	le.Área like '%'+@parametro+'%' or
	le.Turno like '%'+@parametro+'%' or
	le.[Hora de entrada] like '%'+@parametro+'%' or
	le.[Hora de salida] like '%'+@parametro+'%' or
	le.[Día inicio] like '%'+@parametro+'%' or
	le.[Día fin] like '%'+@parametro+'%'
	order by le.num desc
	go
	 

	create view listarAreas
	as
	select 
	id_area,
	nombre 'Nombre del área',
	mensaje_cliente 'Mensaje para el cliente',
	normas 'Normas del área',
	cupo_maximo 'Cupo máximo',
	cupo_actual 'Cupo actual',
	horario Horario,
	case 
		codigo_edad_accesibilidad
		when 0 then 'Adultos'
		when 1 then 'Familiar'
	end as 'Accesibilidad del área',
	IIF(estatus = 0, 'Fuera de servicio', 'En servicio') as 'Estado del área'
	from areas where estatusEliminado <> 1
	go
	
	
	create procedure buscaAreas
	@parametro varchar(max)
	as
	select * from listarAreas 
	where 
	[Nombre del área] like '%'+@parametro+'%' or
	[Mensaje para el cliente] like '%'+@parametro+'%' or
	[Normas del área] like '%'+@parametro+'%' or
	[Cupo máximo] like '%'+@parametro+'%' or
	[Cupo actual] like '%'+@parametro+'%' or
	Horario like '%'+@parametro+'%' or
	[Accesibilidad del área] like '%'+@parametro+'%' or
	[Estado del área] like '%'+@parametro+'%'
	go



--select * from (select id_objeto as laid, objeto from tobjetos) temporal where laid=100


--ALTER TABLE empleados ALTER COLUMN telefono varchar(15) NULL 
--ALTER TABLE tabla ADD columna char(1)
--ALTER TABLE tabla DROP columna;
--EXEC sp_RENAME 'table_name.old_name', 'new_name', 'COLUMN'
--exec empleados_aa '0','9999','nuevo nom','nuevo ap','nuevo am','m', '18-03-6','dirección','12345','3','4','(123)-456-7890','correo','2222','1234','3','4','6','7'
