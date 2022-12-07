**Criar banco de dados:
CREATE DATABASE TesteSegurancaBE11;

**Acessar o banco de dados TesteSegurancaBE11:
USE TesteSegurancaBE11;

/* Criar Tabela)*/
CREATE TABLE Usuarios
(
        Id INT PRIMARY KEY IDENTITY,
	Email VARCHAR(100) UNIQUE NOT NULL,
	Senha VARCHAR(50) NOT NULL
);

/*Inserir (Insert), valores na tabela:*/
INSERT INTO Usuarios VALUES ('brasilHexacampeao@email.com','007');

/*Selecionar as colunas e tuplas da tabela Usuarios:*/
SELECT * FROM Usuarios;

/* Modelos de como hashear a senha*/

/*O MD2 é um algoritmo de hash que cria um valor de hash de 128 bits*/
SELECT Email, HASHBYTES('MD2',Senha) FROM Usuarios;

/*O MD4 é um algoritmo de hash que cria um valor de hash de 128 bits funciona semelhante ao algoritmo de MD2 */
SELECT Email, HASHBYTES('MD4',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id=1;






