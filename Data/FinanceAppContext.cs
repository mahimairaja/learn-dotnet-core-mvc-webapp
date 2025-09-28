using Microsoft.EntityFrameworkCore;

namespace learn_dotnet_core_mvc_webapp.Models;

public class FinanceAppContext: DbContext
{
    public FinanceAppContext(DbContextOptions<FinanceAppContext> options): base(options) {}

    public DbSet<Expense> Expenses {get; set;}

}
