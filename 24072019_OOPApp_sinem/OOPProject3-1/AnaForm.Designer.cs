namespace OOPProject3_1
{
    partial class AnaForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUretveDoldur = new System.Windows.Forms.Button();
            this.btnVeriDetay = new System.Windows.Forms.Button();
            this.btnVeriEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnCokluSil = new System.Windows.Forms.Button();
            this.btnİslemGeriAl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(651, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dgvAna_SelectionChanged);
            // 
            // btnUretveDoldur
            // 
            this.btnUretveDoldur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUretveDoldur.ForeColor = System.Drawing.Color.Navy;
            this.btnUretveDoldur.Location = new System.Drawing.Point(66, 403);
            this.btnUretveDoldur.Name = "btnUretveDoldur";
            this.btnUretveDoldur.Size = new System.Drawing.Size(90, 33);
            this.btnUretveDoldur.TabIndex = 1;
            this.btnUretveDoldur.Text = "Üret ve Doldur";
            this.btnUretveDoldur.UseVisualStyleBackColor = false;
            this.btnUretveDoldur.Click += new System.EventHandler(this.buttonUretveDoldur_Click);
            // 
            // btnVeriDetay
            // 
            this.btnVeriDetay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVeriDetay.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriDetay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnVeriDetay.Location = new System.Drawing.Point(175, 403);
            this.btnVeriDetay.Name = "btnVeriDetay";
            this.btnVeriDetay.Size = new System.Drawing.Size(105, 32);
            this.btnVeriDetay.TabIndex = 2;
            this.btnVeriDetay.Text = "Detaylandır";
            this.btnVeriDetay.UseVisualStyleBackColor = false;
            this.btnVeriDetay.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVeriEkle
            // 
            this.btnVeriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVeriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnVeriEkle.Location = new System.Drawing.Point(300, 403);
            this.btnVeriEkle.Name = "btnVeriEkle";
            this.btnVeriEkle.Size = new System.Drawing.Size(90, 31);
            this.btnVeriEkle.TabIndex = 3;
            this.btnVeriEkle.Text = "Ekle";
            this.btnVeriEkle.UseVisualStyleBackColor = false;
            this.btnVeriEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSil.Location = new System.Drawing.Point(414, 402);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(90, 32);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegistir.ForeColor = System.Drawing.Color.Purple;
            this.btnDegistir.Location = new System.Drawing.Point(522, 402);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(90, 31);
            this.btnDegistir.TabIndex = 5;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = false;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnCokluSil
            // 
            this.btnCokluSil.Location = new System.Drawing.Point(631, 402);
            this.btnCokluSil.Name = "btnCokluSil";
            this.btnCokluSil.Size = new System.Drawing.Size(75, 31);
            this.btnCokluSil.TabIndex = 6;
            this.btnCokluSil.Text = "Çoklu Sil";
            this.btnCokluSil.UseVisualStyleBackColor = true;
            this.btnCokluSil.Click += new System.EventHandler(this.btnCokluSil_Click);
            // 
            // btnİslemGeriAl
            // 
            this.btnİslemGeriAl.Location = new System.Drawing.Point(748, 42);
            this.btnİslemGeriAl.Name = "btnİslemGeriAl";
            this.btnİslemGeriAl.Size = new System.Drawing.Size(103, 38);
            this.btnİslemGeriAl.TabIndex = 7;
            this.btnİslemGeriAl.Text = "Son İşlemi Geri Al ";
            this.btnİslemGeriAl.UseVisualStyleBackColor = true;
            this.btnİslemGeriAl.Click += new System.EventHandler(this.btnİslemGeriAl_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.btnİslemGeriAl);
            this.Controls.Add(this.btnCokluSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnVeriEkle);
            this.Controls.Add(this.btnVeriDetay);
            this.Controls.Add(this.btnUretveDoldur);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AnaForm";
            this.Text = "Verileri Otomatik Üret ve Doldur";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUretveDoldur;
        private System.Windows.Forms.Button btnVeriDetay;
        private System.Windows.Forms.Button btnVeriEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnCokluSil;
        private System.Windows.Forms.Button btnİslemGeriAl;
    }
}

