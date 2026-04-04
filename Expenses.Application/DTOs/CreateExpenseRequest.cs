namespace Expenses.Application.DTOs;

public class CreateExpenseRequest
{
  public string Description {get; set;} = string.Empty;
  //string de descipcion
  public int Amount {get; set;}
  //numero de monto
  public string Category {get; set;} = string.Empty;
  //string de categoria
  public string Currency {get; set;} = "ARS";
  //string de tipo de moneda
  public string User {get; set;} = string.Empty;
  //usuario que hizo el gasto
}