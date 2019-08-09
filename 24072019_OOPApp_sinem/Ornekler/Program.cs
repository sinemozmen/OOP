using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler
{
    /******ÖRNEK 1********/

    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            B b = new B();
            b.abc(i);
            Console.ReadLine();
        }
    }

    class A
    {
        public void abc(int q)
        {
            Console.WriteLine("abc from A");
        }
    }

    class B : A
    {
        public void abc(double p)
        {
            Console.WriteLine("abc from B");
        }
    }

    /******ÖRNEK 2*********/

    //class P
    //{ }
    //class Q : P
    //{ }

    //class A
    //{
    //    public void abc(Q q)
    //    {
    //        Console.WriteLine("abc from A");
    //    }
    //}

    //class B : A
    //{
    //    public void abc(P p)
    //    {
    //        Console.WriteLine("abc from B");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        B b = new B();
    //        b.abc(new Q());
    //        Console.ReadLine();
    //    }
    //}

    /**** ÖRNEK 3 *****/

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        MyClassB b = new MyClassB();
    //        MyClassA a = b;
    //        a.Abc();
    //        Console.ReadLine();
    //    }
    //}

    //class MyClassA
    //{
    //    public MyClassA()
    //    {
    //        Console.WriteLine("constructor A");
    //    }

    //    public void Abc()
    //    {
    //        Console.WriteLine("A");
    //    }
    //}

    //class MyClassB : MyClassA
    //{
    //    public MyClassB()
    //    {
    //        Console.WriteLine("constructor B");
    //    }

    //    public void Abc()
    //    {
    //        Console.WriteLine("B");
    //    }
    //}








}


