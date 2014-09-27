create table Fornecedor(
	IdFornecedor	int identity not null,
	Nome			nvarchar(50) not null,
	Constraint IdFornecedor Primary Key(IdFornecedor)
)

create table Produto(
	IdProduto	int identity not null,
	Nome		nvarchar(50) not null,
	Preco		decimal(18,2) not null,
	DataCompra	datetime not null,
	IdFornecedor int not null,
	Constraint IdProduto Primary Key(IdProduto)
)

alter table Produto 
	add constraint Fornecedor_Produto_fk
	foreign key(IdFornecedor) references Fornecedor(IdFornecedor)

	on delete no action
	on update no action