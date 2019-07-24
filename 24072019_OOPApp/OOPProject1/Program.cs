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
        }
        public abstract class WissenAkademie
        {
            public virtual int CalisanMaaslari(string CalisanTipi)
            {
                return 2500;
            }
            protected virtual string Demirbaslar()
            { return "Bilgisayarlar"; }
            public abstract Dictionary<int, string> OgrenciListesi(Dictionary<int, string> Sinif);
            private Dictionary<string, string> OgrenciKisiselBilgiler;
            private Dictionary<string, string> CalisanKisiselBilgiler;
        }
        class _503 : WissenAkademie
        {
            WissenAkademie x = new _503();
            
            public override Dictionary<int, string> OgrenciListesi(Dictionary<int, string> Sinif)
            {
                Dictionary<int, string> D503Ogrenciler = new Dictionary<int, string>();
                return D503Ogrenciler;
                //  throw new NotImplementedException();
            }
        }
        protected class Calisanlar : WissenAkademie
        {
            public override Dictionary<int, string> OgrenciListesi(Dictionary<int, string> Sinif)
            {
                throw new NotImplementedException();
            }
            private int SaatHesapla() { return 100; }
            public override int CalisanMaaslari(string CalisanTipi)
            {
                if (CalisanTipi == "İdariPersonel")
                { return 5000; }
                else
                { return 7000; }
            }
        }
        
    }
}
