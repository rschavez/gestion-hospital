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
    public partial class Nominas : Form
    {
        public Nominas()
        {
            InitializeComponent();
        }

        private void ingresoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ingresoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDataSet);

        }

        private void Nominas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'baseDataSet.Nominas' Puede moverla o quitarla según sea necesario.
            this.nominasTableAdapter.Fill(this.baseDataSet.Nominas);
            // TODO: esta línea de código carga datos en la tabla 'baseDataSet.Ingreso' Puede moverla o quitarla según sea necesario.
            this.ingresoTableAdapter.Fill(this.baseDataSet.Ingreso);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuBotones.ventanaMenuBotones.Visible = true;
        }
    }
}
