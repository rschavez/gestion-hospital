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
    public partial class Meter : Form
    {
        public Meter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable mitabla = new DataTable();

            BaseDataSetTableAdapters.ConsultasTableAdapter tablaconsultas = new BaseDataSetTableAdapters.ConsultasTableAdapter();

           // mitabla = tablaconsultas;

            //dataGridView1.DataSource = mitabla;
        }
    }
}
