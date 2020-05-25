using System;
using System.Threading;
using Threading._04_DeadLock.AccountManager;

namespace Threading._04_DeadLock
{
  public class DeadLockDemo : IThreadProbeOfConcept
  {
    public DeadLockDemo(AccountManagerBlockingType accountManagerBlockingType)
    {
      AccountManagerBlockingType = accountManagerBlockingType;
    }
    public AccountManagerBlockingType AccountManagerBlockingType { set => AccountManagerFactory.AccountManagerBlockingType = value; }

    public void Execute()
    {

      Console.WriteLine("Main Thread Started");
      Account Account1001 = new Account(1001, 5000);
      Account Account1002 = new Account(1002, 3000);

      IAccountManager accountManager1 = AccountManagerFactory.Create(Account1001, Account1002, 5000);
      IAccountManager accountManager2 = AccountManagerFactory.Create(Account1002, Account1001, 6000);

      Thread thread1 = new Thread(accountManager1.FundTransfer) { Name = "Thread 1" };
      Thread thread2 = new Thread(accountManager2.FundTransfer) { Name = "Thread 2" };

      thread1.Start();
      thread2.Start();

      thread1.Join();
      thread2.Join();

      Console.WriteLine("Main Thread Completed");
    }
  }
}
