USE [XYZ_CreditCard]
GO

/****** Object:  UserDefinedFunction [dbo].[fn_TransacoesCategorizadas]    Script Date: 04/03/2025 01:57:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[fn_TransacoesCategorizadas](@Data_Inicial DATETIME, @Data_Final DATETIME)
RETURNS TABLE
AS
RETURN (
    SELECT *, dbo.fn_CategoriaValor(Valor_Transacao) AS Categoria
    FROM Transacoes
    WHERE Data_Transacao BETWEEN @Data_Inicial AND @Data_Final
);
GO

