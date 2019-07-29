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
    public partial class FormDatay : Form

    {
       public Ogrenci OgrBilgileri = new Ogrenci();
        public FormDatay()
        {
            InitializeComponent();
        }
        
        
            
        

        private void FormDatay_Load(object sender, EventArgs e)
        {
            timer1.Interval =100;
            timer1.Start();

            this.txtID.Text = OgrBilgileri.Id.ToString();
            this.txtAdi.Text = OgrBilgileri.Ad;
            this.txtSoyadi.Text =OgrBilgileri.Soyad;
            this.cmbDogumYeri.Text = OgrBilgileri.DogumYeri;
            int yilFarki = DateTime.Now.Year - OgrBilgileri.DogumTarih.Year;
            this.txtYas.Text = yilFarki.ToString();

            double gunFarki = (DateTime.Now - OgrBilgileri.DogumTarih).TotalDays;
            this.txtToplamGun.Text = gunFarki.ToString();

            double saatFarki = (DateTime.Now - OgrBilgileri.DogumTarih).TotalHours;
            this.txtToplamSaat.Text = saatFarki.ToString();

            double dakikaFarki = (DateTime.Now - OgrBilgileri.DogumTarih).TotalSeconds;
            this.txtToplamDakika.Text = dakikaFarki.ToString();

            double saniyeFarki = (DateTime.Now - OgrBilgileri.DogumTarih).TotalMinutes;
            this.txtToplamSaniye.Text = saniyeFarki.ToString();

            double miliSaniyeFarki = (DateTime.Now - OgrBilgileri.DogumTarih).TotalMilliseconds;
            this.txtToplamMilisaniye.Text = miliSaniyeFarki.ToString();







        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if(lblYasadiniz.Visible)
            //{
            //    lblYasadiniz.Hide();//lblYasadiniz.Visible=false;
            //}
            //else
            //{
            //    lblYasadiniz.Show();//lblYasadiniz.Visible=true;
            //}
            //Ternary Operator ile tek satırda yazma aşağıdaki gibidir: 
            var res = lblYasadiniz.Visible ? lblYasadiniz.Visible = false : lblYasadiniz.Visible = true;
        }
    }
}
