namespace WindowsFormsApplication1
{
    partial class ReceptionInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionInsert));
            System.Windows.Forms.Label idPatientLabel;
            System.Windows.Forms.Label idStaffLabel;
            System.Windows.Forms.Label name_of_patientLabel;
            System.Windows.Forms.Label dateLabel;
            this.dataSet1 = new WindowsFormsApplication1.DataSet1();
            this.receptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receptionTableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.ReceptionTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.DataSet1TableAdapters.TableAdapterManager();
            this.receptionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.receptionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idPatientTextBox = new System.Windows.Forms.TextBox();
            this.idStaffTextBox = new System.Windows.Forms.TextBox();
            this.name_of_patientTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            idPatientLabel = new System.Windows.Forms.Label();
            idStaffLabel = new System.Windows.Forms.Label();
            name_of_patientLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionBindingNavigator)).BeginInit();
            this.receptionBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receptionBindingSource
            // 
            this.receptionBindingSource.DataMember = "Reception";
            this.receptionBindingSource.DataSource = this.dataSet1;
            // 
            // receptionTableAdapter
            // 
            this.receptionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministrationTableAdapter = null;
            this.tableAdapterManager.AutentificationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.ReceptionTableAdapter = this.receptionTableAdapter;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.Treatment_ArchiveTableAdapter = null;
            this.tableAdapterManager.TreatmentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // receptionBindingNavigator
            // 
            this.receptionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.receptionBindingNavigator.BindingSource = this.receptionBindingSource;
            this.receptionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.receptionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.receptionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.receptionBindingNavigatorSaveItem});
            this.receptionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.receptionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.receptionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.receptionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.receptionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.receptionBindingNavigator.Name = "receptionBindingNavigator";
            this.receptionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.receptionBindingNavigator.Size = new System.Drawing.Size(524, 25);
            this.receptionBindingNavigator.TabIndex = 0;
            this.receptionBindingNavigator.Text = "bindingNavigator1";
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
            // receptionBindingNavigatorSaveItem
            // 
            this.receptionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.receptionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("receptionBindingNavigatorSaveItem.Image")));
            this.receptionBindingNavigatorSaveItem.Name = "receptionBindingNavigatorSaveItem";
            this.receptionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.receptionBindingNavigatorSaveItem.Text = "Save Data";
            this.receptionBindingNavigatorSaveItem.Click += new System.EventHandler(this.receptionBindingNavigatorSaveItem_Click);
            // 
            // idPatientLabel
            // 
            idPatientLabel.AutoSize = true;
            idPatientLabel.Location = new System.Drawing.Point(109, 130);
            idPatientLabel.Name = "idPatientLabel";
            idPatientLabel.Size = new System.Drawing.Size(54, 13);
            idPatientLabel.TabIndex = 3;
            idPatientLabel.Text = "id Patient:";
            // 
            // idPatientTextBox
            // 
            this.idPatientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receptionBindingSource, "idPatient", true));
            this.idPatientTextBox.Location = new System.Drawing.Point(200, 127);
            this.idPatientTextBox.Name = "idPatientTextBox";
            this.idPatientTextBox.Size = new System.Drawing.Size(200, 20);
            this.idPatientTextBox.TabIndex = 4;
            // 
            // idStaffLabel
            // 
            idStaffLabel.AutoSize = true;
            idStaffLabel.Location = new System.Drawing.Point(109, 156);
            idStaffLabel.Name = "idStaffLabel";
            idStaffLabel.Size = new System.Drawing.Size(43, 13);
            idStaffLabel.TabIndex = 5;
            idStaffLabel.Text = "id Staff:";
            // 
            // idStaffTextBox
            // 
            this.idStaffTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receptionBindingSource, "idStaff", true));
            this.idStaffTextBox.Location = new System.Drawing.Point(200, 153);
            this.idStaffTextBox.Name = "idStaffTextBox";
            this.idStaffTextBox.Size = new System.Drawing.Size(200, 20);
            this.idStaffTextBox.TabIndex = 6;
            // 
            // name_of_patientLabel
            // 
            name_of_patientLabel.AutoSize = true;
            name_of_patientLabel.Location = new System.Drawing.Point(109, 182);
            name_of_patientLabel.Name = "name_of_patientLabel";
            name_of_patientLabel.Size = new System.Drawing.Size(85, 13);
            name_of_patientLabel.TabIndex = 7;
            name_of_patientLabel.Text = "Name of patient:";
            // 
            // name_of_patientTextBox
            // 
            this.name_of_patientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receptionBindingSource, "Name_of_patient", true));
            this.name_of_patientTextBox.Location = new System.Drawing.Point(200, 179);
            this.name_of_patientTextBox.Name = "name_of_patientTextBox";
            this.name_of_patientTextBox.Size = new System.Drawing.Size(200, 20);
            this.name_of_patientTextBox.TabIndex = 8;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(109, 221);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 11;
            dateLabel.Text = "Date:";
            dateLabel.Click += new System.EventHandler(this.dateLabel_Click);
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.receptionBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(200, 215);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить прием";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 42);
            this.button2.TabIndex = 14;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReceptionInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 468);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(idPatientLabel);
            this.Controls.Add(this.idPatientTextBox);
            this.Controls.Add(idStaffLabel);
            this.Controls.Add(this.idStaffTextBox);
            this.Controls.Add(name_of_patientLabel);
            this.Controls.Add(this.name_of_patientTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.receptionBindingNavigator);
            this.Name = "ReceptionInsert";
            this.Text = "ReceptionInsert";
            this.Load += new System.EventHandler(this.ReceptionInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionBindingNavigator)).EndInit();
            this.receptionBindingNavigator.ResumeLayout(false);
            this.receptionBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource receptionBindingSource;
        private DataSet1TableAdapters.ReceptionTableAdapter receptionTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator receptionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton receptionBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idPatientTextBox;
        private System.Windows.Forms.TextBox idStaffTextBox;
        private System.Windows.Forms.TextBox name_of_patientTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}