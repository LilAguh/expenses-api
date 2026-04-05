using Expenses.Application.DTOs;
using Expenses.Domain.Entities;

namespace Expenses.Application.Interfaces;

public interface IExpenseService
{
  Task<Expense> CreateExpense(CreateExpenseRequest request);
}