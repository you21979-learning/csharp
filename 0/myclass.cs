using System;
namespace MyNamespace
{
  // define class
  public class MyClass
  {
    public MyClass ()
    {
      Console.WriteLine("ctor called");
    }
    ~MyClass ()
    {
      Console.WriteLine("dtor called");
    }
    public void MyMethod ()
    {
      Console.WriteLine("mymethod called");
    }
  }
}
