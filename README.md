# GroceryAPI
Grocery API
This API performs CURD operation with PATCH (to modify few columns in the database)

Tech Stack- (C#.NET Core 3.1, SQL Server, PostMan, IIS Server)

Extensions needed- 
Microsoft.AspNetCore.JsonPatch (5.0.0)
Microsoft.AspNetCore.Mvc.NewtonsoftJson (3.1.10)
Microsoft.EntityFrameworkCore (5.0.0)
Microsoft.EntityFrameworkCore.Design (5.0.0)
Microsoft.EntityFrameworkCore.SqlServer (5.0.0)
Microsoft.EntityFrameworkCore.Tools (5.0.0)
AutoMapper.Extensions.Microsoft.DependencyInjection (8.1.0)

Database- CREATE TABLE [dbo].[Grocerys](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Weight] [int] NOT NULL,
	[WarehousePrice] [float] NOT NULL,
	[InstantSaving] [float] NOT NULL,
	[YourCost] [float] NOT NULL,
	[CurrentInventory] [float] NOT NULL,
 CONSTRAINT [PK_Grocerys] PRIMARY KEY CLUSTERED 
(	[Id]))

Create Grocery item, here database has identity for Id column (automatically increments Id value) so don’t provide Id value in the JSON input 
Get All Grocery items, Get Grocery item with Id-3, Delete the Grocery item with Id-7,
Update few fields of the Grocery item, here weight, warehouse price and instant saving fields are updated
 




