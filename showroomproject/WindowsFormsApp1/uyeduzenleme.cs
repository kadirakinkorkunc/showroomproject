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
    public partial class uyeduzenleme : Form
    {
        public uyeduzenleme()
        {
            InitializeComponent();
        }

        ////change the sqlconnection path in different machines
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\Desktop\C#\me\galeri\WindowsFormsApp1\veritabanı.mdf;Integrated Security=True");

        private void goster()
        {
            SqlCommand km = new SqlCommand("select * from uyeler", con);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand km = new SqlCommand("insert into uyeler(tc_no,isim,şifre,mail) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);
                con.Open();
                km.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Üye başarıyla eklendi.");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                goster();

            }
            catch (Exception)
            {
                MessageBox.Show("HATA");
               // throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand km = new SqlCommand("DELETE FROM uyeler WHERE tc_no=@tc_no", con);
            con.Open();

            km.Parameters.AddWithValue("@tc_no", dataGridView1.SelectedRows[0].Cells[0].Value);
            km.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Girdi silinmiştir!");
            goster();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand km = new SqlCommand("UPDATE uyeler set isim=@isim,şifre=@şifre,mail=@mail WHERE tc_no=@tc_no", con);
            con.Open();
            km.Parameters.AddWithValue("@tc_no", dataGridView1.SelectedRows[0].Cells[0].Value);
            km.Parameters.AddWithValue("@isim", dataGridView1.SelectedCells[1].Value);
            km.Parameters.AddWithValue("@şifre", dataGridView1.SelectedCells[2].Value);
            km.Parameters.AddWithValue("@mail", dataGridView1.SelectedCells[3].Value);

            km.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Girdi güncellenmiştir!");
            goster();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
