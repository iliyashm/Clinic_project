using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class PatientInsert : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=REVOLT\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public PatientInsert(SqlConnection sc)
        {
            InitializeComponent();
            cmd.Connection = sc;

        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void PatientInsert_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Autentification' table. You can move, or remove it, as needed.
            //this.autentificationTableAdapter.Fill(this.dataSet1.Autentification);
            // TODO: This line of code loads data into the 'dataSet1.Patient' table. You can move, or remove it, as needed.
            //this.patientTableAdapter.Fill(this.dataSet1.Patient);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && phoneTextBox.Text != "" && adressTextBox.Text != "" && passportTextBox.Text != "" && idAutentificationTextBox.Text != "" && loginTextBox.Text != "" && passwordTextBox.Text != "" && date_of_BirthDateTimePicker.Text != "")
            {
                sc.Open();
                SqlCommand insertPatient = new SqlCommand("INSERT INTO [Patient] (Name,Phone,Adress,Passport,idAutentification,Date_of_Birth) VALUES (@Name,@Phone,@Adress,@Passport,@idAutentification,@Date_of_Birth) ", sc);
                SqlCommand insertAuth = new SqlCommand("INSERT INTO [Autentification] (Autentification_id,login,password)VALUES(@Autentification_id,@login,PWDENCRYPT(@password))", sc);
                SqlCommand DelAuth = new SqlCommand("DELETE FROM [Autentification] WHERE Autentification_id = @idAutentification", sc);
                try
                {
                    DelAuth.Parameters.AddWithValue("idAutentification", Convert.ToInt32(idAutentificationTextBox.Text));
                    insertPatient.Parameters.AddWithValue("Name", nameTextBox.Text);
                    insertPatient.Parameters.AddWithValue("Phone", phoneTextBox.Text);
                    insertPatient.Parameters.AddWithValue("Adress", adressTextBox.Text);
                    insertPatient.Parameters.AddWithValue("Passport", passportTextBox.Text);
                    insertPatient.Parameters.AddWithValue("idAutentification", Convert.ToInt32(idAutentificationTextBox.Text));
                    insertPatient.Parameters.AddWithValue("Date_of_Birth", Convert.ToDateTime(date_of_BirthDateTimePicker.Text));

                    insertAuth.Parameters.AddWithValue("Autentification_id", Convert.ToInt32(idAutentificationTextBox.Text));
                    insertAuth.Parameters.AddWithValue("login", loginTextBox.Text);
                    insertAuth.Parameters.AddWithValue("password", passwordTextBox.Text);

                  

                    insertAuth.ExecuteNonQuery();
                    insertPatient.ExecuteNonQuery();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    DelAuth.ExecuteNonQuery();
                    sc.Close();
                }

            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void idAutentification_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
