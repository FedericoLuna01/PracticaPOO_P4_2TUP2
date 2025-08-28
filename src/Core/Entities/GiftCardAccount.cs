using Classes;

public class GiftCardAccount : BankAccount
{
  private readonly decimal _monthlyDeposit = 0m;

  public override void PerformMonthEndTransactions()
  {
    if (_monthlyDeposit != 0)
    {
      MakeDeposit(_monthlyDeposit, DateTime.Now, "Deposito mensual");
    }
  }

  public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) : base(name, initialBalance)
    => _monthlyDeposit = monthlyDeposit;
}