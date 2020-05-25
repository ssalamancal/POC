using Threading._01_BasicConcepts;

namespace Threading._01_Basic_Concepts
{
  public class MainThread : BasicConceptsOperations, IThreadProbeOfConcept
  {
    public void Execute()
    {
      Method1();
      Method2();
      Method3();
    }
  }
}
