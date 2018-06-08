namespace ProyectoC
{
    partial class ControlUrgencias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label fechaYHoraLabel;
            System.Windows.Forms.Label pacienteLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label valoracionLabel;
            System.Windows.Forms.Label nombreMedicamentoLabel;
            System.Windows.Forms.Label dosisLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlUrgencias));
            this.baseDataSet = new ProyectoC.BaseDataSet();
            this.controlUrgenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlUrgenciasTableAdapter = new ProyectoC.BaseDataSetTableAdapters.ControlUrgenciasTableAdapter();
            this.tableAdapterManager = new ProyectoC.BaseDataSetTableAdapters.TableAdapterManager();
            this.controlUrgenciasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.controlUrgenciasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.controlUrgenciasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.fechaYHoraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pacienteTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.valoracionTextBox = new System.Windows.Forms.TextBox();
            this.nombreMedicamentoTextBox = new System.Windows.Forms.TextBox();
            this.dosisTextBox = new System.Windows.Forms.TextBox();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.bMenuPrincipal = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            fechaYHoraLabel = new System.Windows.Forms.Label();
            pacienteLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            valoracionLabel = new System.Windows.Forms.Label();
            nombreMedicamentoLabel = new System.Windows.Forms.Label();
            dosisLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlUrgenciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlUrgenciasBindingNavigator)).BeginInit();
            this.controlUrgenciasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlUrgenciasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(154, 66);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // fechaYHoraLabel
            // 
            fechaYHoraLabel.AutoSize = true;
            fechaYHoraLabel.Location = new System.Drawing.Point(154, 95);
            fechaYHoraLabel.Name = "fechaYHoraLabel";
            fechaYHoraLabel.Size = new System.Drawing.Size(91, 17);
            fechaYHoraLabel.TabIndex = 4;
            fechaYHoraLabel.Text = "fecha YHora:";
            // 
            // pacienteLabel
            // 
            pacienteLabel.AutoSize = true;
            pacienteLabel.Location = new System.Drawing.Point(154, 122);
            pacienteLabel.Name = "pacienteLabel";
            pacienteLabel.Size = new System.Drawing.Size(66, 17);
            pacienteLabel.TabIndex = 6;
            pacienteLabel.Text = "paciente:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(154, 150);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(35, 17);
            tipoLabel.TabIndex = 8;
            tipoLabel.Text = "tipo:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(154, 178);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 17);
            nombreLabel.TabIndex = 10;
            nombreLabel.Text = "nombre:";
            // 
            // valoracionLabel
            // 
            valoracionLabel.AutoSize = true;
            valoracionLabel.Location = new System.Drawing.Point(154, 206);
            valoracionLabel.Name = "valoracionLabel";
            valoracionLabel.Size = new System.Drawing.Size(77, 17);
            valoracionLabel.TabIndex = 12;
            valoracionLabel.Text = "valoracion:";
            // 
            // nombreMedicamentoLabel
            // 
            nombreMedicamentoLabel.AutoSize = true;
            nombreMedicamentoLabel.Location = new System.Drawing.Point(154, 234);
            nombreMedicamentoLabel.Name = "nombreMedicamentoLabel";
            nombreMedicamentoLabel.Size = new System.Drawing.Size(148, 17);
            nombreMedicamentoLabel.TabIndex = 14;
            nombreMedicamentoLabel.Text = "nombre Medicamento:";
            // 
            // dosisLabel
            // 
            dosisLabel.AutoSize = true;
            dosisLabel.Location = new System.Drawing.Point(154, 262);
            dosisLabel.Name = "dosisLabel";
            dosisLabel.Size = new System.Drawing.Size(45, 17);
            dosisLabel.TabIndex = 16;
            dosisLabel.Text = "dosis:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(154, 290);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(66, 17);
            cantidadLabel.TabIndex = 18;
            cantidadLabel.Text = "cantidad:";
            // 
            // baseDataSet
            // 
            this.baseDataSet.DataSetName = "BaseDataSet";
            this.baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controlUrgenciasBindingSource
            // 
            this.controlUrgenciasBindingSource.DataMember = "ControlUrgencias";
            this.controlUrgenciasBindingSource.DataSource = this.baseDataSet;
            // 
            // controlUrgenciasTableAdapter
            // 
            this.controlUrgenciasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultasTableAdapter = null;
            this.tableAdapterManager.ControlUrgenciasTableAdapter = this.controlUrgenciasTableAdapter;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.IncidenciasTableAdapter = null;
            this.tableAdapterManager.IngresoTableAdapter = null;
            this.tableAdapterManager.NominasTableAdapter = null;
            this.tableAdapterManager.OperacionTableAdapter = null;
            this.tableAdapterManager.PruebaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoC.BaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UrgenciasTableAdapter = null;
            // 
            // controlUrgenciasBindingNavigator
            // 
            this.controlUrgenciasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.controlUrgenciasBindingNavigator.BindingSource = this.controlUrgenciasBindingSource;
            this.controlUrgenciasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.controlUrgenciasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.controlUrgenciasBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.controlUrgenciasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.controlUrgenciasBindingNavigatorSaveItem});
            this.controlUrgenciasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.controlUrgenciasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.controlUrgenciasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.controlUrgenciasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.controlUrgenciasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.controlUrgenciasBindingNavigator.Name = "controlUrgenciasBindingNavigator";
            this.controlUrgenciasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.controlUrgenciasBindingNavigator.Size = new System.Drawing.Size(718, 27);
            this.controlUrgenciasBindingNavigator.TabIndex = 0;
            this.controlUrgenciasBindingNavigator.Text = "bindingNavigator1";
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
            // controlUrgenciasBindingNavigatorSaveItem
            // 
            this.controlUrgenciasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.controlUrgenciasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("controlUrgenciasBindingNavigatorSaveItem.Image")));
            this.controlUrgenciasBindingNavigatorSaveItem.Name = "controlUrgenciasBindingNavigatorSaveItem";
            this.controlUrgenciasBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.controlUrgenciasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.controlUrgenciasBindingNavigatorSaveItem.Click += new System.EventHandler(this.controlUrgenciasBindingNavigatorSaveItem_Click);
            // 
            // controlUrgenciasDataGridView
            // 
            this.controlUrgenciasDataGridView.AutoGenerateColumns = false;
            this.controlUrgenciasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.controlUrgenciasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.controlUrgenciasDataGridView.DataSource = this.controlUrgenciasBindingSource;
            this.controlUrgenciasDataGridView.Location = new System.Drawing.Point(93, 376);
            this.controlUrgenciasDataGridView.Name = "controlUrgenciasDataGridView";
            this.controlUrgenciasDataGridView.RowTemplate.Height = 24;
            this.controlUrgenciasDataGridView.Size = new System.Drawing.Size(575, 220);
            this.controlUrgenciasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fechaYHora";
            this.dataGridViewTextBoxColumn2.HeaderText = "fechaYHora";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "paciente";
            this.dataGridViewTextBoxColumn3.HeaderText = "paciente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tipo";
            this.dataGridViewTextBoxColumn4.HeaderText = "tipo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn5.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "valoracion";
            this.dataGridViewTextBoxColumn6.HeaderText = "valoracion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "nombreMedicamento";
            this.dataGridViewTextBoxColumn7.HeaderText = "nombreMedicamento";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "dosis";
            this.dataGridViewTextBoxColumn8.HeaderText = "dosis";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn9.HeaderText = "cantidad";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlUrgenciasBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(308, 63);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 22);
            this.idTextBox.TabIndex = 3;
            // 
            // fechaYHoraDateTimePicker
            // 
            this.fechaYHoraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.controlUrgenciasBindingSource, "fechaYHora", true));
            this.fechaYHoraDateTimePicker.Location = new System.Drawing.Point(308, 91);
            this.fechaYHoraDateTimePicker.Name = "fechaYHoraDateTimePicker";
            this.fechaYHoraDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fechaYHoraDateTimePicker.TabIndex = 5;
            // 
            // pacienteTextBox
            // 
            this.pacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlUrgenciasBindingSource, "paciente", true));
            this.pacienteTextBox.Location = new System.Drawing.Point(308, 119);
            this.pacienteTextBox.Name = "pacienteTextBox";
            this.pacienteTextBox.Size = new System.Drawing.Size(200, 22);
            this.pacienteTextBox.TabIndex = 7;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlUrgenciasBindingSource, "tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(308, 147);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(200, 22);
            this.tipoTextBox.TabIndex = 9;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlUrgenciasBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(308, 175);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 22);
            this.nombreTextBox.TabIndex = 11;
            // 
            // valoracionTextBox
            // 
            this.valoracionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlUrgenciasBindingSource, "valoracion", true));
            this.valoracionTextBox.Location = new System.Drawing.Point(308, 203);
            this.valoracionTextBox.Name = "valoracionTextBox";
            this.valoracionTextBox.Size = new System.Drawing.Size(200, 22);
            this.valoracionTextBox.TabIndex = 13;
            // 
            // nombreMedicamentoTextBox
            // 
            this.nombreMedicamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlUrgenciasBindingSource, "nombreMedicamento", true));
            this.nombreMedicamentoTextBox.Location = new System.Drawing.Point(308, 231);
            this.nombreMedicamentoTextBox.Name = "nombreMedicamentoTextBox";
            this.nombreMedicamentoTextBox.Size = new System.Drawing.Size(200, 22);
            this.nombreMedicamentoTextBox.TabIndex = 15;
            // 
            // dosisTextBox
            // 
            this.dosisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlUrgenciasBindingSource, "dosis", true));
            this.dosisTextBox.Location = new System.Drawing.Point(308, 259);
            this.dosisTextBox.Name = "dosisTextBox";
            this.dosisTextBox.Size = new System.Drawing.Size(200, 22);
            this.dosisTextBox.TabIndex = 17;
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlUrgenciasBindingSource, "cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(308, 287);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(200, 22);
            this.cantidadTextBox.TabIndex = 19;
            // 
            // bMenuPrincipal
            // 
            this.bMenuPrincipal.Location = new System.Drawing.Point(571, 116);
            this.bMenuPrincipal.Name = "bMenuPrincipal";
            this.bMenuPrincipal.Size = new System.Drawing.Size(75, 23);
            this.bMenuPrincipal.TabIndex = 20;
            this.bMenuPrincipal.Text = "MenuPrincipal";
            this.bMenuPrincipal.UseVisualStyleBackColor = true;
            this.bMenuPrincipal.Click += new System.EventHandler(this.bMenuPrincipal_Click);
            // 
            // ControlUrgencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 626);
            this.Controls.Add(this.bMenuPrincipal);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(fechaYHoraLabel);
            this.Controls.Add(this.fechaYHoraDateTimePicker);
            this.Controls.Add(pacienteLabel);
            this.Controls.Add(this.pacienteTextBox);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(valoracionLabel);
            this.Controls.Add(this.valoracionTextBox);
            this.Controls.Add(nombreMedicamentoLabel);
            this.Controls.Add(this.nombreMedicamentoTextBox);
            this.Controls.Add(dosisLabel);
            this.Controls.Add(this.dosisTextBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(this.controlUrgenciasDataGridView);
            this.Controls.Add(this.controlUrgenciasBindingNavigator);
            this.Name = "ControlUrgencias";
            this.Text = "ControlUrgencias";
            this.Load += new System.EventHandler(this.ControlUrgencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlUrgenciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlUrgenciasBindingNavigator)).EndInit();
            this.controlUrgenciasBindingNavigator.ResumeLayout(false);
            this.controlUrgenciasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlUrgenciasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseDataSet baseDataSet;
        private System.Windows.Forms.BindingSource controlUrgenciasBindingSource;
        private BaseDataSetTableAdapters.ControlUrgenciasTableAdapter controlUrgenciasTableAdapter;
        private BaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator controlUrgenciasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton controlUrgenciasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView controlUrgenciasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker fechaYHoraDateTimePicker;
        private System.Windows.Forms.TextBox pacienteTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox valoracionTextBox;
        private System.Windows.Forms.TextBox nombreMedicamentoTextBox;
        private System.Windows.Forms.TextBox dosisTextBox;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.Button bMenuPrincipal;
    }
}