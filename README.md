# DesafioCRUD
CRUD C# - Desafio Precisão Sistemas
Este é meu projeto para o desafio de se criar um CRUD em C#, utilizando um banco SQL. Estas foram as regras propostas:
Criar um CRUD de cliente que deve relacionar-se com uma tabela de gêneros conforme os requisitos abaixo.
Condições
• A aplicação precisa ser feita para desktop usando C# e banco de dados SQL;
• Deve ser possível incluir, alterar, consultar e excluir cadastros de clientes.

Cadastro de cliente
• Campos: Nome, Sobrenome, Gênero, Data de nascimento, Endereço e Número.
Consulta de cliente
• Campos: Código, Nome completo (nome seguido do sobrenome), Idade e descrição do Gênero.

Observação:
• Não é necessário fazer um CRUD da tabela Gênero, porém é necessário que ela exista no banco de dados com as seguintes colunas: código e descrição.
• O valor do campo Gênero presente na tabela de cliente deve ser uma chave estrangeira com origem na tabela de Gênero.

Sobrou tempo e quer ir além?
• Implementar testes de unidade
• Disponibilizar o repositório no github
• Tratar usabilidade do layout
-------------------------------------------------------------------------------------------------------------------------------------------------------
Comando para a criação do banco de dados em Microsoft SQL Server:
CREATE TABLE [Genero](
	[Id] INT PRIMARY KEY IDENTITY(1,1),
	[Descricao] VARCHAR(100) NOT NULL 
);

CREATE TABLE [Cliente](
	[Id] INT PRIMARY KEY IDENTITY(1,1),
	[Nome] VARCHAR(100) NOT NULL,
	[Sobrenome] VARCHAR(50) NOT NULL,
	[GeneroId] INT NOT NULL,
	[DataNascimento] DATE NOT NULL,
	[Endereco] VARCHAR(100) NOT NULL,
	[Numero] VARCHAR(10) NOT NULL,
	[Cep] CHAR(8) NOT NULL,
	[Bairro] VARCHAR(50) NOT NULL,
	[Eliminado] BIT NOT NULL DEFAULT 0,
	CONSTRAINT [FK_Cliente_Genero_GeneroId] FOREIGN KEY ([GeneroId]) REFERENCES [Genero] ([Id]) ON DELETE NO ACTION
);
