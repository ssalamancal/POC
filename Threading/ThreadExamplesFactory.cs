using Threading._02_Contructor__Parameters_and_Return;
using Threading._03_Protect_shared_resources;
using Threading._04_DeadLock;
using Threading._04_DeadLock.AccountManager;
using Threading._05_Performance_and_Thread_Pooling;

namespace Threading._01_Basic_Concepts
{
  public static class ThreadExamplesFactory
  {
    public static IThreadProbeOfConcept Create(ThreadConcept concept)
    {
      return concept switch
      {
        ThreadConcept.MainThread => new MainThread(),
        ThreadConcept.MultiThread => new MultiThread(),
        ThreadConcept.ThreadConstructor => new ThreadConstructor(),
        ThreadConcept.StartThreadWithUnsafeParameters => new StartThreadWithUnsafeParameters(),
        ThreadConcept.StartThreadWithSafeParameters => new StartThreadWithSafeParameters(),
        ThreadConcept.ThreadReturnsResult => new ThreadReturnsResult(),
        ThreadConcept.ThreadShowUnsafeMessage => new ThreadShowUnsafeMessage(),
        ThreadConcept.ThreadShowSafeMessage => new ThreadShowSafeMessage(),
        ThreadConcept.ThreadIncrementCount => new ThreadIncrementCount(),
        ThreadConcept.ProcessBlockedByMonitor => new ProcessBlockedByMonitor(),
        ThreadConcept.ProcessBlockedByMutex => new ProcessBlockedByMutex(),
        ThreadConcept.ProcessBlockedBySemaphore => new ProcessBlockedBySemaphore(),
        ThreadConcept.ExampleDeadLockBlockStatement => new DeadLockDemo(AccountManagerBlockingType.WithBlockStatement),
        ThreadConcept.ExampleDeadLockMonitorStatement => new DeadLockDemo(AccountManagerBlockingType.WithMonitorStatement),
        ThreadConcept.PerformanceSumWithoutThread => new PerformanceSumWithoutThread(),
        ThreadConcept.PerformanceSumWithThread => new PerformanceSumWithThread(),
        ThreadConcept.PerformanceSumWithThreadPool => new PerformanceSumWithThreadPool(),
        _ => throw new System.NotImplementedException(),
      };
    }
  }
}
