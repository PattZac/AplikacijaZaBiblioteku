namespace AplikacijaZaBiblioteku
{
    partial class UnosVracanjeKnjiga
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
            this.bntNazad = new System.Windows.Forms.Button();
            this.bntUnesi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxKorisnik = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntNazad
            // 
            this.bntNazad.Location = new System.Drawing.Point(284, 415);
            this.bntNazad.Name = "bntNazad";
            this.bntNazad.Size = new System.Drawing.Size(188, 23);
            this.bntNazad.TabIndex = 19;
            this.bntNazad.Text = "Nazad";
            this.bntNazad.UseVisualStyleBackColor = true;
            this.bntNazad.Click += new System.EventHandler(this.bntNazad_Click);
            // 
            // bntUnesi
            // 
            this.bntUnesi.Location = new System.Drawing.Point(12, 415);
            this.bntUnesi.Name = "bntUnesi";
            this.bntUnesi.Size = new System.Drawing.Size(188, 23);
            this.bntUnesi.TabIndex = 18;
            this.bntUnesi.Text = "Unesi";
            this.bntUnesi.UseVisualStyleBackColor = true;
            this.bntUnesi.Click += new System.EventHandler(this.bntUnesi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxKorisnik);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 104);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podataka";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum vračenja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Evidencija";
            // 
            // cBoxKorisnik
            // 
            this.cBoxKorisnik.FormattingEnabled = true;
            this.cBoxKorisnik.Location = new System.Drawing.Point(6, 36);
            this.cBoxKorisnik.Name = "cBoxKorisnik";
            this.cBoxKorisnik.Size = new System.Drawing.Size(448, 21);
            this.cBoxKorisnik.TabIndex = 0;
            // 
            // UnosVracanjeKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bntNazad);
            this.Controls.Add(this.bntUnesi);
            this.Name = "UnosVracanjeKnjiga";
            this.Text = "Unos vračanje knjiga";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntNazad;
        private System.Windows.Forms.Button bntUnesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxKorisnik;
    }
}