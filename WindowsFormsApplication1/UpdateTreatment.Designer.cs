namespace WindowsFormsApplication1
{
    partial class UpdateTreatment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTreatment));
            System.Windows.Forms.Label complaintsLabel;
            System.Windows.Forms.Label diagnosisLabel;
            this.dataSet1 = new WindowsFormsApplication1.DataSet1();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.StaffTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.DataSet1TableAdapters.TableAdapterManager();
            this.staffBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.staffBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.treatmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treatmentTableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.TreatmentTableAdapter();
            this.complaintsTextBox = new System.Windows.Forms.TextBox();
            this.diagnosisTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            complaintsLabel = new System.Windows.Forms.Label();
            diagnosisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingNavigator)).BeginInit();
            this.staffBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.dataSet1;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministrationTableAdapter = null;
            this.tableAdapterManager.AutentificationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.ReceptionTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.Treatment_ArchiveTableAdapter = null;
            this.tableAdapterManager.TreatmentTableAdapter = this.treatmentTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // staffBindingNavigator
            // 
            this.staffBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.staffBindingNavigator.BindingSource = this.staffBindingSource;
            this.staffBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.staffBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.staffBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.staffBindingNavigatorSaveItem});
            this.staffBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.staffBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.staffBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.staffBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.staffBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.staffBindingNavigator.Name = "staffBindingNavigator";
            this.staffBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.staffBindingNavigator.Size = new System.Drawing.Size(573, 25);
            this.staffBindingNavigator.TabIndex = 0;
            this.staffBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // staffBindingNavigatorSaveItem
            // 
            this.staffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.staffBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("staffBindingNavigatorSaveItem.Image")));
            this.staffBindingNavigatorSaveItem.Name = "staffBindingNavigatorSaveItem";
            this.staffBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.staffBindingNavigatorSaveItem.Text = "Save Data";
            this.staffBindingNavigatorSaveItem.Click += new System.EventHandler(this.staffBindingNavigatorSaveItem_Click);
            // 
            // treatmentBindingSource
            // 
            this.treatmentBindingSource.DataMember = "Treatment";
            this.treatmentBindingSource.DataSource = this.dataSet1;
            // 
            // treatmentTableAdapter
            // 
            this.treatmentTableAdapter.ClearBeforeFill = true;
            // 
            // complaintsLabel
            // 
            complaintsLabel.AutoSize = true;
            complaintsLabel.Location = new System.Drawing.Point(119, 131);
            complaintsLabel.Name = "complaintsLabel";
            complaintsLabel.Size = new System.Drawing.Size(61, 13);
            complaintsLabel.TabIndex = 5;
            complaintsLabel.Text = "Complaints:";
            // 
            // complaintsTextBox
            // 
            this.complaintsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treatmentBindingSource, "Complaints", true));
            this.complaintsTextBox.Location = new System.Drawing.Point(211, 128);
            this.complaintsTextBox.Name = "complaintsTextBox";
            this.complaintsTextBox.Size = new System.Drawing.Size(200, 20);
            this.complaintsTextBox.TabIndex = 6;
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Location = new System.Drawing.Point(119, 157);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new System.Drawing.Size(56, 13);
            diagnosisLabel.TabIndex = 7;
            diagnosisLabel.Text = "Diagnosis:";
            // 
            // diagnosisTextBox
            // 
            this.diagnosisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treatmentBindingSource, "Diagnosis", true));
            this.diagnosisTextBox.Location = new System.Drawing.Point(211, 154);
            this.diagnosisTextBox.Name = "diagnosisTextBox";
            this.diagnosisTextBox.Size = new System.Drawing.Size(200, 20);
            this.diagnosisTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 58);
            this.button1.TabIndex = 9;
            this.button1.Text = "Принять изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateTreatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(complaintsLabel);
            this.Controls.Add(this.complaintsTextBox);
            this.Controls.Add(diagnosisLabel);
            this.Controls.Add(this.diagnosisTextBox);
            this.Controls.Add(this.staffBindingNavigator);
            this.Name = "UpdateTreatment";
            this.Text = "UpdateTreatment";
            this.Load += new System.EventHandler(this.UpdateTreatment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingNavigator)).EndInit();
            this.staffBindingNavigator.ResumeLayout(false);
            this.staffBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private DataSet1TableAdapters.StaffTableAdapter staffTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator staffBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton staffBindingNavigatorSaveItem;
        private DataSet1TableAdapters.TreatmentTableAdapter treatmentTableAdapter;
        private System.Windows.Forms.BindingSource treatmentBindingSource;
        private System.Windows.Forms.TextBox complaintsTextBox;
        private System.Windows.Forms.TextBox diagnosisTextBox;
        private System.Windows.Forms.Button button1;
    }
}