using Expenses.Domain.Entities;

namespace Expenses.Application.Interfaces;

public interface IExpenseRepository
{
  Task<Expense> CreateAsync(Expense expense);
}