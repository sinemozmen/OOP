using System;

namespace Sil1
{             //https://codingsight.com/tricky-questions-about-c-sharp/
   
    class A
    {
        public virtual void Abc(int q)
        {
            Console.WriteLine("abc from A");
        }
    }

    class B : A
    {
        public override void Abc(double p)//int p 
        {
            Console.WriteLine("abc from B");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 5 ;//abc from B yazacak.Çünkü double int'i karşılar.
            int i = 5;
            A b = new B();//B'de abc öethodu override edilmediği için atadakine girecek. 
            b.Abc(i);
            Console.ReadLine();
        }

    }
 
}
