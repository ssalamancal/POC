using System;
using System.Threading;

namespace Threading._04_DeadLock.AccountManager
{
  public abstract class AccountManagerBase : IAccountManager
  {
    protected Account FromAccount;
    protected Account ToAccount;
    protected double TransferAmount;
    protected TimeSpan BlockingTime = new TimeSpan(0, 0, 3);

    public AccountManagerBase(Account AccountFrom, Account AccountTo, double AmountTransfer)
    {
      FromAccount = AccountFrom;
      ToAccount = AccountTo;
      TransferAmount = AmountTransfer;
    }

    public void FundTransfer()
    {
      BlockFromAccount();
    }

    private void BlockFromAccount()
    {
      Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on {FromAccount.ID}");
      lock (FromAccount)
      {
        Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock on {FromAccount.ID}");
        Console.WriteLine($"{Thread.CurrentThread.Name} Doing Some work");
        Thread.Sleep(BlockingTime);

        BlockDestinationAccount();
      }
    }

    public abstract void BlockDestinationAccount();
  }
}
