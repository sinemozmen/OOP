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
    public partial class FormLogKayıtları : Form
    {
        private Dictionary<string, Ogrenci> logDictionary = new Dictionary<string, Ogrenci>();

        public FormLogKayıtları()
        {
            InitializeComponent();
        }
        public FormLogKayıtları(Dictionary<string, Ogrenci> logDic)
        {
            logDictionary = logDic;
            InitializeComponent();
        }

        private void FormLogKayıtları_Load(object sender, EventArgs e)
        {
            dataGridViewKayit.DataSource = null;
            List<Ogrenci> listValues = logDictionary.Values.ToList();
            List<string> listKeys = logDictionary.Keys.ToList();

            int ListCount = listKeys.Count;
            //List<string> logList = new List<string>();
            
            for (int i = 0; i < ListCount; i++)
            {
                string sKey = listKeys[i];
                if (sKey.Contains("Delete") || sKey.Contains("Change"))
                {
                    sKey = sKey.Substring(0, 6);

                }
                else //add durumu
                {
                    sKey = sKey.Substring(0, 3);
                }
                    string s = sKey + " " +
                     listValues[i].Id + " " + listValues[i].Ad + " " + listValues[i].Soyad + " " + listValues[i].DogumYeri + " " +
                     listValues[i].DogumTarih + " " + listValues[i].KursBitisTarih;

                // logList.Add(s);
                dataGridViewKayit.Rows.Add(s);

                if (sKey == "Delete")
                    dataGridViewKayit.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                else if (sKey == "Change")
                    dataGridViewKayit.Rows[i].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                else//if (sKey == "Add")
                    dataGridViewKayit.Rows[i].DefaultCellStyle.BackColor = Color.LightSteelBlue;
            }
            //  this.dataGridViewKayit.DataSource = logList.Select(XmlReadMode => new { Value = x}).ToList();
        }
    }
}
