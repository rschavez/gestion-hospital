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
    public partial class ControlUrgencias : Form
    {
        public ControlUrgencias()
        {
            InitializeComponent();
        }

        private void controlUrgenciasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.controlUrgenciasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDataSet);

        }

        private void ControlUrgencias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'baseDataSet.ControlUrgencias' Puede moverla o quitarla según sea necesario.
            this.controlUrgenciasTableAdapter.Fill(this.baseDataSet.ControlUrgencias);

        }

        private void bMenuPrincipal_Click(object sender, EventArgs e)
        {
            MenuBotones.ventanaMenuBotones.Visible = true;
            this.Close();
        }
    }
}
