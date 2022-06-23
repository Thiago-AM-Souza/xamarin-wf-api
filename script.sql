create database Cadastro
go
use Cadastro
create table Cliente(
	id int identity(1,1) primary key,
	nome varchar(150),
	cpf_cnpj varchar(15),
	cep varchar(15),
	limite decimal(19,2),
	email varchar(50),
	senha varchar(10),
	data_cadastro datetime,
	ativo bit,
	importado bit,
	telefone varchar(50)
)

insert into Cliente(
	nome,
	cpf_cnpj,
	cep,
	limite,
	email,
	senha,
	data_cadastro,
	ativo,
	importado,
	telefone
)	
values (
	'',
	'',
	'',
	0,
	'',
	'',
	getdate(),
	1,
	null,
	''
)

