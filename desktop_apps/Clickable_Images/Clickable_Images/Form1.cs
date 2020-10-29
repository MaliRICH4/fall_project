using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  
using System.Windows.Forms;

namespace Clickable_Images
{
    public partial class frmClickableImage : Form
    {
        public frmClickableImage()
        {
            InitializeComponent();
        }

        private void frmClickableImages_Click(object sender, EventArgs e)
        {
            MessageBox.Show("One", "Clickable Image");
            pictureBox1_Click.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Two", "Clickable Image");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Three", "Clickable Image");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Four", "Clickable Image");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Five", "Clickable Image");
        }

        private void frmClickableImage_Load(object sender, EventArgs e)
        {

        }
    }
}
