namespace ProyectoC
{
    partial class Operacion
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
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label numeroQuirofanoLabel;
            System.Windows.Forms.Label listaFacultativosLabel;
            System.Windows.Forms.Label resultadoLabel;
            System.Windows.Forms.Label listaIncidenciasLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operacion));
            this.baseDataSet = new ProyectoC.BaseDataSet();
            this.operacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operacionTableAdapter = new ProyectoC.BaseDataSetTableAdapters.OperacionTableAdapter();
            this.tableAdapterManager = new ProyectoC.BaseDataSetTableAdapters.TableAdapterManager();
            this.operacionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.operacionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.fechaYHoraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.numeroQuirofanoTextBox = new System.Windows.Forms.TextBox();
            this.listaFacultativosTextBox = new System.Windows.Forms.TextBox();
            this.resultadoTextBox = new System.Windows.Forms.TextBox();
            this.listaIncidenciasTextBox = new System.Windows.Forms.TextBox();
            this.operacionDataGridView = new System.Windows.Forms.DataGridView();
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
            fechaYHoraLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            numeroQuirofanoLabel = new System.Windows.Forms.Label();
            listaFacultativosLabel = new System.Windows.Forms.Label();
            resultadoLabel = new System.Windows.Forms.Label();
            listaIncidenciasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacionBindingNavigator)).BeginInit();
            this.operacionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operacionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(119, 74);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // fechaYHoraLabel
            // 
            fechaYHoraLabel.AutoSize = true;
            fechaYHoraLabel.Location = new System.Drawing.Point(119, 103);
            fechaYHoraLabel.Name = "fechaYHoraLabel";
            fechaYHoraLabel.Size = new System.Drawing.Size(91, 17);
            fechaYHoraLabel.TabIndex = 3;
            fechaYHoraLabel.Text = "fecha YHora:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(119, 130);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(35, 17);
            tipoLabel.TabIndex = 5;
            tipoLabel.Text = "tipo:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(119, 158);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 17);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "nombre:";
            // 
            // numeroQuirofanoLabel
            // 
            numeroQuirofanoLabel.AutoSize = true;
            numeroQuirofanoLabel.Location = new System.Drawing.Point(119, 186);
            numeroQuirofanoLabel.Name = "numeroQuirofanoLabel";
            numeroQuirofanoLabel.Size = new System.Drawing.Size(127, 17);
            numeroQuirofanoLabel.TabIndex = 9;
            numeroQuirofanoLabel.Text = "numero Quirofano:";
            // 
            // listaFacultativosLabel
            // 
            listaFacultativosLabel.AutoSize = true;
            listaFacultativosLabel.Location = new System.Drawing.Point(119, 214);
            listaFacultativosLabel.Name = "listaFacultativosLabel";
            listaFacultativosLabel.Size = new System.Drawing.Size(116, 17);
            listaFacultativosLabel.TabIndex = 11;
            listaFacultativosLabel.Text = "lista Facultativos:";
            // 
            // resultadoLabel
            // 
            resultadoLabel.AutoSize = true;
            resultadoLabel.Location = new System.Drawing.Point(119, 242);
            resultadoLabel.Name = "resultadoLabel";
            resultadoLabel.Size = new System.Drawing.Size(71, 17);
            resultadoLabel.TabIndex = 13;
            resultadoLabel.Text = "resultado:";
            // 
            // listaIncidenciasLabel
            // 
            listaIncidenciasLabel.AutoSize = true;
            listaIncidenciasLabel.Location = new System.Drawing.Point(119, 270);
            listaIncidenciasLabel.Name = "listaIncidenciasLabel";
            listaIncidenciasLabel.Size = new System.Drawing.Size(111, 17);
            listaIncidenciasLabel.TabIndex = 15;
            listaIncidenciasLabel.Text = "lista Incidencias:";
            // 
            // baseDataSet
            // 
            this.baseDataSet.DataSetName = "BaseDataSet";
            this.baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operacionBindingSource
            // 
            this.operacionBindingSource.DataMember = "Operacion";
            this.operacionBindingSource.DataSource = this.baseDataSet;
            // 
            // operacionTableAdapter
            // 
            this.operacionTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.OperacionTableAdapter = this.operacionTableAdapter;
            this.tableAdapterManager.PruebaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoC.BaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UrgenciasTableAdapter = null;
            // 
            // operacionBindingNavigator
            // 
            this.operacionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.operacionBindingNavigator.BindingSource = this.operacionBindingSource;
            this.operacionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.operacionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.operacionBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.operacionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.operacionBindingNavigatorSaveItem});
            this.operacionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.operacionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.operacionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.operacionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.operacionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.operacionBindingNavigator.Name = "operacionBindingNavigator";
            this.operacionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.operacionBindingNavigator.Size = new System.Drawing.Size(963, 27);
            this.operacionBindingNavigator.TabIndex = 0;
            this.operacionBindingNavigator.Text = "bindingNavigator1";
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
            // operacionBindingNavigatorSaveItem
            // 
            this.operacionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.operacionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("operacionBindingNavigatorSaveItem.Image")));
            this.operacionBindingNavigatorSaveItem.Name = "operacionBindingNavigatorSaveItem";
            this.operacionBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.operacionBindingNavigatorSaveItem.Text = "Guardar datos";
            this.operacionBindingNavigatorSaveItem.Click += new System.EventHandler(this.operacionBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operacionBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(252, 71);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // fechaYHoraDateTimePicker
            // 
            this.fechaYHoraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.operacionBindingSource, "fechaYHora", true));
            this.fechaYHoraDateTimePicker.Location = new System.Drawing.Point(252, 99);
            this.fechaYHoraDateTimePicker.Name = "fechaYHoraDateTimePicker";
            this.fechaYHoraDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fechaYHoraDateTimePicker.TabIndex = 4;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operacionBindingSource, "tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(252, 127);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(200, 22);
            this.tipoTextBox.TabIndex = 6;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operacionBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(252, 155);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 22);
            this.nombreTextBox.TabIndex = 8;
            // 
            // numeroQuirofanoTextBox
            // 
            this.numeroQuirofanoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operacionBindingSource, "numeroQuirofano", true));
            this.numeroQuirofanoTextBox.Location = new System.Drawing.Point(252, 183);
            this.numeroQuirofanoTextBox.Name = "numeroQuirofanoTextBox";
            this.numeroQuirofanoTextBox.Size = new System.Drawing.Size(200, 22);
            this.numeroQuirofanoTextBox.TabIndex = 10;
            // 
            // listaFacultativosTextBox
            // 
            this.listaFacultativosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operacionBindingSource, "listaFacultativos", true));
            this.listaFacultativosTextBox.Location = new System.Drawing.Point(252, 211);
            this.listaFacultativosTextBox.Name = "listaFacultativosTextBox";
            this.listaFacultativosTextBox.Size = new System.Drawing.Size(200, 22);
            this.listaFacultativosTextBox.TabIndex = 12;
            // 
            // resultadoTextBox
            // 
            this.resultadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operacionBindingSource, "resultado", true));
            this.resultadoTextBox.Location = new System.Drawing.Point(252, 239);
            this.resultadoTextBox.Name = "resultadoTextBox";
            this.resultadoTextBox.Size = new System.Drawing.Size(200, 22);
            this.resultadoTextBox.TabIndex = 14;
            // 
            // listaIncidenciasTextBox
            // 
            this.listaIncidenciasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operacionBindingSource, "listaIncidencias", true));
            this.listaIncidenciasTextBox.Location = new System.Drawing.Point(252, 267);
            this.listaIncidenciasTextBox.Name = "listaIncidenciasTextBox";
            this.listaIncidenciasTextBox.Size = new System.Drawing.Size(200, 22);
            this.listaIncidenciasTextBox.TabIndex = 16;
            // 
            // operacionDataGridView
            // 
            this.operacionDataGridView.AutoGenerateColumns = false;
            this.operacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operacionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.operacionDataGridView.DataSource = this.operacionBindingSource;
            this.operacionDataGridView.Location = new System.Drawing.Point(122, 370);
            this.operacionDataGridView.Name = "operacionDataGridView";
            this.operacionDataGridView.RowTemplate.Height = 24;
            this.operacionDataGridView.Size = new System.Drawing.Size(781, 220);
            this.operacionDataGridView.TabIndex = 17;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tipo";
            this.dataGridViewTextBoxColumn3.HeaderText = "tipo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn4.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "numeroQuirofano";
            this.dataGridViewTextBoxColumn5.HeaderText = "numeroQuirofano";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "listaFacultativos";
            this.dataGridViewTextBoxColumn6.HeaderText = "listaFacultativos";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "resultado";
            this.dataGridViewTextBoxColumn7.HeaderText = "resultado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "listaIncidencias";
            this.dataGridViewTextBoxColumn8.HeaderText = "listaIncidencias";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(732, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "MenuPrincipal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Operacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 602);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.operacionDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(fechaYHoraLabel);
            this.Controls.Add(this.fechaYHoraDateTimePicker);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(numeroQuirofanoLabel);
            this.Controls.Add(this.numeroQuirofanoTextBox);
            this.Controls.Add(listaFacultativosLabel);
            this.Controls.Add(this.listaFacultativosTextBox);
            this.Controls.Add(resultadoLabel);
            this.Controls.Add(this.resultadoTextBox);
            this.Controls.Add(listaIncidenciasLabel);
            this.Controls.Add(this.listaIncidenciasTextBox);
            this.Controls.Add(this.operacionBindingNavigator);
            this.Name = "Operacion";
            this.Text = "Operacion";
            this.Load += new System.EventHandler(this.Operacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacionBindingNavigator)).EndInit();
            this.operacionBindingNavigator.ResumeLayout(false);
            this.operacionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operacionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseDataSet baseDataSet;
        private System.Windows.Forms.BindingSource operacionBindingSource;
        private BaseDataSetTableAdapters.OperacionTableAdapter operacionTableAdapter;
        private BaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator operacionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton operacionBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker fechaYHoraDateTimePicker;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox numeroQuirofanoTextBox;
        private System.Windows.Forms.TextBox listaFacultativosTextBox;
        private System.Windows.Forms.TextBox resultadoTextBox;
        private System.Windows.Forms.TextBox listaIncidenciasTextBox;
        private System.Windows.Forms.DataGridView operacionDataGridView;
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