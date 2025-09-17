SELECT TOP (1000) [Name]
      ,[Model]
      ,[Stock]
      ,[Price]
      ,[Concession]
  FROM [MOBILESHOPDB].[dbo].[used_mobile]
  DELETE FROM used_mobile
  WHERE Name = 'SAMSUMG'
  AND Model = 's22ultra';