USE [XYZ_CreditCard]
GO

/****** Object:  View [dbo].[vw_TransacoesConsolidadas]    Script Date: 04/03/2025 01:59:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vw_TransacoesConsolidadas] AS
SELECT Numero_Cartao, SUM(Valor_Transacao) AS Valor_Total, COUNT(*) AS Quantidade_Transacoes, Status_Transacao
FROM Transacoes
GROUP BY Numero_Cartao, Status_Transacao;
GO

