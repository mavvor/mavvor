﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Form4 frm4;
        Form3 frm3;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            frm4 = new Form4();
            frm4.Show();
        }
    }
}
