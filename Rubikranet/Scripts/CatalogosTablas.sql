--Después de aprobar todos los catálogos, creamos los insert aquí mismo

/*
Catálogo estatus_empleados

id_estatus	nombre_estatus
1			Inactivo/Eliminado
2			Suspendido temporalmente
3			Incapacitado	
4			Activo
5			Periódo vacacional
*/



/*
insert into estatus_empleado	
values ('	Inactivo/Eliminado
('	Suspendido temporalmente
('	Incapacitado
('	Activo
('	Periódo vacacional

*/





/*
Catálogo areas

[nombre]					codigo_edad_accesibilidad (0 = Adultos, 1 = Familiar)
							Se usará este campo para los que tengan membresías familiares en su campo tipo_edad
Piscina nombre1
Piscina nombre2
Sala de juegos
Bar nombre1
Bar nombre2
Cine
Cine VIP
Cine 3D
Teatro
Gimnasio
Restaurante Chino
Restaurante Brasileño
Restaurante Mexicano
Dormitorio básico
Dormitorio Intermedio
Dormitorio Premium
Campo de golf
Regaderas
Antro nombre1
Antro nombre2
Centro comercial
Museo
Juegos mecánicos
Zona de postres
Spa
Zona de juegos
Enfermeria 
*/


/*
Catálogo categorías_membresias

id_categoria	categoria
1				Familiar	
2				Pareja
3				Basic
4				Plus
5				Premium
6				Gold
*/


/*
Catálogo Privilegios

id_privilegio	privilegio
1				Administrador
2				Usuario
3				Básico
4				Ninguno
*/


/*
Catálogo precio_por_miembro
tipo_edad= 0 = adulto y 1 = menor de edad
estatus = 0 inactivo y 1 activo

id_precio_miembro	tipo_edad	precio_extra	estatus
1					0			1500			1
2					1			1000			1	
3					0			2000			0
4					1			1500			0
*/

/*
Catálogo promociones

id_promocion	nombre		    Descripción	
1				Cumpleaños		Compra una membresia el dia de tu cumpleaños y te hacemos un 20% de descuento(Solo aplica en membresias individuales)
2				Dia del niño	Compra una membresia el dia del niño y te hacemos un 15% de descuento en areas infantiles (Solo aplica en membresias individuales)
3				San Valentin	Compra una membresia en San valentin y te hacemos un 35% de descuento(Solo aplica ende pareja)
4               Dia de la familia Comprar una menbresia  el dia de la familia y tendremos un descuento de el 25% de descuento (Solo aplica para la membresias familiares)
*/


/*
Catálogo turnos 
Formato de horas en 24 = 12:45:36, 17:56:00 ..etc

id_turno	nombre	hora_entrada	hora_salida
1           Matutino    08:00:00      16:00:00
2           Vespertino  16:00:00      19:00:00
3           Nocturno    19:00:00      24:00:00
*/

/*
Catálogo cargos

nombre		         Actividades
Administrador		Llevar el control total del establecimiento
Usuario				Consulta solo la información del establecimiento
Encargados de área  Consulta la información de cada una de sus áreas      
*/

/*
Catálogo estados  

id_estado		nombre_estado
1               Aguascalientes	
2				Baja California	
3				Baja California Sur 
4				Campeche	
5				Chiapas	
6				Chihuahua	
7				Ciudad de México
8				Coahuila	
9				Colima	
10				Durango	
11				Guanajuato	
12			    Guerrero	
13				Hidalgo	
14				Jalisco	
15				México	
16				Michoacán	
17				Morelos	
18				Nayarit	
19				Nuevo León	
20				Oaxaca	
21				Puebla	
22				Querétaro	
23				Quintana Roo	
24				San Luis Potosí	
25				Sinaloa	
26				Sonora
27				Tabasco	
28				Tamaulipas	
29				Tlaxcala	
30				Veracruz	
31				Yucatán	
32				Zacatecas
*/
