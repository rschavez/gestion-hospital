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
    public partial class BorrarQuery : Form
    {
        string loque = null;
        public BorrarQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable mitabla = new DataTable();

            BaseDataSetTableAdapters.IngresoTableAdapter tablaconsultas = new BaseDataSetTableAdapters.IngresoTableAdapter();
            
            tablaconsultas.DeleteQuery(1,loque);

            //dataGridView1.DataSource = mitabla;

            MessageBox.Show("Ingreso borrado correctamente");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            loque=dateTimePicker1.Text.ToString();
        }

        private void BorrarQuery_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuBotones.ventanaMenuBotones.Visible = true;
        }
    }
}
