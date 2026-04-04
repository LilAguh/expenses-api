namespace Expenses.Domain.Entities;

public class Expense
{
  public int Id {get; set;}
  //numero de id
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
  public DateTime CreatedAt {get; set;}
  //fecha de creacion del ticket
}