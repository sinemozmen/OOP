using System;
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
    public partial class FormDegistir : Form
    {
       
        public Ogrenci ogrFormDegistir = new Ogrenci();
        public FormDegistir()
        {
            InitializeComponent();
        }

        private void FormDegistir_Load(object sender, EventArgs e)
        {
            this.txtId.Text=ogrFormDegistir.Id.ToString();
            this.txtAd.Text = ogrFormDegistir.Ad;
            this.txtSoyad.Text = ogrFormDegistir.Soyad;
            this.cmbSehir.Text = ogrFormDegistir.DogumYeri;
            this.dateTimePickerDogTar.Value= Convert.ToDateTime(ogrFormDegistir.DogumTarih);
            this.dateTimePickerKursBitis.Value = Convert.ToDateTime(ogrFormDegistir.KursBitisTarih);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ogrFormDegistir.Id = Convert.ToInt32(this.txtId.Text);
            ogrFormDegistir.Ad = this.txtAd.Text;
            ogrFormDegistir.Soyad = this.txtSoyad.Text;
            ogrFormDegistir.DogumYeri = this.cmbSehir.Text;
            ogrFormDegistir.DogumTarih = Convert.ToDateTime(this.dateTimePickerDogTar.Text);
            ogrFormDegistir.KursBitisTarih = Convert.ToDateTime(this.dateTimePickerKursBitis.Text);

            this.Hide();
        }
    }
}
