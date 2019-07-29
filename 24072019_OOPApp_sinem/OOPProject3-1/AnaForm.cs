﻿using System;
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
    public partial class AnaForm : Form
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

        public Ogrenci seciliOgrBilgileri = new Ogrenci();
        public FormEkle baglananAnaForm;
        public AnaForm()
        {
            InitializeComponent();


        }

        public void button1_Click(object sender, EventArgs e)
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

                ogr.Id = i;
                ogr.Ad = sourceOfData.GetName();
                ogr.Soyad = sourceOfData.GetSurname();
                ogr.DogumYeri = sourceOfData.GetCity();
                ogr.DogumTarih = sourceOfData.GetBackDate(30);
                ogr.KursBitisTarih = sourceOfData.GetForwardDate(5);
                olist.Add(ogr);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = olist;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // FormDatay frmDet = new FormDatay(this);
            DialogResult dr = MessageBox.Show("Seçili satırın detayını görmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Cancel || dr == DialogResult.No)
            {
                return;
            }
            else
            {
                FormDatay frmDet = new FormDatay();

                frmDet.OgrBilgileri = this.seciliOgrBilgileri;
                frmDet.ShowDialog();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FormEkle frmEkle = new FormEkle();
            frmEkle.ShowDialog();
            //string str = frmEkle.yeniOgrBilgileri.Id + "\n" +
            //             frmEkle.yeniOgrBilgileri.Ad + "\n" +
            //             frmEkle.yeniOgrBilgileri.Soyad + "\n" +
            //             frmEkle.yeniOgrBilgileri.DogumYeri + "\n" +
            //             frmEkle.yeniOgrBilgileri.DogumTarih + "\n" +
            //             frmEkle.yeniOgrBilgileri.KursBitisTarih + "\n";

            //MessageBox.Show(str);
            List<Ogrenci> ogrList = new List<Ogrenci>();//Öğrenci class'ının instancelarından oluan bir liste oluşturuldu

            if (dataGridView1.RowCount > 0)

                ogrList = (List<Ogrenci>)dataGridView1.DataSource;
                ogrList.Add(frmEkle.yeniOgrBilgileri);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ogrList;
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvAna_SelectionChanged(object sender, EventArgs e)
        {   //1.YOL
            //foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //{
            //    seciliOgrBilgileri.Id = Convert.ToInt32(row.Cells[0].Value);
            //    seciliOgrBilgileri.Ad = row.Cells[1].Value.ToString();
            //    seciliOgrBilgileri.Soyad = row.Cells[2].Value.ToString();
            //    seciliOgrBilgileri.DogumYeri = row.Cells[3].Value.ToString();
            //    seciliOgrBilgileri.DogumTarih = Convert.ToDateTime(row.Cells[4].Value);
            //    seciliOgrBilgileri.KursBitisTarih = Convert.ToDateTime(row.Cells[5].Value);

            //}
            //2.YOL 
            //Cell isimleri verilerek  Cell'e ulaşmak 

            seciliOgrBilgileri.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            seciliOgrBilgileri.Ad = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            seciliOgrBilgileri.Soyad = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            seciliOgrBilgileri.DogumYeri = dataGridView1.CurrentRow.Cells["DogumYeri"].Value.ToString();
            seciliOgrBilgileri.DogumTarih = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DogumTarih"].Value);
            seciliOgrBilgileri.KursBitisTarih = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["KursBitisTarih"].Value);

        }
    }
}