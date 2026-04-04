using Microsoft.EntityFrameworkCore;
using Expenses.Domain.Entities;

namespace Expenses.Infrastructure.Persistence;

public class ExpensesDbContext : DbContext
{
  public ExpensesDbContext(DbContextOptions<ExpensesDbContext> options)
    : base(options)
    {
    }
    public DbSet<Expense> Expenses => Set<Expense>();
}