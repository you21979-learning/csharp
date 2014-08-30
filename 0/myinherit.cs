using System;
namespace MyInherit
{
  class Base
  {
    public Base()
    {
      Console.Write("base ctor called\n");
    }
  }
  class Derived : Base
  {
    public Derived()
    {
       Console.Write("derived ctor called\n");
    }
  }
}
