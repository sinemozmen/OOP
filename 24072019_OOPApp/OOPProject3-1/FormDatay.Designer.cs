namespace OOPProject3_1
{
    partial class FormDatay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblYasadiniz = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtToplamSaat = new System.Windows.Forms.TextBox();
            this.txtToplamGun = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtToplamMilisaniye = new System.Windows.Forms.TextBox();
            this.txtToplamSaniye = new System.Windows.Forms.TextBox();
            this.txtToplamDakika = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Toplam Saat : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Toplam Gün : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Yaş : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Toplam Milisaniye";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Toplam Saniye : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Toplam Dakika :";
            // 
            // lblYasadiniz
            // 
            this.lblYasadiniz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblYasadiniz.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYasadiniz.ForeColor = System.Drawing.Color.Purple;
            this.lblYasadiniz.Location = new System.Drawing.Point(12, 320);
            this.lblYasadiniz.Name = "lblYasadiniz";
            this.lblYasadiniz.Size = new System.Drawing.Size(420, 64);
            this.lblYasadiniz.TabIndex = 9;
            this.lblYasadiniz.Text = "***YAŞADINIZ***";
            this.lblYasadiniz.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(160, 35);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(186, 20);
            this.txtID.TabIndex = 10;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(160, 62);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(186, 20);
            this.txtAdi.TabIndex = 11;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(160, 91);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(186, 20);
            this.txtSoyadi.TabIndex = 12;
            // 
            // txtToplamSaat
            // 
            this.txtToplamSaat.Location = new System.Drawing.Point(160, 180);
            this.txtToplamSaat.Name = "txtToplamSaat";
            this.txtToplamSaat.Size = new System.Drawing.Size(186, 20);
            this.txtToplamSaat.TabIndex = 15;
            // 
            // txtToplamGun
            // 
            this.txtToplamGun.Location = new System.Drawing.Point(160, 151);
            this.txtToplamGun.Name = "txtToplamGun";
            this.txtToplamGun.Size = new System.Drawing.Size(186, 20);
            this.txtToplamGun.TabIndex = 14;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(160, 124);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(186, 20);
            this.txtYas.TabIndex = 13;
            // 
            // txtToplamMilisaniye
            // 
            this.txtToplamMilisaniye.Location = new System.Drawing.Point(160, 271);
            this.txtToplamMilisaniye.Name = "txtToplamMilisaniye";
            this.txtToplamMilisaniye.Size = new System.Drawing.Size(186, 20);
            this.txtToplamMilisaniye.TabIndex = 18;
            // 
            // txtToplamSaniye
            // 
            this.txtToplamSaniye.Location = new System.Drawing.Point(160, 242);
            this.txtToplamSaniye.Name = "txtToplamSaniye";
            this.txtToplamSaniye.Size = new System.Drawing.Size(186, 20);
            this.txtToplamSaniye.TabIndex = 17;
            // 
            // txtToplamDakika
            // 
            this.txtToplamDakika.Location = new System.Drawing.Point(160, 215);
            this.txtToplamDakika.Name = "txtToplamDakika";
            this.txtToplamDakika.Size = new System.Drawing.Size(186, 20);
            this.txtToplamDakika.TabIndex = 16;
            // 
            // FormDatay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 396);
            this.Controls.Add(this.txtToplamMilisaniye);
            this.Controls.Add(this.txtToplamSaniye);
            this.Controls.Add(this.txtToplamDakika);
            this.Controls.Add(this.txtToplamSaat);
            this.Controls.Add(this.txtToplamGun);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblYasadiniz);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDatay";
            this.Text = "Seçilen Kişilerin Yaşam Süresi Bilgileri ";
            this.Load += new System.EventHandler(this.FormDatay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblYasadiniz;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtToplamSaat;
        private System.Windows.Forms.TextBox txtToplamGun;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtToplamMilisaniye;
        private System.Windows.Forms.TextBox txtToplamSaniye;
        private System.Windows.Forms.TextBox txtToplamDakika;
    }
}