/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Username]
      ,[Surname]
      ,[Score]
  FROM [Quiz].[dbo].[Users]