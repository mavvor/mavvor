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
namespace WindowsFormsApp11
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
             
    }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iTDataSet.requests". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter.Fill(this.iTDataSet.requests);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            requests r = new requests();
          
            messages m = new messages();
            m.message_id = 1;
            m.message_text = textBox2.Text;
            Program.DB.requests.Add(r);
            Program.DB.SaveChanges();
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
