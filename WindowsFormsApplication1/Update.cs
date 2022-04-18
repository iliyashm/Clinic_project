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
    public partial class Update : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=REVOLT\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private int id;
        public Update(SqlConnection sc,int id)
        {
            InitializeComponent();
            cmd.Connection = sc;
            this.id = id;
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Update_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Autentification' table. You can move, or remove it, as needed.
            //this.autentificationTableAdapter.Fill(this.dataSet1.Autentification);
            sc.Open();
            // TODO: This line of code loads data into the 'dataSet1.Staff' table. You can move, or remove it, as needed.
            //this.staffTableAdapter.Fill(this.dataSet1.Staff);
            SqlCommand getStaffInfo = new SqlCommand("SELECT [Name],[Phone],[Adress],[Passport],[idAutentification],[Role] FROM [Staff] WHERE [idStaff] = @Id",sc);
            SqlCommand getAuthInfo = new SqlCommand("SELECT [login] FROM Autentification JOIN Staff ON Autentification.Autentification_id = Staff.idAutentification WHERE [idStaff] = @Id",sc);

            getStaffInfo.Parameters.AddWithValue("Id", id);
            getAuthInfo.Parameters.AddWithValue("Id", id);
            SqlDataReader sqlReader = null;
            //SqlDataReader sqlReader2 = null;
            try
            {
                sqlReader = getStaffInfo.ExecuteReader();
                while (sqlReader.Read())
                {
                    nameTextBox.Text = Convert.ToString(sqlReader["Name"]);
                    phoneTextBox.Text = Convert.ToString(sqlReader["Phone"]);
                    adressTextBox.Text = Convert.ToString(sqlReader["Adress"]);
                    passportTextBox.Text = Convert.ToString(sqlReader["Passport"]);
                    //idAutentificationTextBox.Text = Convert.ToString(sqlReader["idAutentification"]);
                    roleTextBox.Text = Convert.ToString(sqlReader["Role"]);
                }
                sqlReader.Close();
                sqlReader = null;
                sqlReader = getAuthInfo.ExecuteReader();
                while (sqlReader.Read())
                {
                    loginTextBox.Text = Convert.ToString(sqlReader["login"]);
                    //passwordTextBox.Text = "";
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
            SqlCommand updateStaff = new SqlCommand("UPDATE [Staff] SET [Name] = @Name,[Phone] = @Phone,[Adress] = @Adress,[Passport] = @Passport,[Role] = @Role WHERE [idStaff] = @Id", sc);
            SqlCommand updateAuth = new SqlCommand("UPDATE [Autentification] SET [login] = @login from Staff as s1 where s1.idAutentification = Autentification.Autentification_id and s1.Passport = @passport", sc);
            SqlCommand updatePassword = new SqlCommand("UPDATE [Autentification] SET [password] = PWDENCRYPT(@password) from Staff as s1 where s1.idAutentification = Autentification.Autentification_id and s1.Passport = @passport", sc);
            try
            {
            updateStaff.Parameters.AddWithValue("Name", nameTextBox.Text);
            updateStaff.Parameters.AddWithValue("Phone", phoneTextBox.Text);
            updateStaff.Parameters.AddWithValue("Adress", adressTextBox.Text);
            updateStaff.Parameters.AddWithValue("Passport", passportTextBox.Text);
            //updateStaff.Parameters.AddWithValue("idAutentification", Convert.ToInt32(idAutentificationTextBox.Text));
            updateStaff.Parameters.AddWithValue("Role", roleTextBox.Text);
            updateStaff.Parameters.AddWithValue("Id", id);
            //updateAuth.Parameters.AddWithValue("idAutentification", Convert.ToInt32(idAutentificationTextBox.Text));
            updateAuth.Parameters.AddWithValue("login", loginTextBox.Text);
            
            updateAuth.Parameters.AddWithValue("passport", passportTextBox.Text);
            
               
                updateStaff.ExecuteNonQuery();
                updateAuth.ExecuteNonQuery();
                if (passportTextBox.Text != "")
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
