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
        public int[] xmin = new int[225];
        public int[] xmax = new int[225];
        public int[] ymin = new int[225];
        public int[] ymax = new int[225];
        int x = MousePosition.X;
        int y = MousePosition.Y;
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
            for(int i =0; i < 15; i++)
            {
                for(int j = 0; j<15; j++)
                {
                    xmin[0] = 83;
                    xmin[j + 1] = xmin[j] + 33;
                    xmax[j] = xmin[j] + 30;
                    ymin[0] = 159;
                    ymax[j] = ymin[j] + 30;
                }
                ymin[i + 1] = ymin[i] + 33;
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           for(int i=0; i < 225; i++)
            {
                if(x > xmin[i] && x < xmax[i] && y > ymin[i] && y < ymax[i])
                {
                    MessageBox.Show(Convert.ToString(i));
                    
                }
            }
        }
    }
}
