﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public FormContextMenuStrip()

        {

            InitializeComponent();

        }

        

        private void lijevoDesnoToolStripMenuItem_Click(object sender, EventArgs e)

        {

            textBoxDesno.Text = textBoxLijevo.Text;

        }

        

        private void desnoLijevoToolStripMenuItem_Click(object sender, EventArgs e)

        {

            textBoxLijevo.Text = textBoxDesno.Text;

        }

    }
}
