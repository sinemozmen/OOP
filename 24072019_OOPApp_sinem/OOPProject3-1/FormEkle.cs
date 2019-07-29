using OOPProject3;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPProject3_1
{
    public partial class FormEkle : Form
    {
        public Ogrenci yeniOgrBilgileri = new Ogrenci();
        public FormEkle( )
        {
            InitializeComponent();
            
     
        }

        private void FormEkle_Load(object sender, EventArgs e)
        {
            BAU sourceOfData = new BAU();
            this.cmbSehir.Items.Clear();
            foreach (string item in sourceOfData.SehirlerArray)
            {
                this.cmbSehir.Items.Add(item);
            }
        }

     

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Id =Convert.ToInt32(this.txtID.Text);
            ogr.Ad = this.txtAd.Text;
            ogr.Soyad = this.txtSoyad.Text;
            ogr.DogumYeri = this.cmbSehir.SelectedItem.ToString();
            ogr.DogumTarih = this.dtpDogumTarihi.Value;
            ogr.KursBitisTarih = this.dtpKursBitisTarihi.Value;

            yeniOgrBilgileri = ogr;
            this.Hide(); 
        }
    }
}
