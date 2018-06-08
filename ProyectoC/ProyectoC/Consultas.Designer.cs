namespace ProyectoC
{
    partial class Consultas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreEspecialidadLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label especialistaLabel;
            System.Windows.Forms.Label pacienteLabel;
            System.Windows.Forms.Label motivoLabel;
            System.Windows.Forms.Label juicioLabel;
            System.Windows.Forms.Label listaPruebasLabel;
            System.Windows.Forms.Label tratamientoLabel;
            System.Windows.Forms.Label derivacionLabel;
            System.Windows.Forms.Label hospitalicionLabel;
            this.baseDataSet = new ProyectoC.BaseDataSet();
            this.consultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultasTableAdapter = new ProyectoC.BaseDataSetTableAdapters.ConsultasTableAdapter();
            this.tableAdapterManager = new ProyectoC.BaseDataSetTableAdapters.TableAdapterManager();
            this.consultasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.consultasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bMenuPrincipal = new System.Windows.Forms.Button();
            this.consultasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreEspecialidadTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.especialistaTextBox = new System.Windows.Forms.TextBox();
            this.pacienteTextBox = new System.Windows.Forms.TextBox();
            this.motivoTextBox = new System.Windows.Forms.TextBox();
            this.juicioTextBox = new System.Windows.Forms.TextBox();
            this.listaPruebasTextBox = new System.Windows.Forms.TextBox();
            this.tratamientoTextBox = new System.Windows.Forms.TextBox();
            this.derivacionTextBox = new System.Windows.Forms.TextBox();
            this.hospitalicionTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nombreEspecialidadLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            especialistaLabel = new System.Windows.Forms.Label();
            pacienteLabel = new System.Windows.Forms.Label();
            motivoLabel = new System.Windows.Forms.Label();
            juicioLabel = new System.Windows.Forms.Label();
            listaPruebasLabel = new System.Windows.Forms.Label();
            tratamientoLabel = new System.Windows.Forms.Label();
            derivacionLabel = new System.Windows.Forms.Label();
            hospitalicionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingNavigator)).BeginInit();
            this.consultasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // baseDataSet
            // 
            this.baseDataSet.DataSetName = "BaseDataSet";
            this.baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultasBindingSource
            // 
            this.consultasBindingSource.DataMember = "Consultas";
            this.consultasBindingSource.DataSource = this.baseDataSet;
            // 
            // consultasTableAdapter
            // 
            this.consultasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultasTableAdapter = this.consultasTableAdapter;
            this.tableAdapterManager.ControlUrgenciasTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.IncidenciasTableAdapter = null;
            this.tableAdapterManager.IngresoTableAdapter = null;
            this.tableAdapterManager.NominasTableAdapter = null;
            this.tableAdapterManager.OperacionTableAdapter = null;
            this.tableAdapterManager.PruebaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoC.BaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UrgenciasTableAdapter = null;
            // 
            // consultasBindingNavigator
            // 
            this.consultasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consultasBindingNavigator.BindingSource = this.consultasBindingSource;
            this.consultasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.consultasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.consultasBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.consultasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.consultasBindingNavigatorSaveItem});
            this.consultasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.consultasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consultasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consultasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consultasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consultasBindingNavigator.Name = "consultasBindingNavigator";
            this.consultasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consultasBindingNavigator.Size = new System.Drawing.Size(986, 27);
            this.consultasBindingNavigator.TabIndex = 0;
            this.consultasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // consultasBindingNavigatorSaveItem
            // 
            this.consultasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consultasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consultasBindingNavigatorSaveItem.Image")));
            this.consultasBindingNavigatorSaveItem.Name = "consultasBindingNavigatorSaveItem";
            this.consultasBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.consultasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.consultasBindingNavigatorSaveItem.Click += new System.EventHandler(this.consultasBindingNavigatorSaveItem_Click_1);
            // 
            // bMenuPrincipal
            // 
            this.bMenuPrincipal.Location = new System.Drawing.Point(723, 92);
            this.bMenuPrincipal.Name = "bMenuPrincipal";
            this.bMenuPrincipal.Size = new System.Drawing.Size(113, 23);
            this.bMenuPrincipal.TabIndex = 25;
            this.bMenuPrincipal.Text = "bMenuPrincipal";
            this.bMenuPrincipal.UseVisualStyleBackColor = true;
            this.bMenuPrincipal.Click += new System.EventHandler(this.bMenuPrincipal_Click);
            // 
            // consultasDataGridView
            // 
            this.consultasDataGridView.AutoGenerateColumns = false;
            this.consultasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.consultasDataGridView.DataSource = this.consultasBindingSource;
            this.consultasDataGridView.Location = new System.Drawing.Point(64, 404);
            this.consultasDataGridView.Name = "consultasDataGridView";
            this.consultasDataGridView.RowTemplate.Height = 24;
            this.consultasDataGridView.Size = new System.Drawing.Size(858, 220);
            this.consultasDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombreEspecialidad";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombreEspecialidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn3.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "hora";
            this.dataGridViewImageColumn1.HeaderText = "hora";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "especialista";
            this.dataGridViewTextBoxColumn4.HeaderText = "especialista";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "paciente";
            this.dataGridViewTextBoxColumn5.HeaderText = "paciente";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "motivo";
            this.dataGridViewTextBoxColumn6.HeaderText = "motivo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "juicio";
            this.dataGridViewTextBoxColumn7.HeaderText = "juicio";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "listaPruebas";
            this.dataGridViewTextBoxColumn8.HeaderText = "listaPruebas";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "tratamiento";
            this.dataGridViewTextBoxColumn9.HeaderText = "tratamiento";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "derivacion";
            this.dataGridViewTextBoxColumn10.HeaderText = "derivacion";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "hospitalicion";
            this.dataGridViewTextBoxColumn11.HeaderText = "hospitalicion";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(126, 52);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 25;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(276, 49);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 22);
            this.idTextBox.TabIndex = 26;
            // 
            // nombreEspecialidadLabel
            // 
            nombreEspecialidadLabel.AutoSize = true;
            nombreEspecialidadLabel.Location = new System.Drawing.Point(126, 80);
            nombreEspecialidadLabel.Name = "nombreEspecialidadLabel";
            nombreEspecialidadLabel.Size = new System.Drawing.Size(144, 17);
            nombreEspecialidadLabel.TabIndex = 27;
            nombreEspecialidadLabel.Text = "nombre Especialidad:";
            // 
            // nombreEspecialidadTextBox
            // 
            this.nombreEspecialidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "nombreEspecialidad", true));
            this.nombreEspecialidadTextBox.Location = new System.Drawing.Point(276, 77);
            this.nombreEspecialidadTextBox.Name = "nombreEspecialidadTextBox";
            this.nombreEspecialidadTextBox.Size = new System.Drawing.Size(200, 22);
            this.nombreEspecialidadTextBox.TabIndex = 28;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(126, 109);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(47, 17);
            fechaLabel.TabIndex = 29;
            fechaLabel.Text = "fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultasBindingSource, "fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(276, 105);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fechaDateTimePicker.TabIndex = 30;
            // 
            // especialistaLabel
            // 
            especialistaLabel.AutoSize = true;
            especialistaLabel.Location = new System.Drawing.Point(126, 136);
            especialistaLabel.Name = "especialistaLabel";
            especialistaLabel.Size = new System.Drawing.Size(86, 17);
            especialistaLabel.TabIndex = 31;
            especialistaLabel.Text = "especialista:";
            // 
            // especialistaTextBox
            // 
            this.especialistaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "especialista", true));
            this.especialistaTextBox.Location = new System.Drawing.Point(276, 133);
            this.especialistaTextBox.Name = "especialistaTextBox";
            this.especialistaTextBox.Size = new System.Drawing.Size(200, 22);
            this.especialistaTextBox.TabIndex = 32;
            // 
            // pacienteLabel
            // 
            pacienteLabel.AutoSize = true;
            pacienteLabel.Location = new System.Drawing.Point(126, 164);
            pacienteLabel.Name = "pacienteLabel";
            pacienteLabel.Size = new System.Drawing.Size(66, 17);
            pacienteLabel.TabIndex = 33;
            pacienteLabel.Text = "paciente:";
            // 
            // pacienteTextBox
            // 
            this.pacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "paciente", true));
            this.pacienteTextBox.Location = new System.Drawing.Point(276, 161);
            this.pacienteTextBox.Name = "pacienteTextBox";
            this.pacienteTextBox.Size = new System.Drawing.Size(200, 22);
            this.pacienteTextBox.TabIndex = 34;
            // 
            // motivoLabel
            // 
            motivoLabel.AutoSize = true;
            motivoLabel.Location = new System.Drawing.Point(126, 192);
            motivoLabel.Name = "motivoLabel";
            motivoLabel.Size = new System.Drawing.Size(53, 17);
            motivoLabel.TabIndex = 35;
            motivoLabel.Text = "motivo:";
            // 
            // motivoTextBox
            // 
            this.motivoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "motivo", true));
            this.motivoTextBox.Location = new System.Drawing.Point(276, 189);
            this.motivoTextBox.Name = "motivoTextBox";
            this.motivoTextBox.Size = new System.Drawing.Size(200, 22);
            this.motivoTextBox.TabIndex = 36;
            // 
            // juicioLabel
            // 
            juicioLabel.AutoSize = true;
            juicioLabel.Location = new System.Drawing.Point(126, 220);
            juicioLabel.Name = "juicioLabel";
            juicioLabel.Size = new System.Drawing.Size(44, 17);
            juicioLabel.TabIndex = 37;
            juicioLabel.Text = "juicio:";
            // 
            // juicioTextBox
            // 
            this.juicioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "juicio", true));
            this.juicioTextBox.Location = new System.Drawing.Point(276, 217);
            this.juicioTextBox.Name = "juicioTextBox";
            this.juicioTextBox.Size = new System.Drawing.Size(200, 22);
            this.juicioTextBox.TabIndex = 38;
            // 
            // listaPruebasLabel
            // 
            listaPruebasLabel.AutoSize = true;
            listaPruebasLabel.Location = new System.Drawing.Point(126, 248);
            listaPruebasLabel.Name = "listaPruebasLabel";
            listaPruebasLabel.Size = new System.Drawing.Size(94, 17);
            listaPruebasLabel.TabIndex = 39;
            listaPruebasLabel.Text = "lista Pruebas:";
            // 
            // listaPruebasTextBox
            // 
            this.listaPruebasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "listaPruebas", true));
            this.listaPruebasTextBox.Location = new System.Drawing.Point(276, 245);
            this.listaPruebasTextBox.Name = "listaPruebasTextBox";
            this.listaPruebasTextBox.Size = new System.Drawing.Size(200, 22);
            this.listaPruebasTextBox.TabIndex = 40;
            // 
            // tratamientoLabel
            // 
            tratamientoLabel.AutoSize = true;
            tratamientoLabel.Location = new System.Drawing.Point(126, 276);
            tratamientoLabel.Name = "tratamientoLabel";
            tratamientoLabel.Size = new System.Drawing.Size(83, 17);
            tratamientoLabel.TabIndex = 41;
            tratamientoLabel.Text = "tratamiento:";
            // 
            // tratamientoTextBox
            // 
            this.tratamientoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "tratamiento", true));
            this.tratamientoTextBox.Location = new System.Drawing.Point(276, 273);
            this.tratamientoTextBox.Name = "tratamientoTextBox";
            this.tratamientoTextBox.Size = new System.Drawing.Size(200, 22);
            this.tratamientoTextBox.TabIndex = 42;
            // 
            // derivacionLabel
            // 
            derivacionLabel.AutoSize = true;
            derivacionLabel.Location = new System.Drawing.Point(126, 304);
            derivacionLabel.Name = "derivacionLabel";
            derivacionLabel.Size = new System.Drawing.Size(77, 17);
            derivacionLabel.TabIndex = 43;
            derivacionLabel.Text = "derivacion:";
            // 
            // derivacionTextBox
            // 
            this.derivacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "derivacion", true));
            this.derivacionTextBox.Location = new System.Drawing.Point(276, 301);
            this.derivacionTextBox.Name = "derivacionTextBox";
            this.derivacionTextBox.Size = new System.Drawing.Size(200, 22);
            this.derivacionTextBox.TabIndex = 44;
            // 
            // hospitalicionLabel
            // 
            hospitalicionLabel.AutoSize = true;
            hospitalicionLabel.Location = new System.Drawing.Point(126, 332);
            hospitalicionLabel.Name = "hospitalicionLabel";
            hospitalicionLabel.Size = new System.Drawing.Size(90, 17);
            hospitalicionLabel.TabIndex = 45;
            hospitalicionLabel.Text = "hospitalicion:";
            // 
            // hospitalicionTextBox
            // 
            this.hospitalicionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "hospitalicion", true));
            this.hospitalicionTextBox.Location = new System.Drawing.Point(276, 329);
            this.hospitalicionTextBox.Name = "hospitalicionTextBox";
            this.hospitalicionTextBox.Size = new System.Drawing.Size(200, 22);
            this.hospitalicionTextBox.TabIndex = 46;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 653);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreEspecialidadLabel);
            this.Controls.Add(this.nombreEspecialidadTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(especialistaLabel);
            this.Controls.Add(this.especialistaTextBox);
            this.Controls.Add(pacienteLabel);
            this.Controls.Add(this.pacienteTextBox);
            this.Controls.Add(motivoLabel);
            this.Controls.Add(this.motivoTextBox);
            this.Controls.Add(juicioLabel);
            this.Controls.Add(this.juicioTextBox);
            this.Controls.Add(listaPruebasLabel);
            this.Controls.Add(this.listaPruebasTextBox);
            this.Controls.Add(tratamientoLabel);
            this.Controls.Add(this.tratamientoTextBox);
            this.Controls.Add(derivacionLabel);
            this.Controls.Add(this.derivacionTextBox);
            this.Controls.Add(hospitalicionLabel);
            this.Controls.Add(this.hospitalicionTextBox);
            this.Controls.Add(this.consultasDataGridView);
            this.Controls.Add(this.bMenuPrincipal);
            this.Controls.Add(this.consultasBindingNavigator);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingNavigator)).EndInit();
            this.consultasBindingNavigator.ResumeLayout(false);
            this.consultasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseDataSet baseDataSet;
        private System.Windows.Forms.BindingSource consultasBindingSource;
        private BaseDataSetTableAdapters.ConsultasTableAdapter consultasTableAdapter;
        private BaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator consultasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton consultasBindingNavigatorSaveItem;
        private System.Windows.Forms.Button bMenuPrincipal;
        private System.Windows.Forms.DataGridView consultasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreEspecialidadTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox especialistaTextBox;
        private System.Windows.Forms.TextBox pacienteTextBox;
        private System.Windows.Forms.TextBox motivoTextBox;
        private System.Windows.Forms.TextBox juicioTextBox;
        private System.Windows.Forms.TextBox listaPruebasTextBox;
        private System.Windows.Forms.TextBox tratamientoTextBox;
        private System.Windows.Forms.TextBox derivacionTextBox;
        private System.Windows.Forms.TextBox hospitalicionTextBox;
    }
}

