this has no Database associated the project
it was added using EF core with MSSQL
and it places the local database in following
path.

Its because of how the connection string is setup for MSSQL
inside appsettings.json.

C:\Users\%username%

but to get a database you can use EF core Migration

Nuget Package manager
-------------------------------------
Add-Migration Rating
Update-Database
------------------------------------

In Terminal Vscode
----------------------------------
dotnet ef migrations add rating
dotnet ef database update
----------------------------------