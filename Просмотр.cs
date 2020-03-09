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
    public partial class Просмотр : Form
    {
        public Просмотр()
        {
            InitializeComponent();
        }

        private void Просмотр_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iTDataSet.messages". При необходимости она может быть перемещена или удалена.
            this.messagesTableAdapter.Fill(this.iTDataSet.messages);

        }
    }
}
