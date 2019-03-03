using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class uyeol : Form
    {
        public uyeol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\Desktop\C#\me\galeri\WindowsFormsApp1\veritabanı.mdf;Integrated Security=True");
            SqlCommand km = new SqlCommand("insert into uyeler(tc_no,isim,şifre,mail) values('"+ textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')",con); 
            con.Open();
            km.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kaydınız oluşturulmuştur.");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            anagiris anagiris = new anagiris();
            this.Hide();
            anagiris.Show();
        }
    }
}
