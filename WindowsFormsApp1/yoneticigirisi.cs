using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class yoneticigirisi : Form
    {
        public yoneticigirisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adminid = "administrator";
            string pw = "thisispw";

            if(textBox1.Text != adminid && textBox2.Text != pw )
            {
                MessageBox.Show("HATALI GİRİŞ");
                textBox1.Text = "";
                textBox2.Text = "";
            }

            else
            {
                yoneticisecimekrani yoneticisecimekrani = new yoneticisecimekrani();
                this.Hide();
                yoneticisecimekrani.Show();
                    //kayıtlı üyeleri göster
                    //galeriyi göster
                    //galeri düzenleme ekranı
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            anagiris anagiris = new anagiris();
            this.Hide();
            anagiris.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
