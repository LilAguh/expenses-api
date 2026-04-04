namespace Expenses.Doomain.Entities;

public class Expense
{
  public int Id {get; set;}
  public string Description {get; set;} = string.Empty;
  public int Amount {get; set;}
  public string Category {get; set;} = string.Empty;
  public string Currency {get; set;} = "ARS";
  public DateTime CreatedAt {get; set;}
}