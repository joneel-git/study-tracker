this has no database associated with the project its using
local database in MSSQL in order to create a database 
you can do following---

1. Recreate the databse with EF core

----------------------------------
Add-Migration databaseName
Update-Database
----------------------------------

this will create database in location because of 
how the connection string is setup on appsettings.json

C:\Users\%username%