using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPProject3;

namespace OOPProject3_1
{
    public partial class Form1 : Form
    {   //Projemizin bu katmanına UI katmanı diyebiliriz.
        //OOPProject03'de oluşturduğumuz Class Library
        //bu projede yani OOPProject3-1 projesinde kullanılacaktır.
        //OOPPRoject3-Class Library( Veri üretmek için hazırladığımız bir kütüphanedir.)
        //OOPProject3-1 -UI(User Interface) katmanı
        //OOPProject3-1 UI katmanının, OOProject3 class library'dini kullanabilmesi için 
        //bu librarynin OOPProject3-1 projesine dahil edilmesi gerekir
        //dahil etmek için , OOPProject3 önce referans'lara eklenir,
        //sonra using satırı eklenir.
        //Bir class tanınmıyorsa, o class projeye eklenmedi demektir.
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Ogrenci> olist = new List<Ogrenci>();//ogrenci class'i instancelarından oluşan bir liste
            for (int i = 1; i <= 100; i++)
            {   //1.YOL
                //Ogrenci ogr = new Ogrenci();
                //ogr.Ad = "Gizem";
                //ogr.Soyad = "Sürer";
                //ogr.DogumYeri = "Hatay";
                //ogr.DogumTarih = Convert.ToDateTime("07/05/1992");
                //ogr.Id = i;
                //ogr.KursBitisTarih = Convert.ToDateTime("31/10/2019");
                //olist.Add(ogr);

                //2.YOL: OBJECT INITIALIZER yöntemi ile class'ın instance'ının oluşturulması 
                //ve değerlerinin doldurulması
                //Ogrenci ogr = new Ogrenci()
                //{
                //    Ad = "Gizem",
                //    Soyad = "Sürer",
                //    DogumYeri = "Hatay",
                //    DogumTarih = Convert.ToDateTime("07/05/1992"),
                //    Id = i,
                //    KursBitisTarih = Convert.ToDateTime("31/10/2019")
                //};
                //olist.Add(ogr);
                //tutorials teacher c# object initializer incele

                //3.YOL : İsimleri Proje3'te BAU'daki dataları çekerek random doldurma :
                Ogrenci ogr = new Ogrenci();
                
                BAU sourceOfData = new BAU();

                ogr.Ad = sourceOfData.GetName();
                ogr.Soyad = sourceOfData.GetSurname();
                ogr.DogumYeri = sourceOfData.GetCity();
                ogr.DogumTarih = sourceOfData.GetBackDate(30);
                ogr.Id = i;
                ogr.KursBitisTarih = sourceOfData.GetForwardDate(5);
                olist.Add(ogr);
            }
            dataGridView1.DataSource = olist;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // FormDatay frmDet = new FormDatay(this);
            DialogResult dr = MessageBox.Show("Seçili satırın detayını görmek istediğinizden emin misiniz ?", "Uyarı",MessageBoxButtons.YesNoCancel);
            if(dr == DialogResult.Cancel|| dr == DialogResult.No)
            {
                return;
            }
            else
            {
                FormDatay frmDet = new FormDatay();
                frmDet.ShowDialog();
            }

            
        }
    }
}
