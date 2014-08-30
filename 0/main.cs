using System;

public class Sample
{
  public static void Main(string[] args)
  {
    var mc = new MyNamespace.MyClass();
    mc.MyMethod();

    var mi = new MyInherit.Base();
    var md = new MyInherit.Derived();

    MyNamespace.MySingleton.MyMethod();

    Console.WriteLine("exit");
  }
}
