using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sil4
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class A
    {
        protected internal void MethodA()
        {
            return;
        }
    }
    public class B : A
    {
        public void MethodB()
        {
            this.MethodA();
            A a1 = new A();
            a1.MethodA();//Internal olmasaydı göremezdik.Protected tanımlanmış verilen instance 
                        //alındığında başka bir sınıftan erişilemez.
        }
    }
    public class D : B
    {
        public void MethodD()
        {
            this.MethodA();
            A a1 = new A();
            a1.MethodA();
        }
    }
    public class E : B
    {
        public void MethodE()
        {
            this.MethodA();
            A a1 = new A();
            a1.MethodA();
        }
    }
}
