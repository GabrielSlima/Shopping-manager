create database db_Shopping5
GO
USE db_Shopping5
go
create table tb_Setor(
cod_Setor int  primary key identity ,
nome_Setor varchar(50),
descr_Setor varchar(150)
)

go
create table tb_Lojas(
cod_Loja int  primary key identity ,
nome_fantasia varchar (50),
nome_Loja varchar(50) not null,
cnpj_Loja varchar(16),
localizacao_Loja varchar (50),
cod_Setor int references tb_Setor(cod_Setor)
)


go
create table tb_Funcionario (
cod_FuncShop int  primary key identity ,
nome_FuncShop varchar(50) not null,
end_FuncShop varchar(50),
complemento varchar (20),
Email varchar (50),
cidade_FuncShop varchar(50),
tel_FuncShop varchar(13),
cel_FuncShop varchar(14),
rg_FuncShop varchar(10),
cpf_FuncShop varchar(14) not null,
cargo_FuncShop varchar(50),
sex_func varchar (50),
turno varchar (50)
)

go
create table tb_Anot(
cod_Ocor int  primary key identity ,
anota_Ocor varchar(500),
date_Ocor varchar (50),
hora_Ocor varchar (50),
cod_Func int references tb_Funcionario(cod_FuncShop)
)


go
create table tb_Docas(
cod_Operacao int  primary key identity,
nome_Loja varchar (50),
hora_entrega varchar (50),
data_entrega varchar(50),
altura_entrega decimal,
peso_entrega decimal,
cod_FuncShop int references tb_Funcionario(cod_FuncShop),
descr_Carga varchar(500)
)
go
create table tb_Usuario(
Usuario_Login varchar (25) primary key, 
senha_Usuario varchar(25) not null,
nivel_Usuario varchar(25) not null,
cod_Func int references tb_Funcionario(cod_FuncShop)
)


create table tb_Veiculos 
(
codigo int identity primary key,
placa varchar(50),
modelo varchar (50),
marca varchar (50),
cod_Func int references tb_Funcionario(cod_FuncShop)
)

-- Setores 
select * from tb_Setor
insert into tb_Setor values ('Comida','um setor ai')
insert into tb_Setor values ('Roupas','um setor ai part2')
insert into tb_Setor values ('Calçados','um setor ai part3')
insert into tb_Setor values ('Limpeza','um setor que limpa')

select* from tb_Funcionario

insert into tb_Funcionario values ('Gabriel','Uma rua aí','casa','email@gmail.com','Oz','1234-1234','4321-4321','6666666666','6666666666666','Diretor','M','N')
insert into tb_Funcionario values ('Murilo','Uma rua aí part2','casa','murilo@gmail.com','Oz','1234-1234','4321-4321','6666666666','12345678986','Presidente','M','N')
insert into tb_Funcionario values ('Ana','Uma rua aí','casa','email@gmail.com','Oz','1234-1234','4321-4321','6666666666','3333333333333','Presidente','F','M')
insert into tb_Funcionario values ('Felipe','Uma rua aí','casa','email@gmail.com','Oz','1234-1234','4321-4321','6666666666','12354567890978','Recepcao','Masculino','Noite')


insert into tb_Usuario values ('Misa',' ,¹b¬Y[K-#Kp','Diretor',1)
insert into tb_Usuario values ('Murilo','¹b¬Y[K-#Kp','Presidente',2)


select * from tb_Usuario

--REGISTRO DE DADOS MORTOS 
go
create table tb_Setor_Morto(
cod_Setor int primary key,
nome_Setor varchar(50),
descr_Setor varchar(150)
)
go
create table tb_Lojas_Morto(
cod_Loja int primary key,
nome_Fantasia varchar (50),
nome_Loja varchar(50) not null,
cnpj_Loja varchar(16),
cod_Setor int
)


