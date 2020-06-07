use Knockoutjs
create table Persona(
persona_id int identity(1,1) primary key,
persona_cedula varchar(50),
persona_nombre varchar(50),
persona_apellido varchar(50),
persona_correo varchar(50),
)


create procedure PA_Registrar(@cedula varchar(50), @nombre varchar(50),@apellido varchar(50),@correo varchar(50))
as set nocount on;
insert into Persona values(@cedula,@nombre,@apellido,@correo)
go
create procedure PA_Modificar(@id int, @cedula varchar(50), @nombre varchar(50),@apellido varchar(50),@correo varchar(50))
as set nocount on;
update Persona
set persona_cedula=@cedula,persona_nombre=@nombre,persona_apellido=@apellido,persona_correo=@correo where persona_id=@id
go

create procedure PA_Listar
as set nocount on;
select persona_id,persona_cedula, persona_nombre, persona_apellido,persona_correo from Persona
go

create procedure PA_Eliminar(@id int)
as set nocount on;
delete from Persona where persona_id=@id
go
