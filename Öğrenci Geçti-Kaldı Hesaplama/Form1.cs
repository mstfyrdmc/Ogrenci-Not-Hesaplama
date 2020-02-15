using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Öğrenci_Geçti_Kaldı_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, p1, ort;
            string durum;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            p1 = Convert.ToDouble(textBox3.Text);

            ort = (s1 * 0.20) + (s2 * 0.20) + (p1 * 0.60);

            if(ort<=45)
            {
                durum = "Maalesef Kaldınız.";
            }
            else
            {
                durum = "Tebrikler Geçtiniz.";
            }
            textBox4.Text = ort.ToString("0.000") + "   " + durum;
        }
    }
}
