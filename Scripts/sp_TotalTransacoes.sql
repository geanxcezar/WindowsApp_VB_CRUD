USE [XYZ_CreditCard]
GO

/****** Object:  StoredProcedure [dbo].[sp_TotalTransacoes]    Script Date: 04/03/2025 01:54:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_TotalTransacoes]
    @Data_Inicial DATETIME,
    @Data_Final DATETIME,
    @Status_Transacao VARCHAR(50)
AS
BEGIN
    SELECT Numero_Cartao, SUM(Valor_Transacao) AS Valor_Total, COUNT(*) AS Quantidade_Transacoes, Status_Transacao
    FROM Transacoes
    WHERE Data_Transacao BETWEEN @Data_Inicial AND @Data_Final AND Status_Transacao = @Status_Transacao
    GROUP BY Numero_Cartao, Status_Transacao;
END
GO

