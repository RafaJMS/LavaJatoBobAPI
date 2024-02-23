create database LavaJatoBob

use LavaJatoBob

CREATE TABLE [Clientes] (
  [id] integer PRIMARY KEY IDENTITY(1, 1),
  [nome] text,
  [cpf] varchar(11),
)
GO

CREATE TABLE [Veiculos] (
  [id] integer PRIMARY KEY IDENTITY(1, 1),
  [tipo] varchar(25),
  [modelo] text,
  [placa] varchar(7),
  [preco] decimal(10,2),
  [id_cliente] integer,
  [id_funcionario] integer,
)
GO

CREATE TABLE [Funcionarios] (
  [id] integer PRIMARY KEY IDENTITY(1, 1),
  [nome] text,
  [cpf] varchar(11),
  [telefone] decimal(11,0),
  [email] varchar(50),
  [salario] decimal(10,2),
)
GO

ALTER TABLE [Veiculos] ADD FOREIGN KEY ([id_cliente]) REFERENCES [Clientes] ([id])
GO

ALTER TABLE [Veiculos] ADD FOREIGN KEY ([id_funcionario]) REFERENCES [Funcionarios] ([id])
GO

-- Inserir dados na tabela Clientes
INSERT INTO Clientes (nome, cpf) VALUES 
('João da Silva', '12345678901'),
('Maria Oliveira', '98765432109'),
('Pedro Santos', '56789012345');

-- Inserir dados na tabela Funcionarios
INSERT INTO Funcionarios (nome, cpf, telefone, email, salario) VALUES 
('Ana Souza', '09876543210', 11987654321, 'ana@example.com', 3500.00),
('Carlos Pereira', '54321098765', 11876543210, 'carlos@example.com', 4000.00),
('Mariana Costa', '23456789012', 11765432109, 'mariana@example.com', 3800.00);

-- Inserir dados na tabela Veiculos
INSERT INTO Veiculos (tipo, modelo, placa, preco, id_cliente, id_funcionario) VALUES 
('Sedan', 'Toyota Corolla', 'ABC1234', 50000.00, 1, 2),
('SUV', 'Honda CR-V', 'DEF5678', 60000.00, 2, 3),
('Hatchback', 'Volkswagen Golf', 'GHI9012', 45000.00, 3, 1);
