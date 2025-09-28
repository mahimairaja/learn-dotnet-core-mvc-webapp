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


3. Learnt about null forgiving operator

```c#
public string Description {get; set;} 

// if we leave string without initial value compiler warns so we will add null!

public string Description {get; set;} = null!;
```

4. Learnt about data annotation using `[Requried]`

5. Will Interact with Data base using Entity Frame Core, it was mentioned as ORM. So, I assume EFC could be something like drizzle or sqlalchemy. 


## Session 2

6. Create new Data context - `FinanceAppContext`
```bash
dotnet new class -n FinanceAppContext -o Data`
```

7. Installed Sql Server and Tools using Nuget (I used a VS Code extention but can be installed through cli as well )

8. Created local MSSQL server using docker compose file and created a database from vscode extention gui

9. Added the connection string to appsettings.json

## Session 3

