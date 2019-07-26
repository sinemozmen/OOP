using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisanlar cls = new Calisanlar();
            int maas = cls.CalisanMaaslari("İdari Personel");
            Console.WriteLine(maas);
            Console.ReadLine();

            Siniflar snf = new Siniflar();
            Dictionary<int, string>  dOgrenci = snf.OgrCalListesi("503");
            foreach (var item in dOgrenci)
            {
                Console.WriteLine("Öğrenci No: " + item.Key + " - " + "Öğrenci Adı: " + item.Value);
            }

            Console.WriteLine();

            Console.WriteLine("Demirbaşlar: " + snf.DemirbaslarGoster());

            Console.ReadLine();
        }
    }
}
