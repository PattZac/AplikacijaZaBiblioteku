namespace AplikacijaZaBiblioteku
{
    partial class Form1
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
            this.bntPregledKorsinik = new System.Windows.Forms.Button();
            this.bntPregledKnijga = new System.Windows.Forms.Button();
            this.bntPregled = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bntUnosVracanje = new System.Windows.Forms.Button();
            this.bntUnosPosudivanje = new System.Windows.Forms.Button();
            this.bntUnosKnjiga = new System.Windows.Forms.Button();
            this.bntUnosKorsnik = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntPregledKorsinik
            // 
            this.bntPregledKorsinik.Location = new System.Drawing.Point(6, 71);
            this.bntPregledKorsinik.Name = "bntPregledKorsinik";
            this.bntPregledKorsinik.Size = new System.Drawing.Size(180, 23);
            this.bntPregledKorsinik.TabIndex = 0;
            this.bntPregledKorsinik.Text = "Pregled korisnicima";
            this.bntPregledKorsinik.UseVisualStyleBackColor = true;
            this.bntPregledKorsinik.Click += new System.EventHandler(this.bntPregledKorsinik_Click);
            // 
            // bntPregledKnijga
            // 
            this.bntPregledKnijga.Location = new System.Drawing.Point(6, 111);
            this.bntPregledKnijga.Name = "bntPregledKnijga";
            this.bntPregledKnijga.Size = new System.Drawing.Size(180, 23);
            this.bntPregledKnijga.TabIndex = 1;
            this.bntPregledKnijga.Text = "Pregled knjige";
            this.bntPregledKnijga.UseVisualStyleBackColor = true;
            this.bntPregledKnijga.Click += new System.EventHandler(this.bntPregledKnijga_Click);
            // 
            // bntPregled
            // 
            this.bntPregled.Location = new System.Drawing.Point(6, 151);
            this.bntPregled.Name = "bntPregled";
            this.bntPregled.Size = new System.Drawing.Size(180, 23);
            this.bntPregled.TabIndex = 2;
            this.bntPregled.Text = "Pregled sve podataka";
            this.bntPregled.UseVisualStyleBackColor = true;
            this.bntPregled.Click += new System.EventHandler(this.bntPregled_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pregled Podataka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Unos Podataka";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bntPregledKorsinik);
            this.groupBox1.Controls.Add(this.bntPregled);
            this.groupBox1.Controls.Add(this.bntPregledKnijga);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 191);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bntUnosVracanje);
            this.groupBox2.Controls.Add(this.bntUnosPosudivanje);
            this.groupBox2.Controls.Add(this.bntUnosKnjiga);
            this.groupBox2.Controls.Add(this.bntUnosKorsnik);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(17, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 231);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // bntUnosVracanje
            // 
            this.bntUnosVracanje.Location = new System.Drawing.Point(6, 191);
            this.bntUnosVracanje.Name = "bntUnosVracanje";
            this.bntUnosVracanje.Size = new System.Drawing.Size(180, 23);
            this.bntUnosVracanje.TabIndex = 8;
            this.bntUnosVracanje.Text = "Unesi vračanje knijga";
            this.bntUnosVracanje.UseVisualStyleBackColor = true;
            this.bntUnosVracanje.Click += new System.EventHandler(this.bntUnosVracanje_Click);
            // 
            // bntUnosPosudivanje
            // 
            this.bntUnosPosudivanje.Location = new System.Drawing.Point(6, 151);
            this.bntUnosPosudivanje.Name = "bntUnosPosudivanje";
            this.bntUnosPosudivanje.Size = new System.Drawing.Size(180, 23);
            this.bntUnosPosudivanje.TabIndex = 7;
            this.bntUnosPosudivanje.Text = "Unos novi posuđivanju";
            this.bntUnosPosudivanje.UseVisualStyleBackColor = true;
            this.bntUnosPosudivanje.Click += new System.EventHandler(this.bntUnosPosudivanje_Click);
            // 
            // bntUnosKnjiga
            // 
            this.bntUnosKnjiga.Location = new System.Drawing.Point(6, 111);
            this.bntUnosKnjiga.Name = "bntUnosKnjiga";
            this.bntUnosKnjiga.Size = new System.Drawing.Size(180, 23);
            this.bntUnosKnjiga.TabIndex = 6;
            this.bntUnosKnjiga.Text = "Unos novi knijga";
            this.bntUnosKnjiga.UseVisualStyleBackColor = true;
            this.bntUnosKnjiga.Click += new System.EventHandler(this.bntUnosKnjiga_Click);
            // 
            // bntUnosKorsnik
            // 
            this.bntUnosKorsnik.Location = new System.Drawing.Point(6, 71);
            this.bntUnosKorsnik.Name = "bntUnosKorsnik";
            this.bntUnosKorsnik.Size = new System.Drawing.Size(180, 23);
            this.bntUnosKorsnik.TabIndex = 5;
            this.bntUnosKorsnik.Text = "Unos novi korisnik";
            this.bntUnosKorsnik.UseVisualStyleBackColor = true;
            this.bntUnosKorsnik.Click += new System.EventHandler(this.bntUnosKorsnik_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(217, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(571, 428);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listu najstarijih posuđivu";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(7, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(558, 390);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Aplikacija za biblioteku";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntPregledKorsinik;
        private System.Windows.Forms.Button bntPregledKnijga;
        private System.Windows.Forms.Button bntPregled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bntUnosVracanje;
        private System.Windows.Forms.Button bntUnosPosudivanje;
        private System.Windows.Forms.Button bntUnosKnjiga;
        private System.Windows.Forms.Button bntUnosKorsnik;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

