namespace WindowsFormsApplication1
{
    partial class PatientInsert
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label passportLabel;
            System.Windows.Forms.Label idAutentificationLabel;
            System.Windows.Forms.Label date_of_BirthLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientInsert));
            this.dataSet1 = new WindowsFormsApplication1.DataSet1();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.PatientTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.DataSet1TableAdapters.TableAdapterManager();
            this.autentificationTableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.AutentificationTableAdapter();
            this.patientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.patientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.idAutentificationTextBox = new System.Windows.Forms.TextBox();
            this.date_of_BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.autentificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            passportLabel = new System.Windows.Forms.Label();
            idAutentificationLabel = new System.Windows.Forms.Label();
            date_of_BirthLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingNavigator)).BeginInit();
            this.patientBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autentificationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(48, 97);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(48, 123);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 5;
            phoneLabel.Text = "Phone:";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new System.Drawing.Point(48, 149);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(42, 13);
            adressLabel.TabIndex = 7;
            adressLabel.Text = "Adress:";
            // 
            // passportLabel
            // 
            passportLabel.AutoSize = true;
            passportLabel.Location = new System.Drawing.Point(48, 175);
            passportLabel.Name = "passportLabel";
            passportLabel.Size = new System.Drawing.Size(51, 13);
            passportLabel.TabIndex = 9;
            passportLabel.Text = "Passport:";
            // 
            // idAutentificationLabel
            // 
            idAutentificationLabel.AutoSize = true;
            idAutentificationLabel.Location = new System.Drawing.Point(48, 201);
            idAutentificationLabel.Name = "idAutentificationLabel";
            idAutentificationLabel.Size = new System.Drawing.Size(88, 13);
            idAutentificationLabel.TabIndex = 11;
            idAutentificationLabel.Text = "id Autentification:";
            // 
            // date_of_BirthLabel
            // 
            date_of_BirthLabel.AutoSize = true;
            date_of_BirthLabel.Location = new System.Drawing.Point(48, 228);
            date_of_BirthLabel.Name = "date_of_BirthLabel";
            date_of_BirthLabel.Size = new System.Drawing.Size(69, 13);
            date_of_BirthLabel.TabIndex = 13;
            date_of_BirthLabel.Text = "Date of Birth:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(48, 272);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(32, 13);
            loginLabel.TabIndex = 17;
            loginLabel.Text = "login:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(48, 299);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(55, 13);
            passwordLabel.TabIndex = 19;
            passwordLabel.Text = "password:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.dataSet1;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministrationTableAdapter = null;
            this.tableAdapterManager.AutentificationTableAdapter = this.autentificationTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PatientTableAdapter = this.patientTableAdapter;
            this.tableAdapterManager.ReceptionTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.Treatment_ArchiveTableAdapter = null;
            this.tableAdapterManager.TreatmentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // autentificationTableAdapter
            // 
            this.autentificationTableAdapter.ClearBeforeFill = true;
            // 
            // patientBindingNavigator
            // 
            this.patientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientBindingNavigator.BindingSource = this.patientBindingSource;
            this.patientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.patientBindingNavigatorSaveItem});
            this.patientBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientBindingNavigator.Name = "patientBindingNavigator";
            this.patientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientBindingNavigator.Size = new System.Drawing.Size(534, 25);
            this.patientBindingNavigator.TabIndex = 0;
            this.patientBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // patientBindingNavigatorSaveItem
            // 
            this.patientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientBindingNavigatorSaveItem.Image")));
            this.patientBindingNavigatorSaveItem.Name = "patientBindingNavigatorSaveItem";
            this.patientBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.patientBindingNavigatorSaveItem.Text = "Save Data";
            this.patientBindingNavigatorSaveItem.Click += new System.EventHandler(this.patientBindingNavigatorSaveItem_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(142, 94);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(142, 120);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneTextBox.TabIndex = 6;
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Adress", true));
            this.adressTextBox.Location = new System.Drawing.Point(142, 146);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(200, 20);
            this.adressTextBox.TabIndex = 8;
            // 
            // passportTextBox
            // 
            this.passportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Passport", true));
            this.passportTextBox.Location = new System.Drawing.Point(142, 172);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(200, 20);
            this.passportTextBox.TabIndex = 10;
            // 
            // idAutentificationTextBox
            // 
            this.idAutentificationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "idAutentification", true));
            this.idAutentificationTextBox.Location = new System.Drawing.Point(142, 198);
            this.idAutentificationTextBox.Name = "idAutentificationTextBox";
            this.idAutentificationTextBox.Size = new System.Drawing.Size(200, 20);
            this.idAutentificationTextBox.TabIndex = 12;
            this.idAutentificationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idAutentification_KeyPress);
            // 
            // date_of_BirthDateTimePicker
            // 
            this.date_of_BirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "Date_of_Birth", true));
            this.date_of_BirthDateTimePicker.Location = new System.Drawing.Point(142, 224);
            this.date_of_BirthDateTimePicker.Name = "date_of_BirthDateTimePicker";
            this.date_of_BirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_of_BirthDateTimePicker.TabIndex = 14;
            // 
            // autentificationBindingSource
            // 
            this.autentificationBindingSource.DataMember = "Autentification";
            this.autentificationBindingSource.DataSource = this.dataSet1;
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autentificationBindingSource, "login", true));
            this.loginTextBox.Location = new System.Drawing.Point(142, 265);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(200, 20);
            this.loginTextBox.TabIndex = 18;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autentificationBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(142, 295);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
            this.passwordTextBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PatientInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 446);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(adressLabel);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(passportLabel);
            this.Controls.Add(this.passportTextBox);
            this.Controls.Add(idAutentificationLabel);
            this.Controls.Add(this.idAutentificationTextBox);
            this.Controls.Add(date_of_BirthLabel);
            this.Controls.Add(this.date_of_BirthDateTimePicker);
            this.Controls.Add(this.patientBindingNavigator);
            this.Name = "PatientInsert";
            this.Text = "PatientInsert";
            this.Load += new System.EventHandler(this.PatientInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingNavigator)).EndInit();
            this.patientBindingNavigator.ResumeLayout(false);
            this.patientBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autentificationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private DataSet1TableAdapters.PatientTableAdapter patientTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patientBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton patientBindingNavigatorSaveItem;
        private DataSet1TableAdapters.AutentificationTableAdapter autentificationTableAdapter;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.TextBox idAutentificationTextBox;
        private System.Windows.Forms.DateTimePicker date_of_BirthDateTimePicker;
        private System.Windows.Forms.BindingSource autentificationBindingSource;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}