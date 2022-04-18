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
    public partial class InsertTreatment : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=REVOLT\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private int id;
        private string passport;
        public InsertTreatment(SqlConnection sc, int id,string passport)
        {
            InitializeComponent();
            cmd.Connection = sc;
            this.id = id;
            this.passport = passport;
        }

        private void treatmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.treatmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void InsertTreatment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Treatment' table. You can move, or remove it, as needed.
            //this.treatmentTableAdapter.Fill(this.dataSet1.Treatment);
            sc.Open();
            SqlCommand getTreatmentInfo = new SqlCommand("SELECT [Name],[idPatient] FROM [Patient] WHERE [idPatient] = @Id", sc);
            SqlCommand getStaffInfo = new SqlCommand("SELECT [idStaff] FROM Staff WHERE [Passport] = @Passport", sc);

            getTreatmentInfo.Parameters.AddWithValue("Id", id);
            getStaffInfo.Parameters.AddWithValue("Passport", passport);
            SqlDataReader sqlReader = null;
            try
            {
                sqlReader = getTreatmentInfo.ExecuteReader();
                while (sqlReader.Read())
                {
                    idPatientTextBox.Text = Convert.ToString(sqlReader["idPatient"]);
                    nameTextBox.Text = Convert.ToString(sqlReader["Name"]);
                }
                sqlReader.Close();
                sqlReader = null;
                sqlReader = getStaffInfo.ExecuteReader();
                while (sqlReader.Read())
                {
                    idStaffTextBox.Text = Convert.ToString(sqlReader["idStaff"]);
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
            if (idPatientTextBox.Text != "" && idStaffTextBox.Text != "" && nameTextBox.Text != "" && complaintsTextBox.Text != "" && diagnosisTextBox.Text != "" && dateOfAppointDateTimePicker.Text != "")
            {
                sc.Open();
                SqlCommand insertTreatment = new SqlCommand("INSERT INTO [Treatment] (Name,Complaints,Diagnosis,idPatient,idStaff,isFinished,DateOfAppoint) VALUES (@Name,@Complaints,@Diagnosis,@idPatient,@idStaff,@isFinished,@DateOfAppoint)", sc);
                //SqlCommand DelAuth = new SqlCommand("DELETE FROM [Autentification] WHERE Autentification_id = @idAutentification", sc)
                try
                {
                    insertTreatment.Parameters.AddWithValue("idPatient", Convert.ToInt32(idPatientTextBox.Text));
                    insertTreatment.Parameters.AddWithValue("idStaff", Convert.ToInt32(idStaffTextBox.Text));
                    insertTreatment.Parameters.AddWithValue("Name", nameTextBox.Text);
                    insertTreatment.Parameters.AddWithValue("isFinished", "Нет");
                    insertTreatment.Parameters.AddWithValue("Complaints", complaintsTextBox.Text);
                    insertTreatment.Parameters.AddWithValue("Diagnosis", diagnosisTextBox.Text);
                    insertTreatment.Parameters.AddWithValue("DateOfAppoint", Convert.ToDateTime(dateOfAppointDateTimePicker.Text));

                    //insertAuth.Parameters.AddWithValue("Autentification_id", Convert.ToInt32(idAutentificationTextBox.Text));
                    //insertAuth.Parameters.AddWithValue("login", loginTextBox.Text);
                    //insertAuth.Parameters.AddWithValue("password", passwordTextBox.Text);

                    insertTreatment.ExecuteNonQuery();
                    //insertPatient.ExecuteNonQuery();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //DelAuth.ExecuteNonQuery();
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

        private void dateOfAppointLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
