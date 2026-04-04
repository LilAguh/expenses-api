namespace Expenses.Doomain.Entities;

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
  public DateTime CreatedAt {get; set;}
  //fecha de creacion del ticket
}