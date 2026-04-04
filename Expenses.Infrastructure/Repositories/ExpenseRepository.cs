using Expenses.Application.Interfaces;
using Expenses.Domain.Entities;
using Expenses.Infrastructure.Persistence;

namespace Expenses.Infrastructure.Repositories;

public class ExpenseRepository : IExpenseRepository
{
  private readonly ExpensesDbContext _context;
  
  public ExpenseRepository(ExpensesDbContext context)
  {
    _context = context;
  }

  public async Task<Expense> CreateAsync(Expense expense)
  {
    _context.Expenses.Add(expense);
    await _context.SaveChangesAsync();
    return expense;
  }
}