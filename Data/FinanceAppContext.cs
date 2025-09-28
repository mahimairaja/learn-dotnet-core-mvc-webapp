using Microsoft.EntityFrameworkCore;

namespace learn_dotnet_core_mvc_webapp;

public class FinanceAppContext: DbContext
{
    public FinanceAppContext(DbContextOptions<FinanceAppContext> options): base(options) {}

    DbSet<Expense> Expenses {get; set;}

}
