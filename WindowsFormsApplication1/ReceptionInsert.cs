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
    public partial class ReceptionInsert : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=REVOLT\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private int id;
        public ReceptionInsert(SqlConnection sc,int id)
        {
            InitializeComponent();
            cmd.Connection = sc;
            this.id = id;
        }

        private void receptionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.receptionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void ReceptionInsert_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Reception' table. You can move, or remove it, as needed.
            //this.receptionTableAdapter.Fill(this.dataSet1.Reception);
            sc.Open();
            SqlCommand getPatientInfo = new SqlCommand("SELECT [Name],[idPatient] FROM [Patient] WHERE [idPatient] = @Id", sc);

            getPatientInfo.Parameters.AddWithValue("Id", id);
            SqlDataReader sqlReader = null;
            try
            {
                sqlReader = getPatientInfo.ExecuteReader();
                while (sqlReader.Read())
                {
                    idPatientTextBox.Text = Convert.ToString(sqlReader["idPatient"]);
                    name_of_patientTextBox.Text = Convert.ToString(sqlReader["Name"]);
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
            if (idPatientTextBox.Text != "" && idStaffTextBox.Text != "" && name_of_patientTextBox.Text != "" && dateDateTimePicker.Text != "")
            {
                sc.Open();
                SqlCommand insertReception = new SqlCommand("INSERT INTO [Reception] (idPatient,idStaff,Name_of_patient,isFinished,Date) VALUES (@idPatient,@idStaff,@Name_of_patient,@isFinished,@Date) ", sc);
                //SqlCommand DelAuth = new SqlCommand("DELETE FROM [Autentification] WHERE Autentification_id = @idAutentification", sc)
                try
                {
                    insertReception.Parameters.AddWithValue("idPatient", Convert.ToInt32(idPatientTextBox.Text));
                    insertReception.Parameters.AddWithValue("idStaff", Convert.ToInt32(idStaffTextBox.Text));
                    insertReception.Parameters.AddWithValue("Name_of_patient", name_of_patientTextBox.Text);
                    insertReception.Parameters.AddWithValue("isFinished", "Нет");
                    insertReception.Parameters.AddWithValue("Date", Convert.ToDateTime(dateDateTimePicker.Text));

                    //insertAuth.Parameters.AddWithValue("Autentification_id", Convert.ToInt32(idAutentificationTextBox.Text));
                    //insertAuth.Parameters.AddWithValue("login", loginTextBox.Text);
                    //insertAuth.Parameters.AddWithValue("password", passwordTextBox.Text);

                    insertReception.ExecuteNonQuery();
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

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
