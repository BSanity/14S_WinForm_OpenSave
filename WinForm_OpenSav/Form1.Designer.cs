namespace WinForm_OpenSav
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Hobbik = new System.Windows.Forms.ListBox();
            this.Mentés = new System.Windows.Forms.Button();
            this.betoltes = new System.Windows.Forms.Button();
            this.Nev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.RadioButton();
            this.ferfi = new System.Windows.Forms.RadioButton();
            this.Név = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Hozzaadas = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Hobbi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "saveFileDialog1";
            this.saveFileDialog1.Filter = "Text File|*.txt|All files|*-*";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Hobbik
            // 
            this.Hobbik.FormattingEnabled = true;
            this.Hobbik.Location = new System.Drawing.Point(509, 72);
            this.Hobbik.Name = "Hobbik";
            this.Hobbik.Size = new System.Drawing.Size(120, 290);
            this.Hobbik.TabIndex = 0;
            this.Hobbik.SelectedIndexChanged += new System.EventHandler(this.listSzovegek_SelectedIndexChanged);
            // 
            // Mentés
            // 
            this.Mentés.Location = new System.Drawing.Point(635, 165);
            this.Mentés.Name = "Mentés";
            this.Mentés.Size = new System.Drawing.Size(75, 23);
            this.Mentés.TabIndex = 1;
            this.Mentés.Text = "Mentés";
            this.Mentés.UseVisualStyleBackColor = true;
            this.Mentés.Click += new System.EventHandler(this.Mentés_Click);
            // 
            // betoltes
            // 
            this.betoltes.Location = new System.Drawing.Point(635, 194);
            this.betoltes.Name = "betoltes";
            this.betoltes.Size = new System.Drawing.Size(75, 23);
            this.betoltes.TabIndex = 2;
            this.betoltes.Text = "Betöltés";
            this.betoltes.UseMnemonic = false;
            this.betoltes.UseVisualStyleBackColor = true;
            this.betoltes.Click += new System.EventHandler(this.Betöltés_Click);
            // 
            // Nev
            // 
            this.Nev.Location = new System.Drawing.Point(184, 51);
            this.Nev.Name = "Nev";
            this.Nev.Size = new System.Drawing.Size(231, 20);
            this.Nev.TabIndex = 3;
            this.Nev.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Nev.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(456, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "KEDVENC HOBBIK";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(36, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nem:";
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.ForeColor = System.Drawing.Color.Violet;
            this.no.Location = new System.Drawing.Point(140, 164);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(41, 17);
            this.no.TabIndex = 6;
            this.no.TabStop = true;
            this.no.Text = "NŐ";
            this.no.UseVisualStyleBackColor = true;
            // 
            // ferfi
            // 
            this.ferfi.AutoSize = true;
            this.ferfi.ForeColor = System.Drawing.Color.Crimson;
            this.ferfi.Location = new System.Drawing.Point(231, 163);
            this.ferfi.Name = "ferfi";
            this.ferfi.Size = new System.Drawing.Size(55, 17);
            this.ferfi.TabIndex = 7;
            this.ferfi.TabStop = true;
            this.ferfi.Text = "FÉRFI";
            this.ferfi.UseVisualStyleBackColor = true;
            // 
            // Név
            // 
            this.Név.AutoSize = true;
            this.Név.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Név.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Név.Location = new System.Drawing.Point(107, 49);
            this.Név.Name = "Név";
            this.Név.Size = new System.Drawing.Size(53, 25);
            this.Név.TabIndex = 8;
            this.Név.Text = "Név:";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(184, 77);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(231, 20);
            this.Date.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(36, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Szül. Dátum:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Hozzaadas
            // 
            this.Hozzaadas.Location = new System.Drawing.Point(340, 156);
            this.Hozzaadas.Name = "Hozzaadas";
            this.Hozzaadas.Size = new System.Drawing.Size(75, 23);
            this.Hozzaadas.TabIndex = 11;
            this.Hozzaadas.Text = "Hozzáadás";
            this.Hozzaadas.UseVisualStyleBackColor = true;
            this.Hozzaadas.Click += new System.EventHandler(this.Hozzaadas_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(184, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(231, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Hobbi
            // 
            this.Hobbi.AutoSize = true;
            this.Hobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Hobbi.Location = new System.Drawing.Point(91, 103);
            this.Hobbi.Name = "Hobbi";
            this.Hobbi.Size = new System.Drawing.Size(69, 25);
            this.Hobbi.TabIndex = 13;
            this.Hobbi.Text = "Hobbi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hobbi);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Hozzaadas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Név);
            this.Controls.Add(this.ferfi);
            this.Controls.Add(this.no);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nev);
            this.Controls.Add(this.betoltes);
            this.Controls.Add(this.Mentés);
            this.Controls.Add(this.Hobbik);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox Hobbik;
        private System.Windows.Forms.Button Mentés;
        private System.Windows.Forms.Button betoltes;
        private System.Windows.Forms.TextBox Nev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.RadioButton ferfi;
        private System.Windows.Forms.Label Név;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Hozzaadas;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Hobbi;
    }
}

