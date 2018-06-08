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
    public partial class MenuBotones : Form
    {
        public static MenuBotones ventanaMenuBotones;
        public static Consultas ventanaConsultas;
        public static ControlUrgencias ventanaControlUrgencias;
        public static Empleado ventanaEmpleado;
        public static Incidencias ventanaIncidencias;
        public static Ingreso ventanaIngreso;
        public static Nominas ventanaNominas;
        public static Operacion ventanaOperacion;
        public static Prueba ventanaPrueba;
        public static Urgenciascs ventanaUrgenciascs;
        public static Urgencias ventanaUrgenciasmeter;
        public static UpdateQuery ventanaUpdate;
        public static BorrarQuery ventanaBorrar;
        public MenuBotones()
        {
            InitializeComponent();
            ventanaMenuBotones = this;
            //if(ventanaConsultas.Close)
        }

        private void MenuBotones_Load(object sender, EventArgs e)
        {

        }

        private void bConsultas_Click(object sender, EventArgs e)
        {
            Consultas ventanaConsultas = new Consultas();
            ventanaConsultas.Show();

            this.Visible = false;
        }

        private void bContolUrgencias_Click(object sender, EventArgs e)
        {
            ControlUrgencias ventanaControlUrgencias = new ControlUrgencias();
            ventanaControlUrgencias.Show();

            this.Visible = false;
        }

        private void bEmpleado_Click(object sender, EventArgs e)
        {
            Empleado ventanaEmpleado = new Empleado();
            ventanaEmpleado.Show();

            this.Visible = false;
        }

        private void bIncidencias_Click(object sender, EventArgs e)
        {
            Incidencias ventanaIncidencias = new Incidencias();
            ventanaIncidencias.Show();

            this.Visible = false;
        }

        private void bIngreso_Click(object sender, EventArgs e)
        {
            Ingreso ventanaIngreso = new Ingreso();
            ventanaIngreso.Show();

            this.Visible = false;
        }

        private void bNominas_Click(object sender, EventArgs e)
        {
            Nominas ventanaNominas = new Nominas();
            ventanaNominas.Show();

            this.Visible = false;
        }

        private void bOperacion_Click(object sender, EventArgs e)
        {
            Operacion ventanaOperacion = new Operacion();
            ventanaOperacion.Show();

            this.Visible = false;
        }

        private void bPrueba_Click(object sender, EventArgs e)
        {
            Prueba ventanaPruebas = new Prueba();
            ventanaPruebas.Show();

            this.Visible = false;
        }

        private void bUrgencias_Click(object sender, EventArgs e)
        {
            Urgenciascs ventanaUrgencias = new Urgenciascs();
            ventanaUrgencias.Show();

            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Urgencias ventanaUrgenciasMeter = new Urgencias();
            ventanaUrgenciasMeter.Show();

            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateQuery ventanaUpdate = new UpdateQuery();
            ventanaUpdate.Show();

            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BorrarQuery ventanaBorrar = new BorrarQuery();
            ventanaBorrar.Show();

            this.Visible = false;
        }
    }
}
