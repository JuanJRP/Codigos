create database biblioteca_2

use biblioteca

 create table libros(
  codigo varchar(40)not null,
  titulo varchar(40)not null,
  autor varchar(40)not null,
  Genero varchar(40)not null,
  Tipo varchar(40)not null,
  primary key (codigo)
 );

 create table socios(
  documento varchar(8) not null,
  nombre varchar(30),
  barrio varchar(30),
  primary key (documento)
 );

  create table Empleados(
  documento varchar(8) not null,
  nombre varchar(30),
  barrio varchar(30),
  primary key (documento)
 );

 create table prestamos(
  documento varchar(8) not null,
  codigo varchar(40)not null,
  fechaprestamo date not null,
  fechadevolucion date,
  primary key (codigo)
 );

 create table Computadores(
  documentos varchar(8) not null,
  nombres varchar(40),
  hora_de_inicio varchar(40),
  Hora_de_finalizacion varchar(40),
  primary key (documentos)
 );

insert into socios(documento,nombre,barrio) values('22333441','Juan Perez','Colon 345');
 insert into socios(documento,nombre,barrio) values('23232442','Luis Lopez','Caseros 940');
 insert into socios(documento,nombre,barrio) values('25123443','Ana Herrero','Sucre 120');
 insert into socios(documento,nombre,barrio) values('19283012','mathias perez','poblado 940');
 insert into socios(documento,nombre,barrio) values('27892312','juliana paez','ayura 120');
  -- nuevos valores
 insert into socios(documento,nombre,barrio) values('11057804','Gerardo Requena','calasania ');
 insert into socios(documento,nombre,barrio) values('19038823','Ferran Ibañez','Ronledo');
 insert into socios(documento,nombre,barrio) values('29039921','Bernardino Seco','Santo Domingo');
 insert into socios(documento,nombre,barrio) values('14782900','Adam Lara','Aranjuez');
 insert into socios(documento,nombre,barrio) values('11302945','Lucio Bastida','Popular 1');
 insert into socios(documento,nombre,barrio) values('13674588','Claudio Cordon','Castilla');
 insert into socios(documento,nombre,barrio) values('10098382','Naia Mayoral','San javier');



 insert into Empleados(documento,nombre,barrio) values('10004107','Yurany Velasquez','Castilla');
 insert into Empleados(documento,nombre,barrio) values('11345612','Andres Felipe','San Javier');
 insert into Empleados(documento,nombre,barrio) values('10014701','Juan Jose Restrepo','Itagui');
 insert into Empleados(documento,nombre,barrio) values('12983901','kevin ramirez','industriales');
 insert into Empleados(documento,nombre,barrio) values('22612371','santiago petran','hospital');
 -- nuevos valores
 insert into Empleados(documento,nombre,barrio) values('10046707','Juan Andres','Buenos Aires');
 insert into Empleados(documento,nombre,barrio) values('10346599','Cipriano Sanmartin','La candelaria');
 insert into Empleados(documento,nombre,barrio) values('12014501','Marisa Bilbao','Poblado');
 insert into Empleados(documento,nombre,barrio) values('13572999','Anna Sarmiento','Guayabal');
 insert into Empleados(documento,nombre,barrio) values('10023485','Reyes Roca','Belén');
 insert into Empleados(documento,nombre,barrio) values('11067048','Maria Beatriz','San javier');
 insert into Empleados(documento,nombre,barrio) values('10034225','Adelaida Alcala','12 de octubre');


 insert into libros(codigo,titulo,autor,Genero,Tipo) values('A1','Algebra de Baldor','Aurelio Baldor','Educativo','Matematicas');
 insert into libros(codigo,titulo,autor,Genero,Tipo) values('A2','100 años de soledad','Gabriel Garcia Marquez','Novela','Literatura Colombiana');
 insert into libros(codigo,titulo,autor,Genero,Tipo) values('A3','Viaje al centro de la tierra','Julio Verne','Novela','ciencia Ficcion');
 insert into libros(codigo,titulo,autor,Genero,Tipo) values('A4','satanas','Mario Mendoza','ciencia ficcion','ficcion');
 insert into libros(codigo,titulo,autor,Genero,Tipo) values('A5','viaje a la luna','Julio Verne','Novela','ciencia Ficcion');
  -- nuevos valores
 insert into libros(codigo,titulo,autor,Genero,Tipo) values('B1','Nada','Carmen Laforet','Autobiografía','Existencialista');
 insert into libros(codigo,titulo,autor,Genero,Tipo) values('B2','Crónicas Marcianas','Ray Bradbury','Relato','Ciencia Ficción');
 insert into libros(codigo,titulo,autor,Genero,Tipo) values('B3','El laberinto español','Gerarld Brenan','Política','Ensayo');
 insert into libros(codigo,titulo,autor,Genero,Tipo) values('B4','Bajo la red','Iris Murdoch','Novela','Drama');
 insert into libros(codigo,titulo,autor,Genero,Tipo) values('B5','Las voces','Muriel Spark','Novela','Drama');
 insert into libros(codigo,titulo,autor,Genero,Tipo) values('C1','El tambor de Hojalata','Günter Grass','Novela','Bélico');
 insert into libros(codigo,titulo,autor,Genero,Tipo) values('C2','El señor de las moscas','William Golding','Relato','Grotesco');





 insert into prestamos(documento,codigo,fechaprestamo,fechadevolucion) values('11345612','B3','2016-08-10','2016-08-12');
 insert into prestamos(documento,codigo,fechaprestamo,fechadevolucion) values('10014701','C2','2016-08-15','2016-09-12');
 insert into prestamos(documento,codigo,fechaprestamo,fechadevolucion) values('10004107','C1','2016-08-10','2016-08-13');
 insert into prestamos(documento,codigo,fechaprestamo,fechadevolucion) values('23232442','A5','2016-08-10','2016-08-19');
 insert into prestamos(documento,codigo,fechaprestamo,fechadevolucion) values('10004107','B4','2016-08-15','2016-08-28');
 insert into prestamos(documento,codigo,fechaprestamo,fechadevolucion) values('25123443','A2','2016-08-02','2016-08-05');
 insert into prestamos(documento,codigo,fechaprestamo,fechadevolucion) values('10014701','C3','2016-08-02','2016-08-05');
  -- nuevos valores
 insert into prestamos(documento,codigo,fechaprestamo,fechadevolucion) values('11238277','B2','2016-09-11','2016-09-16');
 insert into prestamos(documento,codigo,fechaprestamo,fechadevolucion) values('10093387','B4','2016-09-01','2016-09-05');
 insert into prestamos(documento,codigo,fechaprestamo,fechadevolucion) values('11298706','A2','2016-09-23','2016-10-02');
 insert into prestamos(documento,codigo,fechaprestamo,fechadevolucion) values('11067482','C2','2016-09-19','2016-09-26');
 insert into prestamos(documento,codigo,fechaprestamo,fechadevolucion) values('14019872','A2','2016-09-24','2016-09-26');
 insert into prestamos(documento,codigo,fechaprestamo,fechadevolucion) values('17466522','A3','2016-09-06','2016-09-11');
 insert into prestamos(documento,codigo,fechaprestamo,fechadevolucion) values('11057839','B1','2016-09-17','2016-09-21');



 insert into Computadores(documentos,nombres,hora_de_inicio,Hora_de_finalizacion) values('10014701','Juan Jose Restrepo','2018-08-02-22:40','2018-08-02-24:00');
 insert into Computadores(documentos,nombres,hora_de_inicio,Hora_de_finalizacion) values('11345612','Andres Felipe','2020-08-02-13:10','2020-08-02-15:10');
 insert into Computadores(documentos,nombres,hora_de_inicio,Hora_de_finalizacion) values('25123443','Ana Herrero','2019-08-02-8:30','2019-08-02-10:30');
 insert into Computadores(documentos,nombres,hora_de_inicio,Hora_de_finalizacion) values('10410201','joan herrera','2020-08-03-7:28','2021-08-02-15:10');
 insert into Computadores(documentos,nombres,hora_de_inicio,Hora_de_finalizacion) values('68293812','ana mendoza','2019-08-04-9:19','2021-08-01-10:30');
  -- nuevos valores

 insert into Computadores(documentos,nombres,hora_de_inicio,Hora_de_finalizacion) values('10488390','Camila Sarmiento','2018-08-02-8:40','2018-08-02-9:30');
 insert into Computadores(documentos,nombres,hora_de_inicio,Hora_de_finalizacion) values('11057832','Andres Morales','2020-08-02-13:10','2020-08-02-15:10');
 insert into Computadores(documentos,nombres,hora_de_inicio,Hora_de_finalizacion) values('19743321','Jhon Aguirre','2019-08-02-11:30','2019-08-02-14:30');
 insert into Computadores(documentos,nombres,hora_de_inicio,Hora_de_finalizacion) values('11048930','Marilyn Monsalve','2020-08-03-20:30','2021-08-02-22:50');
 insert into Computadores(documentos,nombres,hora_de_inicio,Hora_de_finalizacion) values('18492922','Maria Paula','2019-08-04-17:15','2021-08-01-19:00');
 insert into Computadores(documentos,nombres,hora_de_inicio,Hora_de_finalizacion) values('12988443','Angie Sofia herrera','2020-08-03-12:45','2021-08-02-14:20');
 insert into Computadores(documentos,nombres,hora_de_inicio,Hora_de_finalizacion) values('10488221','Omar Vallejuelos','2019-08-04-10:19','2021-08-01-11:00');