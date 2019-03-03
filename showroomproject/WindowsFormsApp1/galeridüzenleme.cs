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
    public partial class galeridüzenleme : Form
    {
        public galeridüzenleme()
        {
            InitializeComponent();
        }

        //change the sqlconnection path in different machines
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\Desktop\C#\me\galeri\WindowsFormsApp1\veritabanı.mdf;Integrated Security=True");

        private void goster()
        {
            SqlCommand km = new SqlCommand("select * from galeri", con);
            con.Open();
            km.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(km);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            goster();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand km = new SqlCommand("UPDATE galeri SET araba_ismi=@araba_ismi,model=@model,üretim_yili=@üretim_yili,fiyat=@fiyat WHERE araba_id=@araba_id", con);
            con.Open();
            //MUST DECLARE SCALAR VAR ARABA_ID

            km.Parameters.AddWithValue("@araba_id", dataGridView1.SelectedRows[0].Cells[0].Value);
            km.Parameters.AddWithValue("@araba_ismi", dataGridView1.SelectedCells[1].Value);
            km.Parameters.AddWithValue("@model", dataGridView1.SelectedCells[2].Value);
            km.Parameters.AddWithValue("@üretim_yili", dataGridView1.SelectedCells[3].Value);
            km.Parameters.AddWithValue("@fiyat", dataGridView1.SelectedCells[4].Value);

            km.ExecuteNonQuery();
            MessageBox.Show("Girdi Güncellenmiştir!");
            con.Close();
            goster();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand km = new SqlCommand("DELETE FROM galeri WHERE araba_id=@araba_id", con);
            con.Open();

            km.Parameters.AddWithValue("@araba_id", dataGridView1.SelectedRows[0].Cells[0].Value);
            km.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Girdi silinmiştir!");
            goster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand km = new SqlCommand("insert into galeri(araba_ismi,model,üretim_yili,fiyat) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);
                con.Open();
                km.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Araç başarıyla eklendi.");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                goster();

            }
            catch (Exception)
            {
                MessageBox.Show("HATA");
                throw;
            }
        }
    }
}
