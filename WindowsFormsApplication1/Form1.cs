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
    public partial class Form1 : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=REVOLT\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        String globalConstForList;
        public Form1()
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void administrationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.administrationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Autentification' table. You can move, or remove it, as needed.
            //this.autentificationTableAdapter.Fill(this.dataSet1.Autentification);
            // TODO: This line of code loads data into the 'dataSet1.Administration' table. You can move, or remove it, as needed.
            this.administrationTableAdapter.Fill(this.dataSet1.Administration);

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void administrationBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc.Open();
            string IdAutentification = null;
            int NumAutentification = 0;
            cmd.CommandText = "SELECT Autentification_id FROM Autentification WHERE(dbo.Autentification.login  = '" + loginTextBox.Text + "' AND PWDCOMPARE('" + passwordTextBox.Text + "',dbo.Autentification.password) = 1)";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    IdAutentification = reader["Autentification_id"].ToString();
                    NumAutentification = Int32.Parse(IdAutentification);
                }
            }
            if ((NumAutentification > 10000) && (NumAutentification < 20000))
            {
                Patient pt = new Patient();
                pt.Show();
                this.Hide();
            }
            else if ((NumAutentification > 20010) && (NumAutentification < 20020))
            {
                Secretary sec = new Secretary();
                sec.Show();
                this.Hide();
            }
            else if ((NumAutentification > 20020) && (NumAutentification < 30000))
            {
                Doctor doc = new Doctor();
                doc.Show();
                this.Hide();
            }
            else if (NumAutentification > 30000)
            {
                Administration adm = new Administration();
                adm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Вы ввели неправильный логин или пароль. Попробуйте снова");
            }
            sc.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
