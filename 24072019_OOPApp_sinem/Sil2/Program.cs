using System;

namespace Sil2
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.abc(new P());
            Console.ReadLine();
        }
    }
    class P
    { }
    class Q : P
    { }

    class A
    {
        public void abc(P p)
        {
            Console.WriteLine("abc from A");
        }
    }
    class B : A
    {
        public void abc(Q q)
        {
            Console.WriteLine("abc from B");
        }
    }
}
