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
    public partial class musterigaleriekrani : Form
    {
        public musterigaleriekrani()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\Desktop\C#\me\galeri\WindowsFormsApp1\veritabanı.mdf;Integrated Security=True");
            SqlCommand km = new SqlCommand("select * from galeri",con);
            con.Open();
            km.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(km);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void musterigaleriekrani_Load(object sender, EventArgs e)
        {

        }
    }
}
