using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageList
{
    public partial class Form1 : Form
    {
        
        
        public int brojac = 1;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = imageList1.Images[0];
        }
                    

       

        private void buttonPromijeni_Click_1(object sender, EventArgs e)
        {
            brojac++;
            if (brojac == 3)
            {
                pictureBox1.Image = imageList1.Images[1];
            }

            else
            {
                pictureBox1.Image = imageList1.Images[2];
            }
        }
    }
}
