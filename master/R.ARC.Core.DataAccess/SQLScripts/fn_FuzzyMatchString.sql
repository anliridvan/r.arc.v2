USE [SAM]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_FuzzyMatchString]    Script Date: 12/04/2019 09:43:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[fn_FuzzyMatchString] (@s1 varchar(255), @s2 varchar(255))
RETURNS float
AS
BEGIN
    -- written by William Talada for SqlServerCentral
	IF LEN(@s1) < 2 RETURN 0;
    DECLARE @i int, @j float;
    SET @i = 1;
    SET @j = 0;
    WHILE @i < LEN(@s1)
    BEGIN
        IF CHARINDEX(SUBSTRING(@s1,@i,2), @s2) > 0 SET @j=@j+1;
        SET @i=@i+1;
    END
    RETURN @j / (LEN(@s1) - 1);
END
