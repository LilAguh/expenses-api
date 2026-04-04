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
  public IActionResult CreateExpense(CreateExpenseRequest request)
  {
    var expense = _service.CreateExpense(request);
    return Ok(expense);
  }
}