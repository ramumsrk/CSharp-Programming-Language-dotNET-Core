namespace ClassB;

public class ClassB : ClassA.ClassA
{
  protected void ClassBFunctionB()
  {
    ClassAFunctionA();
    ClassAFunctionB();
    return;
  }
}
