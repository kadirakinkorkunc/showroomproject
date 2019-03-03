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
    public partial class anagiris : Form
    {
        public anagiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yoneticigirisi yoneticigirisi = new yoneticigirisi();
            this.Hide();
            yoneticigirisi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musterigirisi musterigirisi = new musterigirisi();
            this.Hide();
            musterigirisi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uyeol uyeol = new uyeol();
            this.Hide();
            uyeol.Show();
        }

        private void anagiris_Load(object sender, EventArgs e)
        {

        }
    }
}
