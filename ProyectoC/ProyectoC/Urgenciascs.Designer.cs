namespace ProyectoC
{
    partial class Urgenciascs
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
            System.Windows.Forms.Label pacienteLabel;
            System.Windows.Forms.Label fechaYHoraLabel;
            System.Windows.Forms.Label facultativoInicialLabel;
            System.Windows.Forms.Label juricioInicialLabel;
            System.Windows.Forms.Label listaPruebasLabel;
            System.Windows.Forms.Label remisionSalaLabel;
            System.Windows.Forms.Label remisionCirugiaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urgenciascs));
            this.baseDataSet = new ProyectoC.BaseDataSet();
            this.urgenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urgenciasTableAdapter = new ProyectoC.BaseDataSetTableAdapters.UrgenciasTableAdapter();
            this.tableAdapterManager = new ProyectoC.BaseDataSetTableAdapters.TableAdapterManager();
            this.urgenciasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.urgenciasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.pacienteTextBox = new System.Windows.Forms.TextBox();
            this.fechaYHoraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.facultativoInicialTextBox = new System.Windows.Forms.TextBox();
            this.juricioInicialTextBox = new System.Windows.Forms.TextBox();
            this.listaPruebasTextBox = new System.Windows.Forms.TextBox();
            this.remisionSalaTextBox = new System.Windows.Forms.TextBox();
            this.remisionCirugiaTextBox = new System.Windows.Forms.TextBox();
            this.urgenciasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            pacienteLabel = new System.Windows.Forms.Label();
            fechaYHoraLabel = new System.Windows.Forms.Label();
            facultativoInicialLabel = new System.Windows.Forms.Label();
            juricioInicialLabel = new System.Windows.Forms.Label();
            listaPruebasLabel = new System.Windows.Forms.Label();
            remisionSalaLabel = new System.Windows.Forms.Label();
            remisionCirugiaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urgenciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urgenciasBindingNavigator)).BeginInit();
            this.urgenciasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urgenciasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(178, 217);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // pacienteLabel
            // 
            pacienteLabel.AutoSize = true;
            pacienteLabel.Location = new System.Drawing.Point(178, 245);
            pacienteLabel.Name = "pacienteLabel";
            pacienteLabel.Size = new System.Drawing.Size(66, 17);
            pacienteLabel.TabIndex = 3;
            pacienteLabel.Text = "paciente:";
            // 
            // fechaYHoraLabel
            // 
            fechaYHoraLabel.AutoSize = true;
            fechaYHoraLabel.Location = new System.Drawing.Point(178, 274);
            fechaYHoraLabel.Name = "fechaYHoraLabel";
            fechaYHoraLabel.Size = new System.Drawing.Size(91, 17);
            fechaYHoraLabel.TabIndex = 5;
            fechaYHoraLabel.Text = "fecha YHora:";
            // 
            // facultativoInicialLabel
            // 
            facultativoInicialLabel.AutoSize = true;
            facultativoInicialLabel.Location = new System.Drawing.Point(178, 301);
            facultativoInicialLabel.Name = "facultativoInicialLabel";
            facultativoInicialLabel.Size = new System.Drawing.Size(115, 17);
            facultativoInicialLabel.TabIndex = 7;
            facultativoInicialLabel.Text = "facultativo Inicial:";
            // 
            // juricioInicialLabel
            // 
            juricioInicialLabel.AutoSize = true;
            juricioInicialLabel.Location = new System.Drawing.Point(178, 329);
            juricioInicialLabel.Name = "juricioInicialLabel";
            juricioInicialLabel.Size = new System.Drawing.Size(88, 17);
            juricioInicialLabel.TabIndex = 9;
            juricioInicialLabel.Text = "juricio Inicial:";
            // 
            // listaPruebasLabel
            // 
            listaPruebasLabel.AutoSize = true;
            listaPruebasLabel.Location = new System.Drawing.Point(178, 357);
            listaPruebasLabel.Name = "listaPruebasLabel";
            listaPruebasLabel.Size = new System.Drawing.Size(94, 17);
            listaPruebasLabel.TabIndex = 11;
            listaPruebasLabel.Text = "lista Pruebas:";
            // 
            // remisionSalaLabel
            // 
            remisionSalaLabel.AutoSize = true;
            remisionSalaLabel.Location = new System.Drawing.Point(178, 385);
            remisionSalaLabel.Name = "remisionSalaLabel";
            remisionSalaLabel.Size = new System.Drawing.Size(97, 17);
            remisionSalaLabel.TabIndex = 13;
            remisionSalaLabel.Text = "remision Sala:";
            // 
            // remisionCirugiaLabel
            // 
            remisionCirugiaLabel.AutoSize = true;
            remisionCirugiaLabel.Location = new System.Drawing.Point(178, 413);
            remisionCirugiaLabel.Name = "remisionCirugiaLabel";
            remisionCirugiaLabel.Size = new System.Drawing.Size(113, 17);
            remisionCirugiaLabel.TabIndex = 15;
            remisionCirugiaLabel.Text = "remision Cirugia:";
            // 
            // baseDataSet
            // 
            this.baseDataSet.DataSetName = "BaseDataSet";
            this.baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urgenciasBindingSource
            // 
            this.urgenciasBindingSource.DataMember = "Urgencias";
            this.urgenciasBindingSource.DataSource = this.baseDataSet;
            // 
            // urgenciasTableAdapter
            // 
            this.urgenciasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultasTableAdapter = null;
            this.tableAdapterManager.ControlUrgenciasTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.IncidenciasTableAdapter = null;
            this.tableAdapterManager.IngresoTableAdapter = null;
            this.tableAdapterManager.NominasTableAdapter = null;
            this.tableAdapterManager.OperacionTableAdapter = null;
            this.tableAdapterManager.PruebaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoC.BaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UrgenciasTableAdapter = this.urgenciasTableAdapter;
            // 
            // urgenciasBindingNavigator
            // 
            this.urgenciasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.urgenciasBindingNavigator.BindingSource = this.urgenciasBindingSource;
            this.urgenciasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.urgenciasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.urgenciasBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.urgenciasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.urgenciasBindingNavigatorSaveItem});
            this.urgenciasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.urgenciasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.urgenciasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.urgenciasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.urgenciasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.urgenciasBindingNavigator.Name = "urgenciasBindingNavigator";
            this.urgenciasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.urgenciasBindingNavigator.Size = new System.Drawing.Size(1089, 27);
            this.urgenciasBindingNavigator.TabIndex = 0;
            this.urgenciasBindingNavigator.Text = "bindingNavigator1";
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
            // urgenciasBindingNavigatorSaveItem
            // 
            this.urgenciasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.urgenciasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("urgenciasBindingNavigatorSaveItem.Image")));
            this.urgenciasBindingNavigatorSaveItem.Name = "urgenciasBindingNavigatorSaveItem";
            this.urgenciasBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.urgenciasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.urgenciasBindingNavigatorSaveItem.Click += new System.EventHandler(this.urgenciasBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urgenciasBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(299, 214);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // pacienteTextBox
            // 
            this.pacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urgenciasBindingSource, "paciente", true));
            this.pacienteTextBox.Location = new System.Drawing.Point(299, 242);
            this.pacienteTextBox.Name = "pacienteTextBox";
            this.pacienteTextBox.Size = new System.Drawing.Size(200, 22);
            this.pacienteTextBox.TabIndex = 4;
            // 
            // fechaYHoraDateTimePicker
            // 
            this.fechaYHoraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.urgenciasBindingSource, "fechaYHora", true));
            this.fechaYHoraDateTimePicker.Location = new System.Drawing.Point(299, 270);
            this.fechaYHoraDateTimePicker.Name = "fechaYHoraDateTimePicker";
            this.fechaYHoraDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fechaYHoraDateTimePicker.TabIndex = 6;
            // 
            // facultativoInicialTextBox
            // 
            this.facultativoInicialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urgenciasBindingSource, "facultativoInicial", true));
            this.facultativoInicialTextBox.Location = new System.Drawing.Point(299, 298);
            this.facultativoInicialTextBox.Name = "facultativoInicialTextBox";
            this.facultativoInicialTextBox.Size = new System.Drawing.Size(200, 22);
            this.facultativoInicialTextBox.TabIndex = 8;
            // 
            // juricioInicialTextBox
            // 
            this.juricioInicialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urgenciasBindingSource, "juricioInicial", true));
            this.juricioInicialTextBox.Location = new System.Drawing.Point(299, 326);
            this.juricioInicialTextBox.Name = "juricioInicialTextBox";
            this.juricioInicialTextBox.Size = new System.Drawing.Size(200, 22);
            this.juricioInicialTextBox.TabIndex = 10;
            // 
            // listaPruebasTextBox
            // 
            this.listaPruebasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urgenciasBindingSource, "listaPruebas", true));
            this.listaPruebasTextBox.Location = new System.Drawing.Point(299, 354);
            this.listaPruebasTextBox.Name = "listaPruebasTextBox";
            this.listaPruebasTextBox.Size = new System.Drawing.Size(200, 22);
            this.listaPruebasTextBox.TabIndex = 12;
            // 
            // remisionSalaTextBox
            // 
            this.remisionSalaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urgenciasBindingSource, "remisionSala", true));
            this.remisionSalaTextBox.Location = new System.Drawing.Point(299, 382);
            this.remisionSalaTextBox.Name = "remisionSalaTextBox";
            this.remisionSalaTextBox.Size = new System.Drawing.Size(200, 22);
            this.remisionSalaTextBox.TabIndex = 14;
            // 
            // remisionCirugiaTextBox
            // 
            this.remisionCirugiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urgenciasBindingSource, "remisionCirugia", true));
            this.remisionCirugiaTextBox.Location = new System.Drawing.Point(299, 410);
            this.remisionCirugiaTextBox.Name = "remisionCirugiaTextBox";
            this.remisionCirugiaTextBox.Size = new System.Drawing.Size(200, 22);
            this.remisionCirugiaTextBox.TabIndex = 16;
            // 
            // urgenciasDataGridView
            // 
            this.urgenciasDataGridView.AutoGenerateColumns = false;
            this.urgenciasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urgenciasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.urgenciasDataGridView.DataSource = this.urgenciasBindingSource;
            this.urgenciasDataGridView.Location = new System.Drawing.Point(84, 466);
            this.urgenciasDataGridView.Name = "urgenciasDataGridView";
            this.urgenciasDataGridView.RowTemplate.Height = 24;
            this.urgenciasDataGridView.Size = new System.Drawing.Size(837, 220);
            this.urgenciasDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "paciente";
            this.dataGridViewTextBoxColumn2.HeaderText = "paciente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fechaYHora";
            this.dataGridViewTextBoxColumn3.HeaderText = "fechaYHora";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "facultativoInicial";
            this.dataGridViewTextBoxColumn4.HeaderText = "facultativoInicial";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "juricioInicial";
            this.dataGridViewTextBoxColumn5.HeaderText = "juricioInicial";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "listaPruebas";
            this.dataGridViewTextBoxColumn6.HeaderText = "listaPruebas";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "remisionSala";
            this.dataGridViewTextBoxColumn7.HeaderText = "remisionSala";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "remisionCirugia";
            this.dataGridViewTextBoxColumn8.HeaderText = "remisionCirugia";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(800, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "MenuPrincipal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Urgenciascs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 768);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.urgenciasDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(pacienteLabel);
            this.Controls.Add(this.pacienteTextBox);
            this.Controls.Add(fechaYHoraLabel);
            this.Controls.Add(this.fechaYHoraDateTimePicker);
            this.Controls.Add(facultativoInicialLabel);
            this.Controls.Add(this.facultativoInicialTextBox);
            this.Controls.Add(juricioInicialLabel);
            this.Controls.Add(this.juricioInicialTextBox);
            this.Controls.Add(listaPruebasLabel);
            this.Controls.Add(this.listaPruebasTextBox);
            this.Controls.Add(remisionSalaLabel);
            this.Controls.Add(this.remisionSalaTextBox);
            this.Controls.Add(remisionCirugiaLabel);
            this.Controls.Add(this.remisionCirugiaTextBox);
            this.Controls.Add(this.urgenciasBindingNavigator);
            this.Name = "Urgenciascs";
            this.Text = "Urgenciascs";
            this.Load += new System.EventHandler(this.Urgenciascs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urgenciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urgenciasBindingNavigator)).EndInit();
            this.urgenciasBindingNavigator.ResumeLayout(false);
            this.urgenciasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urgenciasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseDataSet baseDataSet;
        private System.Windows.Forms.BindingSource urgenciasBindingSource;
        private BaseDataSetTableAdapters.UrgenciasTableAdapter urgenciasTableAdapter;
        private BaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator urgenciasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton urgenciasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox pacienteTextBox;
        private System.Windows.Forms.DateTimePicker fechaYHoraDateTimePicker;
        private System.Windows.Forms.TextBox facultativoInicialTextBox;
        private System.Windows.Forms.TextBox juricioInicialTextBox;
        private System.Windows.Forms.TextBox listaPruebasTextBox;
        private System.Windows.Forms.TextBox remisionSalaTextBox;
        private System.Windows.Forms.TextBox remisionCirugiaTextBox;
        private System.Windows.Forms.DataGridView urgenciasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button1;
    }
}