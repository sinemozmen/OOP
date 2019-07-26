using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject3
{   
    public class BAU
    {//Bu class veri üretmek için hazırlanmıştır.

        string[] Adlar = { "Şamil", "Cemal", "Ali", "Murat", "Kemal", "Şahin", "Hüseyin" };
        string[] Soyadlar = { "Yıldız", "Erkmen", "Kahraman", "Erdemir" };
        string[] Sehirler = { "Ankara", "İstanbul", "İzmir", "Eskişehir", "Adana" };

        static Random rnd = new Random();

        public string GetName()
        {
            int rndIndex = rnd.Next(0, Adlar.Length);
            return Adlar[rndIndex];
        }
        public string GetSurname()
        {
            int sayi = rnd.Next(0, Soyadlar.Length);
            return Soyadlar[sayi];
        }
        public string GetCity()
        {
            int sayi2 = rnd.Next(0, Sehirler.Length);
            return Sehirler[sayi2];
        }
        public DateTime GetBackDate(int year)
        {
            int randomYil = rnd.Next(0, year);
            DateTime myDate = DateTime.Now;
            DateTime newDate = myDate.AddYears(-randomYil);
            return newDate;
        }
        public DateTime GetForwardDate(int year)
        {
            int randomYil = rnd.Next(0, year);
            return DateTime.Now.AddYears(randomYil);
        }
        public LifeDurationInfo GetLifeDurations(DateTime birthDate)
        {
            LifeDurationInfo lfd = new LifeDurationInfo();

            int ty = DateTime.Now.Year - birthDate.Year;
            lfd.calculatedAge = ty;

            TimeSpan ts = DateTime.Now.Subtract(birthDate);
            
            double td = ts.TotalDays;
            lfd.calculatedDays = td;

            double th = ts.TotalHours;
            lfd.calculatedHours = th;

            double tm = ts.TotalMinutes;
            lfd.calculatedMinutes = tm;

            double tsc = ts.TotalSeconds;
            lfd.calculatedSeconds = tsc;

            double tmsc = ts.TotalMilliseconds;
            lfd.calculatedMiliseconds = tmsc;

            return lfd;
        }
    }
}
