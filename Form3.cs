using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Как к вам обращаться?")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }

        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Как к вам обращаться?";
                textBox3.ForeColor = Color.Gray;
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "        Ваш телефон")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }

        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "        Ваш телефон";
                textBox3.ForeColor = Color.Gray;
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "      Описание заявки")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }

        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "      Описание заявки";
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            requests r = new requests();
            r.request_id = 1;
            r.client_name = textBox3.Text;
            r.contact_info = textBox1.Text;
          
            r.user_request_text = textBox2.Text;

            

            Program.DB.requests.Add(r);
            Program.DB.SaveChanges();
            Close();
        }
    }
}
