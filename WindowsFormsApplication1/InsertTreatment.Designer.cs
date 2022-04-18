namespace WindowsFormsApplication1
{
    partial class InsertTreatment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertTreatment));
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label complaintsLabel;
            System.Windows.Forms.Label diagnosisLabel;
            System.Windows.Forms.Label idPatientLabel;
            System.Windows.Forms.Label idStaffLabel;
            System.Windows.Forms.Label dateOfAppointLabel;
            this.dataSet1 = new WindowsFormsApplication1.DataSet1();
            this.treatmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treatmentTableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.TreatmentTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.DataSet1TableAdapters.TableAdapterManager();
            this.treatmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.treatmentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.complaintsTextBox = new System.Windows.Forms.TextBox();
            this.diagnosisTextBox = new System.Windows.Forms.TextBox();
            this.idPatientTextBox = new System.Windows.Forms.TextBox();
            this.idStaffTextBox = new System.Windows.Forms.TextBox();
            this.dateOfAppointDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            complaintsLabel = new System.Windows.Forms.Label();
            diagnosisLabel = new System.Windows.Forms.Label();
            idPatientLabel = new System.Windows.Forms.Label();
            idStaffLabel = new System.Windows.Forms.Label();
            dateOfAppointLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingNavigator)).BeginInit();
            this.treatmentBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministrationTableAdapter = null;
            this.tableAdapterManager.AutentificationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.ReceptionTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.Treatment_ArchiveTableAdapter = null;
            this.tableAdapterManager.TreatmentTableAdapter = this.treatmentTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // treatmentBindingNavigator
            // 
            this.treatmentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.treatmentBindingNavigator.BindingSource = this.treatmentBindingSource;
            this.treatmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.treatmentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.treatmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.treatmentBindingNavigatorSaveItem});
            this.treatmentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.treatmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.treatmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.treatmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.treatmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.treatmentBindingNavigator.Name = "treatmentBindingNavigator";
            this.treatmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.treatmentBindingNavigator.Size = new System.Drawing.Size(387, 25);
            this.treatmentBindingNavigator.TabIndex = 0;
            this.treatmentBindingNavigator.Text = "bindingNavigator1";
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
            // treatmentBindingNavigatorSaveItem
            // 
            this.treatmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.treatmentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("treatmentBindingNavigatorSaveItem.Image")));
            this.treatmentBindingNavigatorSaveItem.Name = "treatmentBindingNavigatorSaveItem";
            this.treatmentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.treatmentBindingNavigatorSaveItem.Text = "Save Data";
            this.treatmentBindingNavigatorSaveItem.Click += new System.EventHandler(this.treatmentBindingNavigatorSaveItem_Click);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(30, 93);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treatmentBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(122, 90);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // complaintsLabel
            // 
            complaintsLabel.AutoSize = true;
            complaintsLabel.Location = new System.Drawing.Point(30, 119);
            complaintsLabel.Name = "complaintsLabel";
            complaintsLabel.Size = new System.Drawing.Size(61, 13);
            complaintsLabel.TabIndex = 5;
            complaintsLabel.Text = "Complaints:";
            // 
            // complaintsTextBox
            // 
            this.complaintsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treatmentBindingSource, "Complaints", true));
            this.complaintsTextBox.Location = new System.Drawing.Point(122, 116);
            this.complaintsTextBox.Name = "complaintsTextBox";
            this.complaintsTextBox.Size = new System.Drawing.Size(200, 20);
            this.complaintsTextBox.TabIndex = 6;
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Location = new System.Drawing.Point(30, 145);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new System.Drawing.Size(56, 13);
            diagnosisLabel.TabIndex = 7;
            diagnosisLabel.Text = "Diagnosis:";
            // 
            // diagnosisTextBox
            // 
            this.diagnosisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treatmentBindingSource, "Diagnosis", true));
            this.diagnosisTextBox.Location = new System.Drawing.Point(122, 142);
            this.diagnosisTextBox.Name = "diagnosisTextBox";
            this.diagnosisTextBox.Size = new System.Drawing.Size(200, 20);
            this.diagnosisTextBox.TabIndex = 8;
            // 
            // idPatientLabel
            // 
            idPatientLabel.AutoSize = true;
            idPatientLabel.Location = new System.Drawing.Point(30, 171);
            idPatientLabel.Name = "idPatientLabel";
            idPatientLabel.Size = new System.Drawing.Size(54, 13);
            idPatientLabel.TabIndex = 9;
            idPatientLabel.Text = "id Patient:";
            // 
            // idPatientTextBox
            // 
            this.idPatientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treatmentBindingSource, "idPatient", true));
            this.idPatientTextBox.Location = new System.Drawing.Point(122, 168);
            this.idPatientTextBox.Name = "idPatientTextBox";
            this.idPatientTextBox.Size = new System.Drawing.Size(200, 20);
            this.idPatientTextBox.TabIndex = 10;
            // 
            // idStaffLabel
            // 
            idStaffLabel.AutoSize = true;
            idStaffLabel.Location = new System.Drawing.Point(30, 197);
            idStaffLabel.Name = "idStaffLabel";
            idStaffLabel.Size = new System.Drawing.Size(43, 13);
            idStaffLabel.TabIndex = 11;
            idStaffLabel.Text = "id Staff:";
            // 
            // idStaffTextBox
            // 
            this.idStaffTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treatmentBindingSource, "idStaff", true));
            this.idStaffTextBox.Location = new System.Drawing.Point(122, 194);
            this.idStaffTextBox.Name = "idStaffTextBox";
            this.idStaffTextBox.Size = new System.Drawing.Size(200, 20);
            this.idStaffTextBox.TabIndex = 12;
            // 
            // dateOfAppointLabel
            // 
            dateOfAppointLabel.AutoSize = true;
            dateOfAppointLabel.Location = new System.Drawing.Point(30, 223);
            dateOfAppointLabel.Name = "dateOfAppointLabel";
            dateOfAppointLabel.Size = new System.Drawing.Size(86, 13);
            dateOfAppointLabel.TabIndex = 15;
            dateOfAppointLabel.Text = "Date Of Appoint:";
            dateOfAppointLabel.Click += new System.EventHandler(this.dateOfAppointLabel_Click);
            // 
            // dateOfAppointDateTimePicker
            // 
            this.dateOfAppointDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.treatmentBindingSource, "DateOfAppoint", true));
            this.dateOfAppointDateTimePicker.Location = new System.Drawing.Point(122, 223);
            this.dateOfAppointDateTimePicker.Name = "dateOfAppointDateTimePicker";
            this.dateOfAppointDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfAppointDateTimePicker.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InsertTreatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 462);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(complaintsLabel);
            this.Controls.Add(this.complaintsTextBox);
            this.Controls.Add(diagnosisLabel);
            this.Controls.Add(this.diagnosisTextBox);
            this.Controls.Add(idPatientLabel);
            this.Controls.Add(this.idPatientTextBox);
            this.Controls.Add(idStaffLabel);
            this.Controls.Add(this.idStaffTextBox);
            this.Controls.Add(dateOfAppointLabel);
            this.Controls.Add(this.dateOfAppointDateTimePicker);
            this.Controls.Add(this.treatmentBindingNavigator);
            this.Name = "InsertTreatment";
            this.Text = "InsertTreatment";
            this.Load += new System.EventHandler(this.InsertTreatment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingNavigator)).EndInit();
            this.treatmentBindingNavigator.ResumeLayout(false);
            this.treatmentBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource treatmentBindingSource;
        private DataSet1TableAdapters.TreatmentTableAdapter treatmentTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator treatmentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton treatmentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox complaintsTextBox;
        private System.Windows.Forms.TextBox diagnosisTextBox;
        private System.Windows.Forms.TextBox idPatientTextBox;
        private System.Windows.Forms.TextBox idStaffTextBox;
        private System.Windows.Forms.DateTimePicker dateOfAppointDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}