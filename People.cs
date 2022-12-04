interface ITest 
{
  void TestInterface(); // interface method
}
interface ITest2
{
  void TestInterface2(); // interface method
}

abstract class People : ITest, ITest2 {
  // abstracts
  // Abstract method (does not have a body)
  public abstract void TestAbstract();

  public void TestInterface() {
    Console.WriteLine("People INTERFACE TEST");
  }

  public void TestInterface2() {
    Console.WriteLine("People INTERFACE 2 TEST");
  }
}