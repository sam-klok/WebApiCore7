Again, I'm playing with Web API and Entity Framework.
A lot of it changed for a past few years, so I need to try it under .Net 7

From design point of view, for now, I will follow tutorial and create "code first" approach.
Later I will create or modify this project to follow more real-life scenario of "database-first" design.

Thank you
Sergiy (Sam) Klok

Docs used:
1. Tutorial: Create a web API with ASP.NET Core
https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api
I also saved copy of this web site in the folder "Tutorial-Copy"

2. NuGet packages location
https://stackoverflow.com/questions/40902578/wheres-the-nuget-package-location-in-asp-net-core
Windows: %userprofile%\.nuget\packages
Or C:\Users\<user>\.nuget\packages

3. Dependency injection in ASP.NET Core
https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-7.0

4. How to properly configure the `services.AddDbContext` of `ConfigureServices` method 
https://stackoverflow.com/questions/56532595/how-to-properly-configure-the-services-adddbcontext-of-configureservices-met

5. My question: 
How to convert Web API project from EntityFramework.InMemory to Sql Server?
https://stackoverflow.com/questions/74587465/how-to-convert-web-api-project-from-entityframework-inmemory-to-sql-server

6. Code First Migrations with an existing database
https://learn.microsoft.com/en-us/ef/ef6/modeling/code-first/migrations/existing-database

6.1 Run the Add-Migration (old: Enable-Migrations) command in Package Manager Console
To undo this action, use Remove-Migration.

6.2 Run update-database in Package Manager and I got an error:
A connection was successfully established with the server, but then an error occurred during the login process. 
(provider: SSL Provider, error: 0 - The certificate chain was issued by an authority that is not trusted.)

https://stackoverflow.com/questions/17615260/the-certificate-chain-was-issued-by-an-authority-that-is-not-trusted-when-conn