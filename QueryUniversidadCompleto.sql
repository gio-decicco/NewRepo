create table Asignatura
(
idAsignatura int identity (1,1),
nomAsignatura varchar(50)
constraint pkAsignatura primary key (idAsignatura)
)

create table Carrera 
(
idCarrera int identity (1,1),
nomCarrera varchar(100),
titulo varchar (100)
constraint pkCarrera primary key (idCarrera)
)

create table DetalleCarrera
(
idDetalle int,
idCarrera int,
idAsignatura int,
anio int,
cuatrimestre int
constraint pkDetalle primary key (idDetalle, idCarrera),
constraint fkAsignatura foreign key (idAsignatura)
	references Asignatura (idAsignatura)
)

alter procedure spConsultarAsignaturas
as
begin
select * from Asignatura
end

alter procedure spInsertarCarrera
@nombreCarrera varchar (100),
@titulo varchar (100),
@activo bit = 1,
@id int output
as
begin
insert into Carrera values (@nombreCarrera, @titulo, @activo)
set @id = SCOPE_IDENTITY();
end

create procedure spInsertarDetalle
@idDetalle int,
@idCarrera int,
@idAsignatura int,
@anio int,
@cuatrimestre int
as
insert into DetalleCarrera values (@idDetalle, @idCarrera, @idAsignatura, @anio, @cuatrimestre)

select * from DetalleCarrera

alter table Carrera
add activo bit

select * from carrera

alter procedure spConsultarCarreras
@activo int = 1
as
select * from carrera
where activo = @activo

execute spConsultarCarreras @activo=0

create procedure sp_prox_carrera
@id int output
as
set @id = (select max(idCarrera)+1
from Carrera)

insert into Carrera values('Tecnicatura en programacion', 'Tecnico Universitario en Programacion', 1)

select * from carrera

insert into Asignatura values ('Matematica')
insert into Asignatura values ('Programacion 1')
insert into Asignatura values ('Laboratorio de Computacion 1')
insert into Asignatura values ('Metodologia de la Investigacion')
insert into Asignatura values ('Ingles')
insert into Asignatura values ('Sistemas de Procesamientos de datos')

select * from Asignatura

create procedure spBajaCarrera
@idCarrera int
as
update Carrera
set activo = 0
where idCarrera = @idCarrera

create procedure spActivarCarrera
@idCarrera int
as
update Carrera
set activo = 1
where idCarrera = @idCarrera

execute spBajaCarrera @idCarrera = 1

select * from Carrera

create procedure spConsultarDetalles
@idCarrera int
as
select * from DetalleCarrera
where idCarrera = @idCarrera

create procedure spConsultarAsignaturasConId
@idAsignatura int
as
select * from Asignatura
where idAsignatura = @idAsignatura

create procedure spConsultarCarrera
@idCarrera int
as
select * from Carrera
where idCarrera = @idCarrera
