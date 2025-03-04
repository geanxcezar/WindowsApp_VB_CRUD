USE [XYZ_CreditCard]
GO

/****** Object:  StoredProcedure [dbo].[InserirTransacao]    Script Date: 04/03/2025 01:56:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- Criação da Stored Procedure
CREATE PROCEDURE [dbo].[InserirTransacao]
    @Numero_Cartao CHAR(16),
    @Valor_Transacao DECIMAL(18, 2),
    @Data_Transacao DATETIME,
    @Descricao VARCHAR(255),
    @Status_Transacao VARCHAR(50)
AS
BEGIN
    INSERT INTO Transacoes (Numero_Cartao, Valor_Transacao, Data_Transacao, Descricao, Status_Transacao)
    VALUES (@Numero_Cartao, @Valor_Transacao, @Data_Transacao, @Descricao, @Status_Transacao);

    SELECT SCOPE_IDENTITY() AS Id_Transacao;
END
GO

