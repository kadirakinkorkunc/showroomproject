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
    public partial class musterigirisi : Form
    {
        public musterigirisi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anagiris anagiris = new anagiris();
            this.Hide();
            anagiris.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\Desktop\C#\me\galeri\WindowsFormsApp1\veritabanı.mdf;Integrated Security=True");
            SqlCommand km = new SqlCommand("select * from uyeler where tc_no=@tc_nosu AND şifre=@şifresi",con); //db den tc noyu ve şifreleri seçiyorum

            SqlParameter tcno = new SqlParameter("tc_nosu", textBox1.Text.Trim());//trimm id ye girilen boşluk varsa yok ediyor.
            SqlParameter pw = new SqlParameter("şifresi", textBox2.Text.Trim());//text box lardan girilen değerleri parametre olucak şekilde atama yapıyor.
            km.Parameters.Add(tcno);
            km.Parameters.Add(pw);

            con.Open();
            km.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(km);
            DataTable dt = new DataTable();
            adp.Fill(dt);
     
            if (dt.Rows.Count>0 ) // >0 ın amacı dt'deki ilgili alanlar birbirini tutuyor mu diye sorgulatmak parametreden gelen değer ile veritabanındaki değer
            {
                musterigaleriekrani musterigaleriekrani = new musterigaleriekrani();
                this.Hide();
                musterigaleriekrani.Show();
                
            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
