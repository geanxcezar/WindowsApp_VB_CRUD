USE [XYZ_CreditCard]
GO

/****** Object:  StoredProcedure [dbo].[PesquisaTransacoes]    Script Date: 04/03/2025 01:55:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PesquisaTransacoes]
    @Pesquisa VARCHAR(50)
AS
BEGIN
    SELECT
        Id_Transacao AS [ID Transação], 
        Numero_Cartao AS [Nº Cartão],
        Valor_Transacao AS [Valor Transação],
        Data_Transacao AS [Data Transação],
        Descricao AS [Descrição],
        Status_Transacao AS [Status]
    FROM
        Transacoes
    WHERE
        CAST(Numero_Cartao AS VARCHAR(50)) + 
        CAST(Valor_Transacao AS VARCHAR(50)) + 
        CAST(Data_Transacao AS VARCHAR(50)) + 
        Descricao + 
        Status_Transacao 
        LIKE '%' + @Pesquisa + '%'
END
GO

