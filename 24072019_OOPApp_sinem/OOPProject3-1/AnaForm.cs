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

       // public List<Ogrenci> sonSilmeListesi = new List<Ogrenci>();
        public Ogrenci seciliOgrBilgileri = new Ogrenci();
        public Dictionary<string, Ogrenci> sonIslemlerDictionary = new Dictionary<string, Ogrenci>();


        public AnaForm()
        {
            InitializeComponent();


        }

        public void buttonUretveDoldur_Click(object sender, EventArgs e)
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
        private int EnBuyukIDNumarasiniVer()//data grid viewdaki en büyük adi
        {
            int enBuyukId = 0;
            int tmpId = 0;
            int enBuyukIdLst = 0;
            int tmpIdLst = 0;
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                tmpId = (int)row.Cells[0].Value;
                if (tmpId > enBuyukId)
                enBuyukId = tmpId;
            }
            foreach (KeyValuePair<string, Ogrenci> item in sonIslemlerDictionary)
            {
                

                List<int> idList = new List<int>();
              
                String sKey = item.Key;
                string sId = "";

                if (sKey.Contains("Add"))
                {
                    sId = sKey.Substring(3, sKey.Length - 3);
                }
                if (sKey.Contains("Delete")|| sKey.Contains("Change"))
                {
                    sId = sKey.Substring(6, sKey.Length - 6);
                }
                    idList.Add(Convert.ToInt32(sId));
                if (Convert.ToInt32(sId) > enBuyukIdLst)
                    enBuyukIdLst = Convert.ToInt32(sId);

            }
            if (enBuyukId > enBuyukIdLst)
                return enBuyukId;
            else
                return enBuyukIdLst;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            int n = EnBuyukIDNumarasiniVer();
            FormEkle frmEkle = new FormEkle(n);
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

                sonIslemlerDictionary.Add("Add"+frmEkle.yeniOgrBilgileri.Id, frmEkle.yeniOgrBilgileri);

                ogrList.Add(frmEkle.yeniOgrBilgileri);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ogrList;
            btnİslemGeriAl.Enabled = true;
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
            seciliOgrBilgileri.Ad =Convert.ToString(dataGridView1.CurrentRow.Cells["Ad"].Value);
            seciliOgrBilgileri.Soyad = Convert.ToString(dataGridView1.CurrentRow.Cells["Soyad"].Value);
            seciliOgrBilgileri.DogumYeri = Convert.ToString(dataGridView1.CurrentRow.Cells["DogumYeri"].Value);
            seciliOgrBilgileri.DogumTarih = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DogumTarih"].Value);
            seciliOgrBilgileri.KursBitisTarih = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["KursBitisTarih"].Value);

        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            FormDegistir frmDegistir = new FormDegistir();
            frmDegistir.ogrFormDegistir = seciliOgrBilgileri;
            string s = "Change" + frmDegistir.ogrFormDegistir.Id;

            if(sonIslemlerDictionary.Keys.Contains(s)==false)
            {
                sonIslemlerDictionary.Add(s, frmDegistir.ogrFormDegistir);
            }


            frmDegistir.ShowDialog();
            //Aşağıdaki koda Hide() edildikten sonra girecek.

            seciliOgrBilgileri = frmDegistir.ogrFormDegistir;

            dataGridView1.CurrentRow.Cells[0].Value = this.seciliOgrBilgileri.Id;
            dataGridView1.CurrentRow.Cells[1].Value = this.seciliOgrBilgileri.Ad;
            dataGridView1.CurrentRow.Cells[2].Value = this.seciliOgrBilgileri.Soyad;
            dataGridView1.CurrentRow.Cells[3].Value = this.seciliOgrBilgileri.DogumYeri;
            dataGridView1.CurrentRow.Cells[4].Value = this.seciliOgrBilgileri.DogumTarih;
            dataGridView1.CurrentRow.Cells[5].Value = this.seciliOgrBilgileri.KursBitisTarih;
            btnİslemGeriAl.Enabled = true;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {     //Data gridviewda seçilen satırı sildirme
        

            DialogResult dr = MessageBox.Show("Seçilen satırı silmek istediğinize emin misiniz ?",
            "UYARI!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes==dr)
            {
                List<Ogrenci> ogrList = new List<Ogrenci>();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    ogrList = (List<Ogrenci>)dataGridView1.DataSource;

                    Ogrenci ogrTmp = ogrList[dataGridView1.CurrentRow.Index];
                    //sonSilmeListesi.Add(ogrTmp);
                    sonIslemlerDictionary.Add("Delete"+ogrTmp.Id, ogrTmp);

                    ogrList.RemoveAt(dataGridView1.CurrentRow.Index);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ogrList;
                    btnİslemGeriAl.Enabled = true;
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        row.Selected = false;
                }

            }else
            {
                return;
            }
           
        }

        private void btnCokluSil_Click(object sender, EventArgs e)
        {
            List<Ogrenci> ogrList = new List<Ogrenci>();
            ogrList = (List<Ogrenci>)dataGridView1.DataSource;

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                Ogrenci ogrTmp = ogrList[item.Index];
                //sonSilmeListesi.Add(ogrTmp)
                sonIslemlerDictionary.Add("Delete"+ogrTmp.Id, ogrTmp);
                ogrList.RemoveAt(item.Index);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ogrList;
            btnİslemGeriAl.Enabled = true;
        }

        private void btnİslemGeriAl_Click(object sender, EventArgs e)
        {
            // if(sonSilmeListesi.Count>0)
            if (sonIslemlerDictionary.Count>0)
            {
                List<Ogrenci> ogrList = new List<Ogrenci>();
               // foreach (Ogrenci item in sonSilmeListesi)
               foreach(KeyValuePair<string,Ogrenci> item in sonIslemlerDictionary)
                {
                    if (dataGridView1.RowCount > 0)
                        ogrList = (List<Ogrenci>)dataGridView1.DataSource;
                    // ogrList.Add(item);//--silme geri alması için yazılmıştı
                    String sKey = item.Key;
                    string sId = "";

                    if (sKey.Contains("Add"))
                    {
                        sId= sKey.Substring(3, sKey.Length - 3);
                        foreach (Ogrenci item2 in ogrList)
                        {
                            if (item2.Id == Convert.ToInt32(sId))
                            {
                                int ogrIndex = ogrList.IndexOf(item2);
                                ogrList.RemoveAt(ogrIndex);
                                break;
                            }
                        }
                    }

                   if(sKey.Contains("Delete"))
                    {
                        ogrList.Add(item.Value);
                    }

                    if (sKey.Contains("Change"))
                    {
                        sId = sKey.Substring(6, sKey.Length - 6);
                        //ogrList.RemoveAt();??
                        foreach (Ogrenci item2 in ogrList)
                        {
                            if (item2.Id == Convert.ToInt32(sId))
                            {
                                int ogrIndex = ogrList.IndexOf(item2);
                                ogrList.RemoveAt(ogrIndex);
                                break;
                            }
                        }
                        ogrList.Add(item.Value);
                    }
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ogrList;
                btnİslemGeriAl.Enabled = false;


                //sonSilmeListesi.Clear();//silme için eklendi
                sonIslemlerDictionary.Clear();
            }
        }

        private void btnLogKayit_Click(object sender, EventArgs e)
        {
            FormLogKayıtları frmLogKayit = new FormLogKayıtları(sonIslemlerDictionary);
           // frmLogKayit.sonLogDic = this.sonIslemlerDictionary;
            frmLogKayit.ShowDialog();

        }
    }
}
