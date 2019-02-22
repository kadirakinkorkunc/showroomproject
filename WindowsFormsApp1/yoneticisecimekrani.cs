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
    public partial class yoneticisecimekrani : Form
    {
        public yoneticisecimekrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uyeduzenleme uyeduzenleme = new uyeduzenleme();
            uyeduzenleme.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            galeridüzenleme galeridüzenleme = new galeridüzenleme();
            galeridüzenleme.Show();
        }
    }
}
