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
        public FormDatay()
        {
            InitializeComponent();
        }

        private void FormDatay_Load(object sender, EventArgs e)
        {
            timer1.Interval =100;
            timer1.Start();
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
