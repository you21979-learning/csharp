using System;
namespace MyNamespace
{
  // define class
  public class MyStaticClass
  {
    public const int version = 1;
    public const string name = "MyStaticClass";

    private static int uptime;
    static MyStaticClass ()
    {
      Console.WriteLine("MyStaticClass ctor");
      uptime = 0;
    }
    public static void MyMethod ()
    {
      uptime++;
      Console.WriteLine("MyStaticClass.MyMethod");
    }
  }
}
