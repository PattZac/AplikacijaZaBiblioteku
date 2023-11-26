namespace AplikacijaZaBiblioteku
{
    partial class PregledKorsinik
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listKorisnik = new System.Windows.Forms.ListBox();
            this.bntSearch = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bntNazad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listKorisnik);
            this.groupBox1.Controls.Add(this.bntSearch);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 373);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korsinika";
            // 
            // listKorisnik
            // 
            this.listKorisnik.FormattingEnabled = true;
            this.listKorisnik.Location = new System.Drawing.Point(6, 64);
            this.listKorisnik.Name = "listKorisnik";
            this.listKorisnik.Size = new System.Drawing.Size(762, 303);
            this.listKorisnik.TabIndex = 3;
            // 
            // bntSearch
            // 
            this.bntSearch.Location = new System.Drawing.Point(594, 19);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(175, 23);
            this.bntSearch.TabIndex = 2;
            this.bntSearch.Text = "Pretraži";
            this.bntSearch.UseVisualStyleBackColor = true;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(581, 20);
            this.textBox2.TabIndex = 1;
            // 
            // bntNazad
            // 
            this.bntNazad.Location = new System.Drawing.Point(600, 415);
            this.bntNazad.Name = "bntNazad";
            this.bntNazad.Size = new System.Drawing.Size(188, 23);
            this.bntNazad.TabIndex = 13;
            this.bntNazad.Text = "Nazad";
            this.bntNazad.UseVisualStyleBackColor = true;
            this.bntNazad.Click += new System.EventHandler(this.bntNazad_Click);
            // 
            // PregledKorsinik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntNazad);
            this.Controls.Add(this.groupBox1);
            this.Name = "PregledKorsinik";
            this.Text = "Pregled korsinicima";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bntSearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bntNazad;
        private System.Windows.Forms.ListBox listKorisnik;
    }
}