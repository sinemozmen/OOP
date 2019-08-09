using Sil4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sil5
{
    class Program
    {
        static void Main(string[] args)
        {
            A a2 = new A();
            a2.MethodA(); // Sil4'teki method protected internal.Bu projede protected olarak davarancağı için 
            //instance oluşturarak MethodA()'ya ulaşamıyorum.
        }
    }
    class C : A
    {
        public void MethodC()
        {
            this.MethodA();
            return;
        }
    }
}
