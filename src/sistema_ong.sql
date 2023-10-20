-- Cria o banco de dados sistema_ong
CREATE DATABASE sistema_ong;

-- Cria a tabela cadastro
CREATE TABLE cadastro (
  id INT NOT NULL, INT AUTO_INCREMENT,
  login VARCHAR(150) NOT NULL ,
  senha VARCHAR(150) NOT NULL,
  nome VARCHAR(255) NOT NULL ,
  email VARCHAR(150) NOT NULL ,
  telefone VARCHAR(9) NOT NULL ,
  PRIMARY KEY (id)
);

-- Cria a tabela cadastro_ong
CREATE TABLE cadastro_ong (
  cod_ong INT NOT NULL, INT AUTO_INCREMENT,
  endereco VARCHAR(255) NOT NULL,
  status VARCHAR(150) NOT NULL,
  PRIMARY KEY (cod_ong)
);

-- Cria a tabela cadastro_voluntario
CREATE TABLE cadastro_voluntario (
  id_voluntario INT NOT NULL, INT AUTO_INCREMENT,
  nome VARCHAR(255) NOT NULL,
  idade INT NOT NULL,
  PRIMARY KEY (id_voluntario)
);

-- Cria a tabela projeto
CREATE TABLE projeto (
  cod_projeto INT NOT NULL, INT AUTO_INCREMENT,
  ong_vinculada INT NOT NULL ,
  cidade VARCHAR(255) NOT NULL ,
  uf VARCHAR(50) NOT NULL ,
  vagas INT NOT NULL,
  PRIMARY KEY (cod_projeto)
);

-- Cria a tabela projeto_voluntario
CREATE TABLE projeto_voluntario (
  cod_projeto INT NOT NULL,
  cod_voluntario INT NOT NULL,
  PRIMARY KEY (cod_projeto, cod_voluntario)
);

-- Adiciona a restrição de verificação `idade > 0` à coluna `idade` da tabela `cadastro_voluntario`
ALTER TABLE cadastro_voluntario
ADD CONSTRAINT idade_valida CHECK (idade > 0);


--Fazendo atualização na tabela projeto, adicionando cod_ong como chave estrangeira--
ALTER TABLE projeto
ADD CONSTRAINT FK_CodOng
FOREIGN KEY (cod_ong)
REFERENCES cadastro_ong (cod_ong);


--Adiconando dados fictícios nas respectivas tabelas--


--TABELA CADASTRO--
INSERT INTO cadastro (login, senha, nome, email, telefone)
VALUES ("pessoa02", "123456", "José Silva, pessoa.02@gmail.com", "87999778072" );


--TABELA CADASTRO_ONG--

INSERT INTO cadastro_ong (cod_ong, endereco, status)
VALUES ("01", "Rua Conêgo Mariano", "Ativo");


--TABELA CADASTRO_VOLUNTARIO--

INSERT INTO cadastro_voluntario (id_voluntario, nome, idade)
VALUES ("01", "José Silva", "22");


--TABELA PROJETO--

INSERT INTO projeto (cod_projeto, ong_vinculada, cidade, uf, vagas)
VALUES ("02", "01", "São Paulo", "SP", "5");

--TABELA PROJETO_VOLUNTARIO--

INSERT INTO projeto_voluntario (cod_projeto, cod_voluntario)
VALUES ("02", "01");