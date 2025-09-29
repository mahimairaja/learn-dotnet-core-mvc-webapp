# learn-dotnet-core-mvc-webapp
A random weekend - learning to build dotnet core mvc web app by following this youtube video - https://www.youtube.com/watch?v=QtiM87MV27w


# My notes:

## Session 1

1. Create a new mvc web app

```bash
dotnet new mvc
```

2. Add a new data model to `Models` 

```bash
dotnet new class -n Expense -o Models
```

| edit: I just came to know if we are using new class to create Model then we need to manually edit the namespace to <namespace>.Models


3. Learnt about null forgiving operator

```c#
public string Description {get; set;} 

// if we leave string without initial value compiler warns so we will add null!

public string Description {get; set;} = null!;
```

4. Learnt about data annotation using `[Requried]`

5. Will Interact with Data base using Entity Frame Core, it was mentioned as ORM. So, I assume EFC could be something like drizzle or sqlalchemy. 

6. Defined the `Expense` data model


## Session 2

6. Create new Data context - `FinanceAppContext`
```bash
dotnet new class -n FinanceAppContext -o Data`
```

7. Installed Sql Server and Tools using Nuget (I used a VS Code extention but can be installed through cli as well )

8. Created local MSSQL server using docker compose file and created a database from vscode extention gui

9. Added the connection string to appsettings.json

## Session 3

10. Installed the Entitye Framework Core tools globally

```bash
dotnet tool install --global dotnet-ef
```

11. Then as we have already defined the `Expense` data model now I added the migrated and updated the database using

```bash
dotnet ef migrations add InitialCreate # this is like git commit

dotnet ef database update # it will update my database schem according to the data model specified
```

12. Then I created a new Controller class using the command

```bash
dotnet new mvccontroller -n ExpensesController -o Controllers
```

And defined the created context to the controller

13. Created a new razor page in the Views using

```bash
dotnet new view -n Index -o Views/Expenses
```

This command creates a new Razor page - Index.cshtml under the Views/Expenses dir

So what happens in Controllers here are defining the routes, so for example if I am going to /<controller_name> the method `ActionResult` routes to  Index view 

Also the routing pattern is specified in program.cs in `MapControllerRoute`

## Session 4

14. Added new Create controller to add new data to the context using Controller and Create Razor page.

