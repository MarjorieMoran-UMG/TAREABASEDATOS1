/****** Script for SelectTopNRows command from SSMS  ******/
SELECT *
  FROM [dbprogra1a].[dbo].[tb_estudiantes1]
  where parcial2 > 15
  order by parcial2 desc 