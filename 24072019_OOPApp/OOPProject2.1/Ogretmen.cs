using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPProject2;
	

namespace OOPProject2._1
{   //Kisi class'ını bu projeye referans olarak ve usinge eklememiz gerekiyor.
    public class Ogretmen : Kisi 
    {
        private string Brans;
        public Ogretmen()
        {
            this.TcKimlik = 213234;
            this.KrediKartNo = 24234234;
        }
    }
}
