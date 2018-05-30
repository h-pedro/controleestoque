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

create Table Unidade_Medida(
	id int identity(1,1) primary key,
	nome varchar(200),
	sigla varchar(10)
);
go

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
);
go

create table Venda(
	Id int identity(1,1) primary key,
	DataPagamento  datetime,
	NomeCliente	   varchar(500),
	Id_Pagamento int references TipoPagamento(id)
);
go

create table Item_Venda(
	id int identity(1,1) primary key,
	Id_Produto int references Produto (id) ,
	Quantidade	int,
	Valor_Unitário decimal(9,2),
	Id_Venda int references Venda
);
go

create table movimentacao (
	id int identity(1,1) not null,
	Id_Produto int not null references Produto (id),
	Data	   datetime not null default getdate(),
	Tipo       varchar(1) not null,
	Quantidade int not null
);
go

-- campo calculado que retorna a quantidade em estoque de produto
IF OBJECT_ID(N'dbo.get_estoque', N'FN') IS NOT NULL
    DROP FUNCTION [dbo].[get_estoque]
GO

create function [dbo].[get_estoque](@id_produto int) returns int
as
begin
    return (
		select coalesce(sum(coalesce(case when tipo = 'E' then quantidade else quantidade * -1 end, 0)), 0) as quantidade from movimentacao where id_produto = @id_produto
    );
end
go

-- criando campo de quantidade em estoque calculado
alter table produto add qtd_estoque as dbo.[get_estoque](id);
go