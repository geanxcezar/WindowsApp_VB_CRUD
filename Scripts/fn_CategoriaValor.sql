USE [XYZ_CreditCard]
GO

/****** Object:  UserDefinedFunction [dbo].[fn_CategoriaValor]    Script Date: 04/03/2025 01:57:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[fn_CategoriaValor](@Valor DECIMAL(18, 2))
RETURNS VARCHAR(50)
AS
BEGIN
    RETURN CASE
        WHEN @Valor > 2000 THEN 'Premium'
        WHEN @Valor BETWEEN 1000 AND 2000 THEN 'Alta'
        WHEN @Valor BETWEEN 500 AND 1000 THEN 'Média'
        ELSE 'Baixa'
    END;
END
GO

