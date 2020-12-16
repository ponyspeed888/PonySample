PonyDbContextScaffold useage example

This is a sample project that use PonyDbContextScaffold EF Core
*DbContext* Scaffolding.

Step One : Enable Standard EF Core DbContextScaffold

Add reference to Microsoft.EntityFrameworkCore.Design

Add reference Microsoft.EntityFrameworkCore.Sqlite

Edit project file :

change from

* \<PackageReference Include=\"Microsoft.EntityFrameworkCore.Design\"
Version=\"5.0.0\"\>*

* \<PrivateAssets\>all\</PrivateAssets\>*

* \<IncludeAssets\>runtime; build; native; contentfiles; analyzers;
buildtransitive\</IncludeAssets\>*

* \</PackageReference\>*

to

* \<PackageReference Include=\"Microsoft.EntityFrameworkCore.Design\"
Version=\"5.0.0\"\>*

* \<PrivateAssets\>all\</PrivateAssets\>*

* \</PackageReference\>*

open Nuget Package Manager or command prompt, and execute

dotnet ef dbcontext scaffold \"DataSource=TestDataBase\\movies.db\"
Microsoft.EntityFrameworkCore.SQLite \--output-dir GeneratedCodeStd
\--data-annotations \--force \--use-database-names

At this time it will generated code as standard EF Core would

***Step 2 : Use custom Code Gen***

Add reference to PonyDbContextScaffold package (check preleased)

Add reference to Microsoft.EntityFrameworkCore

Add a class that implement *IdesignTimeServices as in
*ScaffoldCustomizationExample.cs

A sample t4 based code generator is in

SampleGeneratorPartial.cs

SampleGenerator.tt

Execute the following command

dotnet ef dbcontext scaffold \"DataSource=TestDataBase\\movies.db\"
Microsoft.EntityFrameworkCore.SQLite \--output-dir GeneratedCodeCustom
\--data-annotations \--force \--use-database-names

And the generated code will be in GeneratedCodeCustom
