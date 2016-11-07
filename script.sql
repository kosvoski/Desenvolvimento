USE [master]
GO

CREATE DATABASE [desenvolvimento]
GO

USE [desenvolvimento]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Funcionario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[foto] [nvarchar](100) NULL,
	[nome_completo] [nvarchar](60) NOT NULL,
	[endereco] [nvarchar](60) NULL,
	[cidade] [nvarchar](60) NULL,
	[descricao_cargo] [nvarchar](1000) NULL,
	[salario] [money] NULL,
	[cep] [nchar](9) NULL,
	[telefone] [nvarchar](13) NULL,
 CONSTRAINT [PK_Funcionario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
