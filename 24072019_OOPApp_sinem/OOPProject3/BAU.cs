using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject3
{   
    public class BAU
    {//Bu class veri üretmek için hazırlanmıştır.

       static string[] Adlar = { "Şamil", "Cemal", "Ali", "Murat", "Kemal", "Şahin", "Hüseyin" };
        static string[] Soyadlar = { "Yıldız", "Erkmen", "Kahraman", "Erdemir" };
        static string[] Sehirler = { "Ankara", "İstanbul", "İzmir", "Eskişehir", "Adana","Konya","Uşak","Denizli"};
        public static string[] SehirlerArray
        {
            get
            {
                return Sehirler;
            }
        }


        static Random rnd = new Random();

        public static  string GetName()
        {
            int rndIndex = rnd.Next(0, Adlar.Length);
            return Adlar[rndIndex];
        }
        public static string GetSurname()
        {
            int sayi = rnd.Next(0, Soyadlar.Length);
            return Soyadlar[sayi];
        }
        public static string GetCity()
        {
            int sayi2 = rnd.Next(0, Sehirler.Length);
            return Sehirler[sayi2];
        }
        public static DateTime GetBackDate(int year)
        {
            int randomYil = rnd.Next(0, year);
            DateTime myDate = DateTime.Now;
            DateTime newDate = myDate.AddYears(-randomYil);
            return newDate;
        }
        public static DateTime GetForwardDate(int year)
        {
            int randomYil = rnd.Next(0, year);
            return DateTime.Now.AddYears(randomYil);
        }
        public static LifeDurationInfo GetLifeDurations(DateTime birthDate)
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
