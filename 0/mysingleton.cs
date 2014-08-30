using System;
namespace MyNamespace
{
  // define class
  public class MySingleton
  {
    public const int version = 1;
    public const string name = "MySingleton";

    private static int uptime;
    static MySingleton ()
    {
      Console.WriteLine("MySingleton ctor");
      uptime = 0;
    }
    public static void MyMethod ()
    {
      uptime++;
      Console.WriteLine("MySingleton.MyMethod");
    }
  }
}
