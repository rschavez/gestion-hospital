using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoC
{
    public partial class UpdateQuery : Form
    {
        public UpdateQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable mitabla = new DataTable();

            BaseDataSetTableAdapters.PruebaTableAdapter tablaconsultas = new BaseDataSetTableAdapters.PruebaTableAdapter();

            tablaconsultas.UpdateQuery(textBox1.Text,int.Parse(textBox2.Text),int.Parse(textBox2.Text));

            MessageBox.Show("Se ha producido el update");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuBotones.ventanaMenuBotones.Visible = true;
        }
    }
}
