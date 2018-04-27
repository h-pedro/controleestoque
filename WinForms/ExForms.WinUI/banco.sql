use master
go

CREATE DATABASE ExWinForms
go

use ExWinForms
go

-- criando tabela de usuários
IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'usuario')
   DROP TABLE usuario
GO

create table usuario (
	id int identity(1,1) not null,
	nome varchar(150) not null,
	email varchar(300),
	[login] varchar(100) not null,
	senha varchar(100) not null,
	constraint [pk_usuario] primary key clustered (id)		
);
go

insert into usuario (nome, email, [login], senha) values ('Administrador', 'admin@exemplo.com.br', 'admin', '123');
go

-- criando tabela de categorias
IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'categoria')
   DROP TABLE categoria
GO

create table categoria (
	id int identity(1,1) not null,
	nome varchar(100) not null,
	descricao varchar(500),
	constraint [pk_categoria] primary key clustered (id)		
);
go

Create Table Unidade_Medida(
	id int identity(1,1) primary key,
	nome varchar(200),
	sigla varchar(10)
)

-- criando tabela de produtos
IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'produto')
   DROP TABLE produto
GO	


create table produto (
	id int identity(1,1) not null,
	nome varchar(100) not null,
	id_categoria integer not null references categoria (id),
	id_unidade_medida integer not null references Unidade_Medida(id),
	preco decimal(15,2),
	descricao varchar(500),
	constraint [pk_produto] primary key clustered (id)		
);
go



create table TipoPagamento(
	Id int identity(1,1) primary key,
	Nome_Pagamento varchar(100),
	descricao varchar(600)
)

create table Venda(
	Id int identity(1,1) primary key,
	DataPagamento  datetime,
	NomeCliente	   varchar(500),
	Id_Pagamento int references TipoPagamento(id)
)


create table Item_Venda(
	id int identity(1,1) primary key,
	Id_Produto int references Produto (id) ,
	Quantidade	int,
	Valor_Unitário decimal(9,2),
	Id_Venda int references Venda
)

create table movimentacao (
		Id_Produto int references Produto (id) ,
	Data	   datetime,
	Tipo       varchar(1),
	Quantidade_Recebida varchar
)

drop table movimentacao

