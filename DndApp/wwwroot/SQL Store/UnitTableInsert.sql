SELECT TOP (1000) [UnitID]
      ,[Name]
      ,[Faction]
      ,[Cost]
      ,[Upkeep]
      ,[Wounds]
      ,[Armour]
      ,[Shield]
      ,[NumAttacks]
      ,[Attack]
      ,[Defence]
      ,[Range]
      ,[Accuracy]
      ,[Shots]
      ,[Leadership]
      ,[Movement]
      ,[Charge]
  FROM [DND].[dbo].[Units]


  insert into Units 
  Values 
  ('Spearmen', 'Empire', 40, 5, 2, 5, 0, 1, 4, 4, 0, 0, 0, 8, 8, 1)