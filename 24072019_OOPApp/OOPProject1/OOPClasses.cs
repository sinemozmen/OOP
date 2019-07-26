using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject1
{
    public abstract class WissenAkademie
    {
        public virtual int CalisanMaaslari(string CalisanTipi)
        {
            return 2500;
        }
        protected virtual string Demirbaslar()
        { return "Bilgisayarlar"; }
        public abstract Dictionary<int, string> OgrCalListesi(string sinifAdi);

        private Dictionary<int, string> ogrListesi;
        private Dictionary<int, string> calListesi;
        private string tip;

        public string Tip
        {
            get
            {
                return tip;
            }
            set
            {
                tip = value;
            }
        }
        public Dictionary<int, string> ListeWissen
        {
            get
            {
                if (tip == "Ogr")
                {
                    return ogrListesi;
                }
                else if (tip == "Cal")
                {
                    return calListesi;
                }
                else
                {
                    Dictionary<int, string> tumListe = calListesi;
                    foreach (var itemOgr in ogrListesi)
                        tumListe.Add(itemOgr.Key, itemOgr.Value);
                    return tumListe;
                }
            }
            set
            {
                if (tip == "Ogr")
                {
                    ogrListesi = value;
                }
                else if (tip == "Cal")
                {
                    calListesi = value; ;
                }
            }
        }
    }
    public class Siniflar : WissenAkademie
    {
        public override Dictionary<int, string> OgrCalListesi(string sinifAdi)
        {
            Dictionary<int, string> DOgrenciler = new Dictionary<int, string>();

            if (sinifAdi == "503")
            {
                DOgrenciler.Add(5031, "Sinem");
                DOgrenciler.Add(5032, "Gizem");
                DOgrenciler.Add(5033, "Gözde");
                DOgrenciler.Add(5034, "Gülcan");
                DOgrenciler.Add(5035, "Derya");
                DOgrenciler.Add(5036, "Sevgi");
                DOgrenciler.Add(5037, "Gülsüm");
                DOgrenciler.Add(5038, "Bensu");
                DOgrenciler.Add(5039, "Yeşim");
            }
            else if (sinifAdi == "502")
            {
                DOgrenciler.Add(5021, "Nükhet");
                DOgrenciler.Add(5022, "Merve");
                DOgrenciler.Add(5023, "Sena");
                DOgrenciler.Add(5024, "Ümit");
                DOgrenciler.Add(5025, "Feyzan");
                DOgrenciler.Add(5026, "Reyyan");
            }
            else
            {
                DOgrenciler.Add(9999, "Belirsiz Öğrenci");
            }
            Tip = "Ogr";
            ListeWissen = DOgrenciler;
            return DOgrenciler;
        }
        public string DemirbaslarGoster()
        {
            return Demirbaslar();
        }
    }
    public class Calisanlar : WissenAkademie
    {
        public override Dictionary<int, string> OgrCalListesi(string sinifAdi)
        {
            Dictionary<int, string> DCalisanlar = new Dictionary<int, string>();

            DCalisanlar.Add(111, "Görkem");
            DCalisanlar.Add(222, "Nurseli");
            DCalisanlar.Add(333, "Nergiz");
            DCalisanlar.Add(444, "Alperen");

            Tip = "Cal";
            ListeWissen = DCalisanlar;
            return DCalisanlar;
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
