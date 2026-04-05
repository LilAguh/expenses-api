using Expenses.Application.DTOs;
using Expenses.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Expenses.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExpensesController : ControllerBase
{
  private readonly IExpenseService _service;

  public ExpensesController(IExpenseService service)
  {
    _service = service;
  }

  [HttpPost]
  public async Task<IActionResult> CreateExpense(CreateExpenseRequest request)
  {
    var expense = await _service.CreateExpense(request);
    return Ok(expense);
  }
}