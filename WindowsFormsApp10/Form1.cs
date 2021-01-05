using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class FormGomoku : Form
    {
        public FormGomoku()
        {
            InitializeComponent();
        }
        private void StretchPic()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
