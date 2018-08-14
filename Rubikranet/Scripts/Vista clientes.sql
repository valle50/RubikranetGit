alter VIEW CLIENTES_MEMBRESIAS
AS
SELECT mem.num, mem.id_membresia as 'Membresia',cli.nombre as 'Nombre',CONCAT(cli.apellido_p,' ',cli.apellido_m)as 'Apellidos',
cli.telefono as 'Teléfono',cli.fecha_registro as 'Fecha de Registro' ,cat.categoria as 'Categoria',emp.nombre as 'Empleado',
mem.vigencia_inicio as 'Inicio de Membresia',mem.vigencia_fin as 'Vigencia'
FROM membresias mem,clientes cli,categorias_membresias cat,empleados emp WHERE mem.id_membresia = cli.id_membresia AND cat.id_categoria = mem.id_categoria
AND cli.estatus = '0' AND emp.id_empleado = mem.id_empleado
go

/*SELECT membresias.id_membresia,clientes.nombre,CONCAT(clientes.apellido_p,' ',clientes.apellido_m)as apellidos,clientes.telefono,clientes.fecha_registro,categorias_membresias.categoria,empleados.nombre as empleado,
case
membresias.estatus
when 1 then 'Activo'
when 0 then 'Inactivo'
end as 'Estatus de membresía'
,membresias.vigencia_inicio,membresias.vigencia_fin
FROM membresias,clientes,categorias_membresias,empleados WHERE membresias.estatus = '1' AND membresias.id_membresia = clientes.id_membresia AND categorias_membresias.id_categoria = membresias.id_categoria
AND clientes.estatus = '1' AND empleados.id_empleado = membresias.id_empleado*/