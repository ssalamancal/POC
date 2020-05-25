using System;
using System.Threading;

namespace Threading._04_DeadLock.AccountManager
{
  public class AccountManagerWithBlock : AccountManagerBase
  {
    public AccountManagerWithBlock(Account accountFrom, Account accountTo, double amountTransfer)
      : base(accountFrom, accountTo, amountTransfer) { }

    public override void BlockDestinationAccount()
    {
      Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on {ToAccount.ID}");
      lock (ToAccount)
      {
        Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock on {ToAccount.ID}");
        FromAccount.WithdrawMoney(TransferAmount);
        ToAccount.DepositMoney(TransferAmount);
      }
    }
  }
}