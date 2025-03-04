USE [XYZ_CreditCard]
GO

/****** Object:  StoredProcedure [dbo].[MostrarTransacoes]    Script Date: 04/03/2025 01:55:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MostrarTransacoes]
AS
BEGIN
    -- Seleciona todas as transações
    SELECT
        Id_Transacao AS [ID Transação] , 
        Numero_Cartao AS [Nº Catão],
        Valor_Transacao AS [Valor Transação],
        Data_Transacao AS [Data Transação],
        Descricao AS [Descrição],
        Status_Transacao AS [Status]
    FROM
        Transacoes;
END
GO

