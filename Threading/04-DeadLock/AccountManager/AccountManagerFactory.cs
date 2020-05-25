using System;

namespace Threading._04_DeadLock.AccountManager
{
  public static class AccountManagerFactory
  {
    public static AccountManagerBlockingType AccountManagerBlockingType { get; set; }

    public static IAccountManager Create(Account accountFrom, Account accountTo, double amountTransfer)
    {
      return AccountManagerBlockingType switch
      {
        AccountManagerBlockingType.WithBlockStatement => new AccountManagerWithBlock(accountFrom, accountTo, amountTransfer),
        AccountManagerBlockingType.WithMonitorStatement => new AccountManagerWithMonitor(accountFrom, accountTo, amountTransfer),
        _ => throw new NotImplementedException(),
      };
    }
  }
}
