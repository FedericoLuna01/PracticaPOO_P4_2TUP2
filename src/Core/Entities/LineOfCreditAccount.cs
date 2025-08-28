using Classes;

public class LineOfCreditAccount : BankAccount
{

  public override void PerformMonthEndTransactions()
  {
    if (Balance < 0)
    {
      // Se niega el balance para obtener un interés positivo
      decimal interest = -Balance * 0.07m;
      MakeWithdrawal(interest, DateTime.Now, "Cargo interés mensual");
    }
  }

  public LineOfCreditAccount(string name, decimal initialBalance) : base(name, initialBalance)
  {
  }
}