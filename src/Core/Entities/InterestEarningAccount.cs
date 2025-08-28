using Classes;

public class InterestEarningAccount : BankAccount
{

  public override void PerformMonthEndTransactions()
  {
    if (Balance > 500m)
    {
      decimal interest = Balance * 0.02m;
      MakeDeposit(interest, DateTime.Now, "Interés mensual");
    }
  }

  public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
  {
  }
}