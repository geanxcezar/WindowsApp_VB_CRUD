USE [XYZ_CreditCard]
GO

/****** Object:  StoredProcedure [dbo].[ExcluirTransacao]    Script Date: 04/03/2025 01:56:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ExcluirTransacao]
    @Id_Transacao INT
AS
BEGIN
    -- Verifica se a transação existe
    IF EXISTS (SELECT 1 FROM Transacoes WHERE Id_Transacao = @Id_Transacao)
    BEGIN
        -- Exclui a transação com o Id_Transacao especificado
        DELETE FROM Transacoes
        WHERE Id_Transacao = @Id_Transacao;

        -- Retorna uma mensagem de sucesso
        SELECT 'Transação excluída com sucesso!' AS Mensagem;
    END
    ELSE
    BEGIN
        -- Retorna uma mensagem se a transação não for encontrada
        SELECT 'Transação não encontrada.' AS Mensagem;
    END
END
GO

