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
    public partial class Operacion : Form
    {
        public Operacion()
        {
            InitializeComponent();
        }

        private void operacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.operacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDataSet);

        }

        private void Operacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'baseDataSet.Operacion' Puede moverla o quitarla según sea necesario.
            this.operacionTableAdapter.Fill(this.baseDataSet.Operacion);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuBotones.ventanaMenuBotones.Visible = true;
        }
    }
}
