using Expenses.Application.DTOs;
using Expenses.Application.Interfaces;
using Expenses.Domain.Entities;

namespace Expenses.Application.Services;

public class ExpenseService : IExpenseService
{
  public Expense CreateExpense(CreateExpenseRequest request)
  {
    var expense = new Expense
    {
      Description = request.Description,
      Amount = request.Amount,
      Category = request.Category,
      Currency = request.Currency,
      User = request.User,
      CreatedAt = DateTime.UtcNow
    };
    return expense;
  }
}