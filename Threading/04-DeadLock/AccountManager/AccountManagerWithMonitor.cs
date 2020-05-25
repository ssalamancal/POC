using System;
using System.Threading;

namespace Threading._04_DeadLock.AccountManager
{
  public class AccountManagerWithMonitor : AccountManagerBase
  {
    public AccountManagerWithMonitor(Account accountFrom, Account accountTo, double amountTransfer)
      : base(accountFrom, accountTo, amountTransfer) { }

    public override void BlockDestinationAccount()
    {
      Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on {ToAccount.ID}");
      if (Monitor.TryEnter(ToAccount, BlockingTime))
      {
        Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock on {ToAccount.ID}");
        FromAccount.WithdrawMoney(TransferAmount);
        ToAccount.DepositMoney(TransferAmount);
      }
      else
      {
        Console.WriteLine($"{Thread.CurrentThread.Name} Unable to acquire lock on {ToAccount.ID}, So existing.");
      }
    }
  }
}