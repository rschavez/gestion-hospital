namespace ProyectoC
{
    partial class Incidencias
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label caracteristicasLabel;
            System.Windows.Forms.Label fechaYHoraLabel;
            System.Windows.Forms.Label valoracionLabel;
            System.Windows.Forms.Label listaMaterialesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incidencias));
            this.baseDataSet = new ProyectoC.BaseDataSet();
            this.incidenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidenciasTableAdapter = new ProyectoC.BaseDataSetTableAdapters.IncidenciasTableAdapter();
            this.tableAdapterManager = new ProyectoC.BaseDataSetTableAdapters.TableAdapterManager();
            this.incidenciasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.incidenciasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.caracteristicasTextBox = new System.Windows.Forms.TextBox();
            this.fechaYHoraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.valoracionTextBox = new System.Windows.Forms.TextBox();
            this.listaMaterialesTextBox = new System.Windows.Forms.TextBox();
            this.incidenciasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMenuPrincipal = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            caracteristicasLabel = new System.Windows.Forms.Label();
            fechaYHoraLabel = new System.Windows.Forms.Label();
            valoracionLabel = new System.Windows.Forms.Label();
            listaMaterialesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciasBindingNavigator)).BeginInit();
            this.incidenciasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(148, 160);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(148, 188);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 17);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "nombre:";
            // 
            // caracteristicasLabel
            // 
            caracteristicasLabel.AutoSize = true;
            caracteristicasLabel.Location = new System.Drawing.Point(148, 216);
            caracteristicasLabel.Name = "caracteristicasLabel";
            caracteristicasLabel.Size = new System.Drawing.Size(103, 17);
            caracteristicasLabel.TabIndex = 5;
            caracteristicasLabel.Text = "caracteristicas:";
            // 
            // fechaYHoraLabel
            // 
            fechaYHoraLabel.AutoSize = true;
            fechaYHoraLabel.Location = new System.Drawing.Point(148, 245);
            fechaYHoraLabel.Name = "fechaYHoraLabel";
            fechaYHoraLabel.Size = new System.Drawing.Size(91, 17);
            fechaYHoraLabel.TabIndex = 7;
            fechaYHoraLabel.Text = "fecha YHora:";
            // 
            // valoracionLabel
            // 
            valoracionLabel.AutoSize = true;
            valoracionLabel.Location = new System.Drawing.Point(148, 272);
            valoracionLabel.Name = "valoracionLabel";
            valoracionLabel.Size = new System.Drawing.Size(77, 17);
            valoracionLabel.TabIndex = 9;
            valoracionLabel.Text = "valoracion:";
            // 
            // listaMaterialesLabel
            // 
            listaMaterialesLabel.AutoSize = true;
            listaMaterialesLabel.Location = new System.Drawing.Point(148, 300);
            listaMaterialesLabel.Name = "listaMaterialesLabel";
            listaMaterialesLabel.Size = new System.Drawing.Size(106, 17);
            listaMaterialesLabel.TabIndex = 11;
            listaMaterialesLabel.Text = "lista Materiales:";
            // 
            // baseDataSet
            // 
            this.baseDataSet.DataSetName = "BaseDataSet";
            this.baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incidenciasBindingSource
            // 
            this.incidenciasBindingSource.DataMember = "Incidencias";
            this.incidenciasBindingSource.DataSource = this.baseDataSet;
            // 
            // incidenciasTableAdapter
            // 
            this.incidenciasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultasTableAdapter = null;
            this.tableAdapterManager.ControlUrgenciasTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.IncidenciasTableAdapter = this.incidenciasTableAdapter;
            this.tableAdapterManager.IngresoTableAdapter = null;
            this.tableAdapterManager.NominasTableAdapter = null;
            this.tableAdapterManager.OperacionTableAdapter = null;
            this.tableAdapterManager.PruebaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoC.BaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UrgenciasTableAdapter = null;
            // 
            // incidenciasBindingNavigator
            // 
            this.incidenciasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.incidenciasBindingNavigator.BindingSource = this.incidenciasBindingSource;
            this.incidenciasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.incidenciasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.incidenciasBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.incidenciasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.incidenciasBindingNavigatorSaveItem});
            this.incidenciasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.incidenciasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.incidenciasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.incidenciasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.incidenciasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.incidenciasBindingNavigator.Name = "incidenciasBindingNavigator";
            this.incidenciasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.incidenciasBindingNavigator.Size = new System.Drawing.Size(1171, 27);
            this.incidenciasBindingNavigator.TabIndex = 0;
            this.incidenciasBindingNavigator.Text = "bindingNavigator1";
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
            // incidenciasBindingNavigatorSaveItem
            // 
            this.incidenciasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.incidenciasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("incidenciasBindingNavigatorSaveItem.Image")));
            this.incidenciasBindingNavigatorSaveItem.Name = "incidenciasBindingNavigatorSaveItem";
            this.incidenciasBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.incidenciasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.incidenciasBindingNavigatorSaveItem.Click += new System.EventHandler(this.incidenciasBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciasBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(260, 157);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciasBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(260, 185);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 22);
            this.nombreTextBox.TabIndex = 4;
            // 
            // caracteristicasTextBox
            // 
            this.caracteristicasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciasBindingSource, "caracteristicas", true));
            this.caracteristicasTextBox.Location = new System.Drawing.Point(260, 213);
            this.caracteristicasTextBox.Name = "caracteristicasTextBox";
            this.caracteristicasTextBox.Size = new System.Drawing.Size(200, 22);
            this.caracteristicasTextBox.TabIndex = 6;
            // 
            // fechaYHoraDateTimePicker
            // 
            this.fechaYHoraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.incidenciasBindingSource, "fechaYHora", true));
            this.fechaYHoraDateTimePicker.Location = new System.Drawing.Point(260, 241);
            this.fechaYHoraDateTimePicker.Name = "fechaYHoraDateTimePicker";
            this.fechaYHoraDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fechaYHoraDateTimePicker.TabIndex = 8;
            // 
            // valoracionTextBox
            // 
            this.valoracionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciasBindingSource, "valoracion", true));
            this.valoracionTextBox.Location = new System.Drawing.Point(260, 269);
            this.valoracionTextBox.Name = "valoracionTextBox";
            this.valoracionTextBox.Size = new System.Drawing.Size(200, 22);
            this.valoracionTextBox.TabIndex = 10;
            // 
            // listaMaterialesTextBox
            // 
            this.listaMaterialesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciasBindingSource, "listaMateriales", true));
            this.listaMaterialesTextBox.Location = new System.Drawing.Point(260, 297);
            this.listaMaterialesTextBox.Name = "listaMaterialesTextBox";
            this.listaMaterialesTextBox.Size = new System.Drawing.Size(200, 22);
            this.listaMaterialesTextBox.TabIndex = 12;
            // 
            // incidenciasDataGridView
            // 
            this.incidenciasDataGridView.AutoGenerateColumns = false;
            this.incidenciasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidenciasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.incidenciasDataGridView.DataSource = this.incidenciasBindingSource;
            this.incidenciasDataGridView.Location = new System.Drawing.Point(141, 338);
            this.incidenciasDataGridView.Name = "incidenciasDataGridView";
            this.incidenciasDataGridView.RowTemplate.Height = 24;
            this.incidenciasDataGridView.Size = new System.Drawing.Size(645, 220);
            this.incidenciasDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "caracteristicas";
            this.dataGridViewTextBoxColumn3.HeaderText = "caracteristicas";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fechaYHora";
            this.dataGridViewTextBoxColumn4.HeaderText = "fechaYHora";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "valoracion";
            this.dataGridViewTextBoxColumn5.HeaderText = "valoracion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "listaMateriales";
            this.dataGridViewTextBoxColumn6.HeaderText = "listaMateriales";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // bMenuPrincipal
            // 
            this.bMenuPrincipal.Location = new System.Drawing.Point(881, 182);
            this.bMenuPrincipal.Name = "bMenuPrincipal";
            this.bMenuPrincipal.Size = new System.Drawing.Size(75, 23);
            this.bMenuPrincipal.TabIndex = 14;
            this.bMenuPrincipal.Text = "MenuPrincipal";
            this.bMenuPrincipal.UseVisualStyleBackColor = true;
            this.bMenuPrincipal.Click += new System.EventHandler(this.bMenuPrincipal_Click);
            // 
            // Incidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 688);
            this.Controls.Add(this.bMenuPrincipal);
            this.Controls.Add(this.incidenciasDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(caracteristicasLabel);
            this.Controls.Add(this.caracteristicasTextBox);
            this.Controls.Add(fechaYHoraLabel);
            this.Controls.Add(this.fechaYHoraDateTimePicker);
            this.Controls.Add(valoracionLabel);
            this.Controls.Add(this.valoracionTextBox);
            this.Controls.Add(listaMaterialesLabel);
            this.Controls.Add(this.listaMaterialesTextBox);
            this.Controls.Add(this.incidenciasBindingNavigator);
            this.Name = "Incidencias";
            this.Text = "Incidencias";
            this.Load += new System.EventHandler(this.Incidencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciasBindingNavigator)).EndInit();
            this.incidenciasBindingNavigator.ResumeLayout(false);
            this.incidenciasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseDataSet baseDataSet;
        private System.Windows.Forms.BindingSource incidenciasBindingSource;
        private BaseDataSetTableAdapters.IncidenciasTableAdapter incidenciasTableAdapter;
        private BaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator incidenciasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton incidenciasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox caracteristicasTextBox;
        private System.Windows.Forms.DateTimePicker fechaYHoraDateTimePicker;
        private System.Windows.Forms.TextBox valoracionTextBox;
        private System.Windows.Forms.TextBox listaMaterialesTextBox;
        private System.Windows.Forms.DataGridView incidenciasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button bMenuPrincipal;
    }
}