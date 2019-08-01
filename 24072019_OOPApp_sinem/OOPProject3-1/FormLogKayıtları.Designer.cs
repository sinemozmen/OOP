namespace OOPProject3_1
{
    partial class FormLogKayıtları
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
            this.dataGridViewKayit = new System.Windows.Forms.DataGridView();
            this.LogKayit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKayit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKayit
            // 
            this.dataGridViewKayit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKayit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LogKayit});
            this.dataGridViewKayit.Location = new System.Drawing.Point(24, 32);
            this.dataGridViewKayit.Name = "dataGridViewKayit";
            this.dataGridViewKayit.Size = new System.Drawing.Size(741, 271);
            this.dataGridViewKayit.TabIndex = 0;
            // 
            // LogKayit
            // 
            this.LogKayit.HeaderText = "Log Kayıt Bilgileri";
            this.LogKayit.Name = "LogKayit";
            // 
            // FormLogKayıtları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewKayit);
            this.Name = "FormLogKayıtları";
            this.Text = "FormLogKayıtları";
            this.Load += new System.EventHandler(this.FormLogKayıtları_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKayit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKayit;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogKayit;
    }
}