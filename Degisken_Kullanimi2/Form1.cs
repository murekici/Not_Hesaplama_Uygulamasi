using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degisken_Kullanimi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float vize, final, ödev, ort;
                vize = float.Parse(textBox1.Text);
                final = float.Parse(textBox2.Text);
                ödev = float.Parse(textBox3.Text);
                ort = ((((vize * 60 / 100) + (ödev * 40 / 100)) * 40 / 100) + (((final * 50 / 100) + (ödev * 50 / 100)) * 60 / 100));

                string ad, soyad, numara, durum;
                ad = textBox4.Text;
                soyad = textBox5.Text;
                numara = maskedTextBox1.Text;
                if (ort < 45)
                {
                    durum = "Kaldı!!";
                }
                else
                {
                    durum = "Geçti";
                }
                listBox1.Items.Add($"Ad:{ad} Soyad:{soyad} Numara:{numara} Ortalama:{ort} Durum:{durum}");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                maskedTextBox1.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Yanlış Veya Hatalı Giriş Yaptınız!!!");
            }
        }
    }
}
