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
    public partial class PatientUpdate : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=REVOLT\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private int id;
        public PatientUpdate(SqlConnection sc, int id)
        {
            InitializeComponent();
            cmd.Connection = sc;
            this.id = id;
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void PatientUpdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Autentification' table. You can move, or remove it, as needed.
            //this.autentificationTableAdapter.Fill(this.dataSet1.Autentification);
            // TODO: This line of code loads data into the 'dataSet1.Patient' table. You can move, or remove it, as needed.
            //this.patientTableAdapter.Fill(this.dataSet1.Patient);
            sc.Open();
            SqlCommand getPatientInfo = new SqlCommand("SELECT [Name],[Phone],[Adress],[Passport],[idAutentification],[Date_of_Birth] FROM [Patient] WHERE [idPatient] = @Id",sc);
            SqlCommand getAuthInfo = new SqlCommand("SELECT [login] FROM Autentification JOIN Patient ON Autentification.Autentification_id = Patient.idAutentification WHERE [idPatient] = @Id",sc);


            getPatientInfo.Parameters.AddWithValue("Id", id);
            getAuthInfo.Parameters.AddWithValue("Id", id);
            SqlDataReader sqlReader = null;
            //SqlDataReader sqlReader2 = null;
            try
            {
                sqlReader = getPatientInfo.ExecuteReader();
                while (sqlReader.Read())
                {
                    nameTextBox.Text = Convert.ToString(sqlReader["Name"]);
                    phoneTextBox.Text = Convert.ToString(sqlReader["Phone"]);
                    adressTextBox.Text = Convert.ToString(sqlReader["Adress"]);
                    passportTextBox.Text = Convert.ToString(sqlReader["Passport"]);
                    //idAutentificationTextBox.Text = Convert.ToString(sqlReader["idAutentification"]);
                    date_of_BirthDateTimePicker.Text = Convert.ToString(sqlReader["Date_of_Birth"]);
                }
                sqlReader.Close();
                sqlReader = null;
                sqlReader = getAuthInfo.ExecuteReader();
                while (sqlReader.Read())
                {
                    loginTextBox.Text = Convert.ToString(sqlReader["login"]);
                    //passwordTextBox.Text = Convert.ToString(sqlReader["password"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                {
                    //sqlReader2.Close();
                    sqlReader.Close();
                    sc.Close();
                }
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            sc.Open();
            SqlCommand updatePatient = new SqlCommand("UPDATE [Patient] SET [Name] = @Name,[Phone] = @Phone,[Adress] = @Adress,[Passport] = @Passport,[Date_of_Birth] = @Date_of_Birth WHERE [idPatient] = @Id", sc);
            SqlCommand updateAuth = new SqlCommand("Update Autentification set login = @login from Patient as p1 where p1.idAutentification = Autentification.Autentification_id and p1.Passport = @passport", sc);
            SqlCommand updatePassword = new SqlCommand("UPDATE [Autentification] SET [password] = PWDENCRYPT(@password) from Patient as p1 where p1.idAutentification = Autentification.Autentification_id and p1.Passport = @passport", sc);
            try
            {
                updatePatient.Parameters.AddWithValue("Name", nameTextBox.Text);
                updatePatient.Parameters.AddWithValue("Phone", phoneTextBox.Text);
                updatePatient.Parameters.AddWithValue("Adress", adressTextBox.Text);
                updatePatient.Parameters.AddWithValue("Passport", passportTextBox.Text);
                //updatePatient.Parameters.AddWithValue("idAutentification", Convert.ToInt32(idAutentificationTextBox.Text));
                updatePatient.Parameters.AddWithValue("Date_of_Birth", Convert.ToDateTime(date_of_BirthDateTimePicker.Text));
                updatePatient.Parameters.AddWithValue("Id", id);
                //updateAuth.Parameters.AddWithValue("idAutentification", Convert.ToInt32(idAutentificationTextBox.Text));
                updateAuth.Parameters.AddWithValue("login", loginTextBox.Text);
                //updateAuth.Parameters.AddWithValue("password", passwordTextBox.Text);
                updateAuth.Parameters.AddWithValue("passport", passportTextBox.Text);

                    
                    updatePatient.ExecuteNonQuery();
                    updateAuth.ExecuteNonQuery();
                    if (passwordTextBox.Text != "")
                    {
                        updatePassword.Parameters.AddWithValue("password", passwordTextBox.Text);
                        updatePassword.Parameters.AddWithValue("passport", passportTextBox.Text);
                        updatePassword.ExecuteNonQuery();
                    }
                    
                    sc.Close();
                    Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sc.Close();
            }
        }
    }
}
