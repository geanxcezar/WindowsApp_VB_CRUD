USE [XYZ_CreditCard]
GO

/****** Object:  StoredProcedure [dbo].[AlterarTransacao]    Script Date: 04/03/2025 01:56:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AlterarTransacao]
    @Id_Transacao INT,
    @Numero_Cartao CHAR(16),
    @Valor_Transacao DECIMAL(18, 2),
    @Data_Transacao DATETIME,
    @Descricao VARCHAR(255),
    @Status_Transacao VARCHAR(50)
AS
BEGIN
    -- Atualiza os dados da transação com base no Id_Transacao
    UPDATE Transacoes
    SET
        Numero_Cartao = @Numero_Cartao,
        Valor_Transacao = @Valor_Transacao,
        Data_Transacao = @Data_Transacao,
        Descricao = @Descricao,
        Status_Transacao = @Status_Transacao
    WHERE
        Id_Transacao = @Id_Transacao;

    -- Retorna uma mensagem de sucesso
    SELECT 'Transação atualizada com sucesso!' AS Mensagem;
END
GO

