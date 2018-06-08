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
    public partial class Urgencias : Form
    {
        public Urgencias()
        {
            InitializeComponent();
        }

        private void nominasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nominasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDataSet);

        }

        private void Urgencias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'baseDataSet.Nominas' Puede moverla o quitarla según sea necesario.
            this.nominasTableAdapter.Fill(this.baseDataSet.Nominas);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable mitabla = new DataTable();

            BaseDataSetTableAdapters.ConsultasTableAdapter tablaconsultas = new BaseDataSetTableAdapters.ConsultasTableAdapter();

            mitabla = tablaconsultas.SelectQueryEspecialista("perico");

            dataGridView1.DataSource = mitabla;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuBotones.ventanaMenuBotones.Visible = true;
        }
    }
}