go
create table tb_Funcionario_Shopping_Morto(
cod_FuncShop int primary key,
nome_FuncShop varchar(50) not null,
end_FuncShop varchar(50),
cidade_FuncShop varchar(50),
tel_FuncShop varchar(13),
cel_FuncShop varchar(12),
rg_FuncShop varchar(10),
cpf_FuncShop varchar(14) not null,
cargo_FuncShop varchar(50),
sex_func varchar (50),
turno varchar (50)
)
go
create table tb_Estacionamento_Morto(
cod int primary key,
placa varchar (50),
modelo varchar (50),
marca varchar (50),
codigo int 
)

--ALTERAÇÃO DE DADOS DAS TABELAS

go
create table tb_Regis_Setor(
usuario varchar(50),
acao varchar(9),
data date,
codigo int
)
go
create table tb_Regis_Lojas(
usuario varchar(50),
acao varchar(9),
data date,
codigo int
)
go
create table tb_Regis_FuncShop(
usuario varchar(50),
acao varchar(9),
data date,
codigo int
)
go
create table tb_Regis_Estac(
usuario varchar(50),
acao varchar(9),
data date,
codigo int
)
go



--TRIGGERS
create trigger trg_I_Table_Setor
ON tb_Setor
FOR INSERT
AS
insert into tb_Setor_Morto(cod_Setor,nome_Setor,descr_Setor)
select cod_Setor,nome_Setor,descr_Setor
from inserted
go

create trigger trg_I_Table_Lojas
ON tb_Lojas
FOR INSERT AS
insert into tb_Lojas_Morto(cod_Loja,nome_Fantasia, nome_Loja,cnpj_Loja,cod_Setor)
select cod_Loja,nome_Fantasia,nome_Loja,cnpj_Loja,cod_Setor
from inserted
go

create trigger trg_I_Table_FuncShop
ON tb_Funcionario
FOR INSERT
AS
insert into tb_Funcionario_Shopping_Morto(cod_FuncShop,nome_FuncShop,end_FuncShop,cidade_FuncShop,tel_FuncShop,cel_FuncShop,rg_FuncShop,cpf_FuncShop,cargo_FuncShop, sex_func, turno)
select cod_FuncShop,nome_FuncShop,end_FuncShop,cidade_FuncShop,tel_FuncShop,cel_FuncShop,rg_FuncShop,cpf_FuncShop,cargo_FuncShop, sex_func, turno
from inserted
go




--MÉTODOS SUPER USER - REGISTRAR QUANDO ALGUM USUÁRIO MUDA ALGO DO BANCO DE DADOS POR MEIO DE UPDATE'S OU DELETE'S

create trigger tg_1_tb_Setor ON tb_Setor
FOR UPDATE as
INSERT INTO tb_Regis_Setor
select
SUSER_NAME(),
'ALTEROU',
GETDATE(),
cod_Setor
from inserted
go

create trigger tg_2_tb_Setor ON tb_Setor
FOR UPDATE as
INSERT INTO tb_Regis_Setor
select
SUSER_NAME(),
'DELETOU',
GETDATE(),
cod_Setor
from inserted
go

create trigger tg_1_tb_Lojas ON tb_Lojas
FOR UPDATE as
INSERT INTO tb_Regis_Lojas
select
SUSER_NAME(),
'ALTEROU',
GETDATE(),
cod_Loja
from inserted
go

create trigger tg_2_tb_Lojas ON tb_Lojas
FOR UPDATE as
INSERT INTO tb_Regis_Setor
select
SUSER_NAME(),
'DELETOU',
GETDATE(),
cod_Loja
from inserted
go

create trigger tg_1_tb_FuncShop ON tb_Funcionario
FOR UPDATE as
INSERT INTO tb_Regis_FuncShop
select
SUSER_NAME(),
'ALTEROU',
GETDATE(),
cod_FuncShop
from inserted
go

create trigger tg_2_tb_FuncShop ON tb_Funcionario
FOR UPDATE as
INSERT INTO tb_Regis_FuncShop
select
SUSER_NAME(),
'DELETOU',
GETDATE(),
cod_FuncShop
from inserted
go

select * from sys.triggers
select * from tb_Setor_Morto

select*from tb_Funcionario_Shopping_Morto

select*from tb_Docas

