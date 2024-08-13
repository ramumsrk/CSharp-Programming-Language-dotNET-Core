# 00005-00002 Access Modifiers - Understanding Access Modifiers

## Six protection levels

00001. public
00002. protected
00003. private
00004. internal
00005. protected internal

    class A
    {
      public void FunctionA() {}
      protected void FunctionB() {}
      private void FunctionC() {}
    }

    class B : A
    {
      void FunctionBB()
      {
        FunctionA();
        FunctionB();
        FunctionC(); Compile-error
        return;
      }
    }

    class Program
    {
      static void Main()
      {
        A a = new A();

        a.FunctionA();
        a.FunctionB(); // Compile-error
        a.FunctionC(); // Compile-error
        return;
      }
    }