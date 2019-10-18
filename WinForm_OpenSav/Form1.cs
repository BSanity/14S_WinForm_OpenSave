using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;   
using System.Threading.Tasks;
using System.Windows.Forms;
   
namespace WinForm_OpenSav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Hobbik.Items.Add("Úszás");
            Hobbik.Items.Add("Horgászat");
            Hobbik.Items.Add("Futás");

            saveFileDialog1.FileOk += (senderFile, eFile) =>
            {
                try
                {

                    //string kiirando= ;
                    string fileName = saveFileDialog1.FileName;
                    //File.WriteAllLines(fileName, Hobbik.Items.Cast<string>().ToArray());
                   // File.WriteAllText(fileName, kiirando);

                }
                catch (IOException)
                {

                    MessageBox.Show("Hiba Nem sikerolt a kiiras");
                }
            };

            openFileDialog1.FileOk += (sender, e) =>
            {
                try
                {
                    string[] sorok = File.ReadAllLines(openFileDialog1.FileName);
                    Hobbik.Items.Clear();
                    foreach (var item in sorok)
                    {
                        Hobbik.Items.Add(item);
                    }
                }
                catch (IOException)
                {

                    MessageBox.Show("Hiba! sikertelen betoltes");
                }
            };

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listSzovegek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Betöltés_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Hobbik.Items.Add(Nev.Text);
                Nev.Text = "";
            }
        }

        private void Mentés_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();



        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Hozzaadas_Click(object sender, EventArgs e)
        {
            
                Hobbik.Items.Add(textBox3.Text);
                Nev.Text = "";
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
           

        }
    }
}
