using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject2
{
    public  class Kisi
    {
        private string AdSoyad;//Field ve member.Burada da Kisi.AdSoyad = denerek set edilebilir 
        //=> private string AdSoyad {get;set;} ile aynıdır.Ancak içine kontrol eklenemez.
        internal int Yas { get; set; }//Property ve member.Bunun get ve seti içine kontrol koyabilirim.
        public int Id { get; set; }//bu propertynin fieldden bir farkı yok.Çünkü get-setin içi boş.
        public string Ad { get; set; }
        public string Soyad { get; set; }
        protected internal int KrediKartNo { get; set; }
        protected int TcKimlik { get; set; }
        public string FullName()
        {
            //return this.Ad + this.Soyad;
            //eklendi
            AdSoyad = this.Ad + this.Soyad;
            return AdSoyad;
        }






    }
}
