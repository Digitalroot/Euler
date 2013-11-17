using System;

namespace Demo
{
  class Program
  {
    static void Main(string[] args)
    {
      Child c = new Child();
      c.A();
      c.B();
      Console.ReadKey();

    }
  }

  delegate void Printer(string s);
  
  class Parent
  {
    public void A()
    {
      Console.WriteLine("Parent.A()");
      B();
    }

    public virtual void B()
    {
      Console.WriteLine("Parent.B()");
    }
  }

  class Child : Parent
  {
    public override void B()
    {
      Console.WriteLine("Child.B()");
    }
  }

}
