using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilimliste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> isimler = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            isimler.Add(textBox1.Text);
            MessageBox.Show("Kayıt Eklendi");
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(string s in isimler)
            {
                listBox1.Items.Add(s);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int durum =isimler.IndexOf(textBox2.Text);
            if (durum > -1)
            {
                MessageBox.Show("Kayıt Bulundu");
            }
            else
            {
                MessageBox.Show("Kayıt Bulunmadı");
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            textBox2.Text = listBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int durum = isimler.IndexOf(textBox2.Text);
            if (durum > -1)
            {
                isimler.Remove(textBox2.Text);
                MessageBox.Show("Kayıt Bulundu");
            }
            else
            {
                MessageBox.Show("Kayıt Bulunmadı");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int durum = isimler.IndexOf(textBox2.Text);
            textBox1.Focus();
            textBox1.BackColor = Color.Bisque;
            if (durum > -1)
            {
                isimler.Insert(durum,textBox1.Text);
                isimler.Remove(textBox2.Text);
                MessageBox.Show("Kayıt Bulundu");
            }
            else
            {
                MessageBox.Show("Kayıt Bulunmadı");
            }
        }
    }
}
